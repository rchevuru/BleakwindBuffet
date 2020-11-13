/*
 * Author: Zachery Brunner
 * Class: Combo.cs
 * Purpose: Provides a blueprint for what a combo at the BleakwindBuffet is suppose to look like
 */
using System.ComponentModel;
using System.Collections.Generic;

using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.Data
{
    public class EbonyWarriorEntourage : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// This event will be invoked when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Private variable declaration
        /// </summary>
        private Entree entree;
        private Side side;
        private Drink drink;

        /// <summary>
        /// Property getter for the private name variable
        /// </summary>
        public string Name { get; } = "Ebony Warrior Entourage";

        public string Description { get; } = "A combo meal with any side, drink, and entree."; 

        /// <summary>
        /// Just calls the Name property 
        /// </summary>
        public string ToStringName { get { return Name; } }

        /// <summary>
        /// Property getter/setter for private entree variable
        /// </summary>
        public Entree Entree
        {
            get
            {
                return entree;
            }
            set
            {
                entree = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree")); 
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("EntreeName"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Property getter for the name of the entree
        /// </summary>
        public string EntreeName { get { return entree.Name; } }

        /// <summary>
        /// Property getter/setter for private side variable
        /// </summary>
        public Side Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side")); 
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SideName"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Property getter for the name of the side
        /// </summary>
        public string SideName { get { return side.Name; } }

        /// <summary>
        /// Property getter/setter for private drink variable
        /// </summary>
        public Drink Drink
        {
            get
            {
                return drink;
            }
            set
            {
                drink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DrinkName"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Property getter for the name of the drink
        /// </summary>
        public string DrinkName { get { return drink.Name; } }

        /// <summary>
        /// The customization screen of the item
        /// </summary>
        public object Screen { get; set; }
        
        /// <summary>
        /// Returns the price of the item based on size
        /// </summary>
        public double Price { get; } = 10.00;

        /// <summary>
        /// Returns the number of calories in the combo based on what is included in the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return entree.Calories + drink.Calories + side.Calories;
            }
        }

        /// <summary>
        /// Special instructions for how to prepare the combo
        /// </summary>
        public List<string> SpecialInstructions
        {
            get 
            {
                List<string> ls = new List<string>();
                ls.Add(Entree.ToString());
                ls.AddRange(Entree.SpecialInstructions);
                ls.Add(Side.ToString());
                ls.AddRange(Side.SpecialInstructions);
                ls.Add(Drink.ToString());
                ls.AddRange(Drink.SpecialInstructions);
                return ls;
            }
        }
    }
}