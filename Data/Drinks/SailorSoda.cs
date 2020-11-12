/*
* Author: Zachery Brunner
* Class name: SailorSoda.cs
* Purpose: Class used to represent the sailor soda
*/
using System;
using System.ComponentModel;
using System.Collections.Generic;

using Size = BleakwindBuffet.Data.Enums.Size;
using SodaFlavor = BleakwindBuffet.Data.Enums.SodaFlavor;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda : Drink, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// This event will be invoked when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Private variable declaration
        /// </summary>
        private string name = "Sailor Soda";
        private bool ice = true;
        private Size size = Size.Small;
        private SodaFlavor flavor = SodaFlavor.Cherry;
        private string description = "An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.";

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
        /// Property getter/setter for private flavor variable
        /// </summary>
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set
            {
                flavor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
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
                    case Size.Small: return DrinkPricesAndCalories.SMALL_SAILOR_SODA_PRICE;
                    case Size.Medium: return DrinkPricesAndCalories.MEDIUM_SAILOR_SODA_PRICE;
                    case Size.Large: return DrinkPricesAndCalories.LARGE_SAILOR_SODA_PRICE;
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
                    case Size.Small: return DrinkPricesAndCalories.SMALL_SAILOR_SODA_CALORIES;
                    case Size.Medium: return DrinkPricesAndCalories.MEDIUM_SAILOR_SODA_CALORIES;
                    case Size.Large: return DrinkPricesAndCalories.LARGE_SAILOR_SODA_CALORIES;
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
                if (!Ice) si.Add("Hold ice");

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
            return Size.ToString() + " " + Flavor.ToString() + " " + Name;
        }
    }
}