﻿/*
* Author: Zachery Brunner
* Class name: VokunSalad.cs
* Purpose: Class used to represent the vokun salad
*/
using System;
using System.ComponentModel;

using Size = BleakwindBuffet.Data.Enums.Size;

namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad : Side, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// This event will be invoked when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Private variable declaration
        /// </summary>
        private string name = "Vokun Salad";
        private Size size = Size.Small;
        private string description = "A seasonal fruit salad of mellons, berries, mango, grape, apple, and oranges."; 

        /// <summary>
        /// Returns the name of the item
        /// </summary>
        public override string Name
        {
            get { return name; }
        }

        public override string Description
        {
            get => description;  
        }

        /// <summary>
        /// Property getter/setter for private size variable
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ToStringName"));
            }
        }

        /// <summary>
        /// Returns the price of the drink based on size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return SidePricesAndCalories.SMALL_VOKUN_SALAD_PRICE;
                    case Size.Medium: return SidePricesAndCalories.MEDIUM_VOKUN_SALAD_PRICE;
                    case Size.Large: return SidePricesAndCalories.LARGE_VOKUN_SALAD_PRICE;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }

        /// <summary>
        /// Returns the number of calories in the drink based on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return SidePricesAndCalories.SMALL_VOKUN_SALAD_CALORIES;
                    case Size.Medium: return SidePricesAndCalories.MEDIUM_VOKUN_SALAD_CALORIES;
                    case Size.Large: return SidePricesAndCalories.LARGE_VOKUN_SALAD_CALORIES;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }

        

        /// <summary>
        /// Override ToString for side name return
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size.ToString() + " " + Name;
        }
    }
}