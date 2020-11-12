/*
 * Author: Zachery Brunner
 * Class: Drink.cs
 * Purpose: Abstract base class for all drink items on the menu
 */
using System.Collections.Generic;

using Size = BleakwindBuffet.Data.Enums.Size;

namespace BleakwindBuffet.Data.Drinks
{
    public abstract class Drink: IOrderItem
    {
        /// <summary>
        /// Property that returns the name of the drink
        /// </summary>
        public abstract string Name { get; }

        public abstract string Description { get; }

        /// <summary>
        /// Property that is used in binding for WPF, allows me to bind to the ToString method in each of the deriving classes
        /// </summary>
        public virtual string ToStringName => ToString();

        /// <summary>
        /// The customization screen of the item
        /// </summary>
        public virtual object Screen { get; set; }

        /// <summary>
        /// Property that returns if the drink should include ice
        /// </summary>
        public abstract bool Ice { get; set; }

        /// <summary>
        /// Property that returns and sets the size of the item
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Property that returns the price of the item
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Property that returns the calories of the item
        /// </summary>
        public abstract uint Calories { get; }

        ///<summary>
        /// Special instructions for how to prepare the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}