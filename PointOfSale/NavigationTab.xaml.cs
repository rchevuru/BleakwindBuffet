/*
 * Author: Zachery Brunner
 * Class: NavigationTab.xaml.cs
 * Purpose: Provides navigation to the selection screen, cancels the order, completes the order
 */
using System;
using System.Windows;
using System.Windows.Controls;

using BleakwindBuffet.Data;

using PointOfSale.ExtensionMethod;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for NavigationTab.xaml
    /// </summary>
    public partial class NavigationTab : UserControl
    {
        /// <summary>
        /// Current combo screen
        /// </summary>
        public object EWEScreen { get; set; }

        /// <summary>
        /// Public constructor
        /// </summary>
        public NavigationTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Allows the user to return to the menu item selection control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnToMenuItemSelectionScreenButton_Click(object sender, RoutedEventArgs e)
        {
            var OrderControl = this.FindAncestor<OrderControl>();
            OrderControl.SwapScreen(new MenuCategorySelectionControl());
            if (OrderControl.DataContext is Order o)
            {
                o.CalculateSubtotal();
            }
            else throw new NotImplementedException("Should never be reached");
        }

        /// <summary>
        /// Resets the screen to take a new order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelOrderButton_Click(object sender, RoutedEventArgs e)
        {
            ReturnToItemSelectionScreenBorder.Visibility = Visibility.Visible;
            ReturnToCurrentComboScreenBorder.Visibility = Visibility.Hidden;
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.CancelOrder();
        }

        public void CallCancelOrderButton_Click(object sender, RoutedEventArgs e)
        {
            CancelOrderButton_Click(sender, e);
        }

        /// <summary>
        /// Completes the order, for now it has the same functionality as the cancel order button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompleteOrderButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwapScreen(new PaymentOptions());
            //CancelOrderButton_Click(sender, e);
        }

        /// <summary>
        /// Returns the ordercontrol screen to the combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnToCurrentComboButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (EWEScreen is null)
                throw new NotImplementedException("Should never be reached");
            
            orderControl.SwapScreen((FrameworkElement)EWEScreen);
            if (orderControl.DataContext is Order o)
            {
                o.CalculateSubtotal();
                o.SpecialInstructionsOnComboChanged();
            }
            else throw new NotImplementedException("Should never be reached");
        }
    }
}