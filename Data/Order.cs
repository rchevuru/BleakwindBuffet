/*
 * Author: Zachery Brunner
 * Class: Order.cs
 * Purpose: Represents an order with the Bleakwind Buffet
 */
using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace BleakwindBuffet.Data
{
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// This event will be invoked when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Private variable declaration
        /// </summary>
        private const double taxRate = .0895;
        private double subTotal = 0.00; 
        private string displayDate;
        private uint orderNumber;
        private List<IOrderItem> items;

        /// <summary>
        /// Property getter for the private displayDate variable
        /// </summary>
        public string DisplayDate
        {
            get
            {
                return displayDate;
            }
            set
            {
                displayDate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DisplayDate"));
            }
        }

        /// <summary>
        /// Property getter and private setter for the private orderNumber variable
        /// </summary>
        public uint OrderNumber 
        {
            get 
            { 
                return orderNumber; 
            }
            set
            {
                orderNumber = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OrderNumber"));
            }
        }

        /// <summary>
        /// Property getter and private setter for the private subTotal variable
        /// </summary>
        public double SubTotal
        {
            get
            {
                return subTotal;
            }
            set
            {
                subTotal = value; 
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubTotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            }
        }

        /// <summary>
        /// Property getter and private setter for the private tax variable
        /// </summary>
        public double Tax { get { return Math.Round((SubTotal * taxRate), 2); } }

        /// <summary>
        /// Property getter for the Total of the Order
        /// </summary>
        public double Total { get { return SubTotal + Tax; } }

        /// <summary>
        /// Property getter and private setter for the private total variable
        /// </summary>
        public IEnumerable<IOrderItem> Items
        {
            get { return items.ToArray(); }
        }

        /// <summary>
        /// Adds an item to the order
        /// </summary>
        public IOrderItem AddItem
        {
            set
            {
                items.Insert(0, value);
                CalculateSubtotal();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            }
        }

        /// <summary>
        /// Removes an item from the order
        /// </summary>
        public IOrderItem RemoveItem
        {
            set
            {
                bool removed = false;
                for(int i = 0; i < items.Count; i++)
                {
                    if (items[i] == value)
                    {
                        items.Remove(value);
                        removed = true;
                    }
                }
                if (!removed)
                    throw new NotImplementedException("Should never be reached");
                CalculateSubtotal();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            }
        }

        /// <summary>
        /// Helper function that allows me to InvokePropertyChanged on items to update the special instructions of the items
        /// </summary>
        public void SpecialInstructionsOnComboChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        /// <summary>
        /// Public constructor
        /// </summary>
        public Order(uint OrderNumber)
        {
            this.OrderNumber = OrderNumber;
            items = new List<IOrderItem>();

            DateTime now = DateTime.Now;
            DisplayDate = string.Format("{0}", DateTime.Now);
        }

        /// <summary>
        /// Helper function to calculate the total of the order
        /// </summary>
        public void CalculateSubtotal()
        {
            double subT = 0;
            foreach (IOrderItem i in Items)
            {
                subT += i.Price;
            }
            SubTotal = subT;
        }
    }
}