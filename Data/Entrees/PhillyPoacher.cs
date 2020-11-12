/*
* Author: Zachery Brunner
* Class name: PhillyPoacher.cs
* Purpose: Class used to represent the philly poacher
*/
using System.ComponentModel;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// This event will be invoked when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Private variable declaration
        /// </summary>
        private string name = "Philly Poacher";
        private bool sirloin = true;
        private bool onion = true;
        private bool roll = true;
        private string description = "Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll."; 

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
        /// Property getter/setter for private sirloin variable
        /// </summary>
        public bool Sirloin
        {
            get { return sirloin; }
            set
            {
                sirloin = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sirloin"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Property getter/setter for private onion variable
        /// </summary>
        public bool Onion
        {
            get { return onion; }
            set
            {
                onion = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Onion"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Property getter/setter for private roll variable
        /// </summary>
        public bool Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Roll"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Returns the price of the entree
        /// </summary>
        public override double Price
        {
            get { return EntreePricesAndCalories.PHILLY_POACHER_PRICE; }
        }

        /// <summary>
        /// Returns the number of calories in the entree
        /// </summary>
        public override uint Calories
        {
            get { return EntreePricesAndCalories.PHILLY_POACHER_CALORIES; }
        }

        /// <summary>
        /// Special instructions for how to prepare the entree
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> si = new List<string>();
                if (!Sirloin) si.Add("Hold sirloin");
                if (!Onion) si.Add("Hold onion");
                if (!Roll) si.Add("Hold roll");

                if (si.Count == 0) si.Add("No special instructions");

                return si;
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