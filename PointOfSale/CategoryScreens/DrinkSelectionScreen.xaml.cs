/*
 * Author: Zachery Brunner
 * Class DrinkSelectionScreen.xaml.cs
 * Purpose: Backend logic
 */
using System;
using System.Windows;
using System.Windows.Controls;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;

using PointOfSale.ExtensionMethod;
using PointOfSale.CustomizationScreens;

namespace PointOfSale.CategoryScreens
{
    /// <summary>
    /// Interaction logic for DrinkSelectionScreen.xaml
    /// </summary>
    public partial class DrinkSelectionScreen : UserControl
    {
        /// <summary>
        /// Public constructor
        /// </summary>
        public DrinkSelectionScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Switches screen to selected drink item on button press
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SwitchScreenToSelectedDrinkItem(object sender, RoutedEventArgs e)
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
                    DrinkCustomizationScreen DCS;
                    switch (((Button)sender).Name)
                    {
                        case "AretinoAppleJuiceButton":
                            DCS = new DrinkCustomizationScreen(item = new AretinoAppleJuice());
                            break;

                        case "CandlehearthCoffeeButton":
                            DCS = new DrinkCustomizationScreen(item = new CandlehearthCoffee());
                            break;

                        case "MarkarthMilkButton":
                            DCS = new DrinkCustomizationScreen(item = new MarkarthMilk());
                            break;

                        case "SailorSodaButton":
                            DCS = new DrinkCustomizationScreen(item = new SailorSoda());
                            break;

                        case "WarriorWaterButton":
                            DCS = new DrinkCustomizationScreen(item = new WarriorWater());
                            break;

                        default:
                            throw new NotImplementedException("Unknown drink item selected");
                    }
                    order.AddItem = item;
                    orderControl?.SwapScreen((FrameworkElement)(item.Screen = DCS));
                }
            }
            else throw new NotImplementedException("Should never be reached");
        }
    }
}