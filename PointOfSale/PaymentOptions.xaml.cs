using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BleakwindBuffet.Data;
using PointOfSale.ExtensionMethod; 

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PaymentOptions.xaml
    /// </summary>
    public partial class PaymentOptions : UserControl
    {
        Register register = new Register();
        public PaymentOptions()
        {
            InitializeComponent();
        }

        private void ReturnToMenuItemSelectionScreenButton_Click(object sender, RoutedEventArgs e)
        {
            var OrderControl = this.FindAncestor<OrderControl>();
            OrderControl.SwapScreen(new MenuCategorySelectionControl());
        }

        private void CardPayment_Click(object sender, RoutedEventArgs e)
        {

            Order order = new Order();
            if (RoundRegister.CardTransactionResult.Approved == register.Checking(order.Total))
            {
                print();
                var OrderControl = this.FindAncestor<OrderControl>();
                Order o = (Order)OrderControl.DataContext;
                uint resetNumber = o.OrderNumber + 1;
                //set order control data context to a new order 
                OrderControl.DataContext = new Order(resetNumber);   
                OrderControl.SwapScreen(new MenuCategorySelectionControl());
            }
            else if (RoundRegister.CardTransactionResult.Declined == register.Checking(order.Total))
            {
                MessageBox.Show("Card declined");
            }
            else if (RoundRegister.CardTransactionResult.ReadError == register.Checking(order.Total))
            {
                MessageBox.Show("Can not read");
            }
            else if (RoundRegister.CardTransactionResult.InsufficientFunds == register.Checking(order.Total))
            {
                MessageBox.Show("Not enough");
            }
            else if (RoundRegister.CardTransactionResult.InsufficientFunds == register.Checking(order.Total))
            {
                MessageBox.Show("Incorrect pin");
            }
        }

        private void CashPayment_Click(object sender, RoutedEventArgs e)
        {
            var OrderControl = this.FindAncestor<OrderControl>();
            OrderControl.SwapScreen(new CashPayment());
        }

        private void print()
        {

        }
    }
}
