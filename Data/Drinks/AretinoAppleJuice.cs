/*
* Author: Zachery Brunner
* Class name: AretinoAppleJuice.cs
* Purpose: Class used to represent the Aretino Apple Juice
*/
using System;
using System.ComponentModel;
using System.Collections.Generic;

using Size = BleakwindBuffet.Data.Enums.Size;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice: Drink, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// This event will be invoked when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Private variable declaration
        /// </summary>
        private string name = "Aretino Apple Juice";
        private bool ice = false;
        private Size size = Size.Small;
        private string description = "Fresh squeezed apple juice."; 

        /// <summary>
        /// Property getter for the private name variable
        /// </summary>
        public override string Name
        {
            get { return name; }
        }

        /// <summary>
        /// Property getter for the private description variable
        /// </summary>
        public override string Description
        {
            get => description; 
        }

        /// <summary>
        /// Property getter/setter for private ice variable
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
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
                    case Size.Small: return DrinkPricesAndCalories.SMALL_ARETINO_APPLE_JUICE_PRICE;
                    case Size.Medium: return DrinkPricesAndCalories.MEDIUM_ARETINO_APPLE_JUICE_PRICE;
                    case Size.Large: return DrinkPricesAndCalories.LARGE_ARETINO_APPLE_JUICE_PRICE;
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
                    case Size.Small: return DrinkPricesAndCalories.SMALL_ARETINO_APPLE_JUICE_CALORIES;
                    case Size.Medium: return DrinkPricesAndCalories.MEDIUM_ARETINO_APPLE_JUICE_CALORIES;
                    case Size.Large: return DrinkPricesAndCalories.LARGE_ARETINO_APPLE_JUICE_CALORIES;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }

        /// <summary>
        /// Special instructions for how to prepare the drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> si = new List<string>();
                if (Ice) si.Add("Add ice");

                if (si.Count == 0) si.Add("No special instructions");

                return si;
            }
        }

        /// <summary>
        /// Override ToString for drink name return
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Size.ToString() + " " + Name;
        }
    }
}