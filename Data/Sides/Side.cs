/*
 * Author: Zachery Brunner
 * Class: Side.cs
 * Purpose: Abstract base class for all side items on the menu
 */
using System.Collections.Generic;

using Size = BleakwindBuffet.Data.Enums.Size;

namespace BleakwindBuffet.Data.Sides
{
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// Property that returns the name of the item
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Property that returns the description of the item
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// Property that is used in binding for WPF, allows me to bind to the ToString method in each of the deriving classes
        /// </summary>
        public virtual string ToStringName { get { return ToString(); } }

        /// <summary>
        /// The customization screen of the item
        /// </summary>
        public virtual object Screen { get; set; }

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
        /// Special instructions for how to prepare the side
        ///     Returns "No special instructions" always
        /// </summary>
        public virtual List<string> SpecialInstructions
        {
            get
            {
                return new List<string>() { "No special instructions" };
            }
        }
    }
}