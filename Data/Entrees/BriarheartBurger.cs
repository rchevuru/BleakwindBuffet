/*
* Author: Zachery Brunner
* Class name: BriarheartBurger.cs
* Purpose: Class used to represent the briarheart burger
*/
using System.ComponentModel;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    public class BriarheartBurger : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// This event will be invoked when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Private variable declaration
        /// </summary>
        private string name = "Briarheart Burger";
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;
        private string description = "Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese."; 

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
        /// Property getter/setter for private bun variable
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set
            {
                bun = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Property getter/setter for private ketchup variable
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set
            {
                ketchup = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Property getter/setter for private mustard variable
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set
            {
                mustard = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Property getter/setter for private pickle variable
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Property getter/setter for private cheese variable
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set
            {
                cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Returns the price of the entree
        /// </summary>
        public override double Price
        {
            get { return EntreePricesAndCalories.BRIARHEART_BURGER_PRICE; }
        }

        /// <summary>
        /// Returns the number of calories in the entree
        /// </summary>
        public override uint Calories
        {
            get { return EntreePricesAndCalories.BRIARHEART_BURGER_CALORIES; }
        }

        /// <summary>
        /// Special instructions for how to prepare the entree
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> si = new List<string>();
                if (!Bun) si.Add("Hold bun");
                if (!Ketchup) si.Add("Hold ketchup");
                if (!Mustard) si.Add("Hold mustard");
                if (!Pickle) si.Add("Hold pickle");
                if (!Cheese) si.Add("Hold cheese");

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