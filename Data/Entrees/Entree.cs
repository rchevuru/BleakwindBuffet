/*
 * Author: Zachery Brunner
 * Class: Entree.cs
 * Purpose: Abstract base class for all entree items on the menu
 */
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    public abstract class Entree : IOrderItem
    {
        /// <summary>
        /// Property that returns the name of the drink
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Property that returns the name of the item
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
        /// Property that returns the price of the item
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Property that returns the calories of the item
        /// </summary>
        public abstract uint Calories { get; }

        ///<summary>
        /// Special instructions for how to prepare the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}