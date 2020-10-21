/*
 * Author: Zachery Brunner
 * Class: SideSelectionScreen.xaml.cs
 * Purpose: Backend logic
 */
using System;
using System.Windows;
using System.Windows.Controls;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;

using PointOfSale.ExtensionMethod;
using PointOfSale.CustomizationScreens;

namespace PointOfSale.CategoryScreens
{
    /// <summary>
    /// Interaction logic for SideSelectionScreen.xaml
    /// </summary>
    public partial class SideSelectionScreen : UserControl
    {
        /// <summary>
        /// Public constructor
        /// </summary>
        public SideSelectionScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Switches screen to selected side item on button press
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SwitchScreenToSelectedSideItem(object sender, RoutedEventArgs e)
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
                    SideCustomizationScreen SCS;
                    switch (((Button)sender).Name)
                    {
                        case "DragonWaffleFriesButton":
                            SCS = new SideCustomizationScreen(item = new DragonbornWaffleFries());
                            break;

                        case "FriedMiraakButton":
                            SCS = new SideCustomizationScreen(item = new FriedMiraak());
                            break;

                        case "MadOtarGritsButton":
                            SCS = new SideCustomizationScreen(item = new MadOtarGrits());
                            break;

                        case "VokunSaladButton":
                            SCS = new SideCustomizationScreen(item = new VokunSalad());
                            break;

                        default:
                            throw new NotImplementedException("Unknown drink item selected");
                    }
                    order.AddItem = item;
                    orderControl?.SwapScreen((FrameworkElement)(item.Screen = SCS));
                }
            }
            else throw new NotImplementedException("Should never be reached");
        }
    }
}