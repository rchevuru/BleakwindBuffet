/*
 * Author: Zachery Brunner
 * Class: OrderControl.xaml.cs
 * Purpose: Backend logic for order control,
 *              switches out and holds different screens 
 */
using System;
using System.Windows;
using System.Windows.Controls;

using BleakwindBuffet.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// Public constructor
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();

            var order = new Order(1);
            DataContext = order;
        }

        /// <summary>
        /// Resets the screens and order to original configuration
        /// </summary>
        public void CancelOrder()
        {
            if (DataContext is Order currentOrder)
            {
                DataContext = new Order(currentOrder.OrderNumber + 1);
                SwapScreen(new MenuCategorySelectionControl());
            }
            else throw new NotImplementedException("Should never be reached");
        }

        /// <summary>
        /// Swaps the screen
        /// </summary>
        /// <param name="element">The screen to swap to</param>
        public void SwapScreen(FrameworkElement element)
        {
            MenuItemSelectionControlBorder.Child = element;
        }
    }
}