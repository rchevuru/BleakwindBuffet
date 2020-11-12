/*
* Author: Zachery Brunner
* Class name: SmokehouseSkeleton.cs
* Purpose: Class used to represent the smokehouse skeleton
*/
using System.ComponentModel;
using System.Collections.Generic;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// This event will be invoked when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Private variable declaration
        /// </summary>
        private string name = "Smokehouse Skeleton";
        private bool sausageLink = true;
        private bool egg = true;
        private bool hashBrowns = true;
        private bool pancake = true;
        private string description = " Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice."; 

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
        /// Property getter/setter for private sausageLink variable
        /// </summary>
        public bool SausageLink
        {
            get { return sausageLink; }
            set
            {
                sausageLink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SausageLink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Property getter/setter for private egg variable
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set
            {
                egg = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Property getter/setter for private hashBrowns variable
        /// </summary>
        public bool HashBrowns
        {
            get { return hashBrowns; }
            set
            {
                hashBrowns = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HashBrowns"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Property getter/setter for private hashBrowns variable
        /// </summary>
        public bool Pancake
        {
            get { return pancake; }
            set
            {
                pancake = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pancake"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Returns the price of the entree
        /// </summary>
        public override double Price
        {
            get { return EntreePricesAndCalories.SMOKEHOUSE_SKELETON_PRICE; }
        }

        /// <summary>
        /// Returns the number of calories in the entree
        /// </summary>
        public override uint Calories
        {
            get { return EntreePricesAndCalories.SMOKEHOUSE_SKELETON_CALORIES; }
        }

        /// <summary>
        /// Special instructions for how to prepare the entree
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> si = new List<string>();
                if (!SausageLink) si.Add("Hold sausage");
                if (!Egg) si.Add("Hold egg");
                if (!HashBrowns) si.Add("Hold hash browns");
                if (!Pancake) si.Add("Hold pancake");

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