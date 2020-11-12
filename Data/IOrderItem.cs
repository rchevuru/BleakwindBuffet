/*
 * Author: Zachery Brunner
 * Class: IOrderItem.cs
 * Purpose: Interface for all items on the menu
 */
using System.Collections.Generic;

namespace BleakwindBuffet.Data
{
    public interface IOrderItem
    {
        /// <summary>
        /// Property that returns the name of the drink
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Property that is used in binding for WPF, allows me to bind to the ToString method in each of the deriving classes
        /// </summary>
        string ToStringName { get; }

        /// <summary>
        /// Property that returns the description of item 
        /// </summary>
        string Description { get; }

        /// <summary>
        /// The customization screen of the item
        /// </summary>
        object Screen { get; set; }

        /// <summary>
        /// Property that returns the price of the item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Property that returns the calories of the item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Special instructions list for modifying the item
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}