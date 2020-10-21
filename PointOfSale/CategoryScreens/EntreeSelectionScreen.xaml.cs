/*
 * Author: Zachery Brunner
 * Class EntreeSelectionScreen.xaml.cs
 * Purpose: Backend logic
 */
using System;
using System.Windows;
using System.Windows.Controls;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

using PointOfSale.ExtensionMethod;
using PointOfSale.CustomizationScreens;

namespace PointOfSale.CategoryScreens
{
    /// <summary>
    /// Interaction logic for EntreeSelectionScreen.xaml
    /// </summary>
    public partial class EntreeSelectionScreen : UserControl
    {
        /// <summary>
        /// Public constructor
        /// </summary>
        public EntreeSelectionScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Switches screen to selected entree item on button press
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SwitchScreenToSelectedEntreeItem(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                var orderControl = this.FindAncestor<OrderControl>();
                if (orderControl == null) throw new Exception("Can not find OrderControl");

                /* The logic we do past this point requires the sender to be a button.
                 *      Although it is redundant good coding practice is to always check */
                if (sender is Button)
                {
                    IOrderItem item;
                    EntreeCustomizationScreen ECS;
                    switch (((Button)sender).Name)
                    {
                        case "BriarheartBurgerButton":
                            ECS = new EntreeCustomizationScreen(item = new BriarheartBurger());
                            break;

                        case "DoubleDraugrButton":
                            ECS = new EntreeCustomizationScreen(item = new DoubleDraugr());
                            break;

                        case "ThalmorTripleButton":
                            ECS = new EntreeCustomizationScreen(item = new ThalmorTriple());
                            break;

                        case "GardenOrcOmeletteButton":
                            ECS = new EntreeCustomizationScreen(item = new GardenOrcOmelette());
                            break;

                        case "PhillyPoacherButton":
                            ECS = new EntreeCustomizationScreen(item = new PhillyPoacher());
                            break;

                        case "SmokehouseSkeletonButton":
                            ECS = new EntreeCustomizationScreen(item = new SmokehouseSkeleton());
                            break;

                        case "ThugsTBoneButton":
                            ECS = new EntreeCustomizationScreen(item = new ThugsTBone());
                            break;

                        default:
                            throw new NotImplementedException("Unknown entree item selected");
                    }
                    order.AddItem = item;
                    orderControl?.SwapScreen((FrameworkElement)(item.Screen = ECS));
                }
            }
            else throw new NotImplementedException("Should never be reached");
        }
    }
}