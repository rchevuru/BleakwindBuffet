/*
 * Author: Zachery Brunner
 * Class: OrderSummaryControl.xaml.cs
 * Purpose: Backend logic for the OrderSummaryControl
 */
using System;
using System.Windows;
using System.Windows.Controls;

using BleakwindBuffet.Data;

using PointOfSale.ExtensionMethod;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Switches the screen to the selected item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderItemView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ListBox listBox && listBox.SelectedIndex != -1)
            {
                var OrderControl = this.FindAncestor<OrderControl>();
                IOrderItem item = (IOrderItem)((ListBox)sender).SelectedItem;

                if (item == null)
                    OrderControl?.SwapScreen(new MenuCategorySelectionControl());
                else
                    OrderControl?.SwapScreen((FrameworkElement)item.Screen);
                listBox.SelectedIndex = -1;
            }
            else if (sender is ListBox lb && lb.SelectedIndex == -1) return;
            else throw new NotImplementedException("Should never be reached");
        }

        /// <summary>
        /// Removes the selected item from the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteItemButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl?.SwapScreen(new MenuCategorySelectionControl());
            if (DataContext is Order order)
            {
                IOrderItem item = (IOrderItem)((Button)sender).DataContext;
                order.RemoveItem = item;
            }
            else throw new NotImplementedException("Should never be reached");
        }

        /// <summary>
        /// Used to edit the item associated with the edit click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditItemButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if(DataContext is Order order)
            {
                IOrderItem item = (IOrderItem)((Button)sender).DataContext;
                orderControl?.SwapScreen((FrameworkElement)item.Screen);
            }
            else throw new NotImplementedException("Should never be reached");
        }
    }
}