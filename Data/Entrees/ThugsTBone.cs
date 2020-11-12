/*
* Author: Zachery Brunner
* Class name: ThugsTBone.cs
* Purpose: Class used to represent the Thugs T-Bone
*/
using System.ComponentModel;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsTBone : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// This event will be invoked when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Private variable declaration
        /// </summary>
        private string name = "Thugs T-Bone";
        private string description = "Juicy T-Bone, not much else to say."; 

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
        /// Returns the price of the entree
        /// </summary>
        public override double Price
        {
            get { return EntreePricesAndCalories.THUGS_TBONE_PRICE; }
        }

        /// <summary>
        /// Returns the number of calories in the entree
        /// </summary>
        public override uint Calories
        {
            get { return EntreePricesAndCalories.THUGS_TBONE_CALORIES; }
        }

        /// <summary>
        /// Special instructions for how to prepare the entree
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                return new List<string>() { "No special instructions" };
            }
        }

        /// <summary>
        /// Override ToString for entree name return
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name;
        }
    }
}