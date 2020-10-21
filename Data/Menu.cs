/*
 * Author: Zachery Brunner
 * Class: Menu.cs
 * Purpose: Methods return different parts of the menu
 */
using System;
using System.Collections.Generic;

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;

using Size = BleakwindBuffet.Data.Enums.Size;

namespace BleakwindBuffet.Data
{
    public static class Menu
    {
        /// <summary>
        /// Creates a list of all entrees offered by the BleakwindBuffet
        /// </summary>
        /// <returns>A list containing all available entrees</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();

            entrees.Add(new BriarheartBurger());
            entrees.Add(new DoubleDraugr());
            entrees.Add(new ThalmorTriple());
            entrees.Add(new GardenOrcOmelette());
            entrees.Add(new ThugsTBone());
            entrees.Add(new SmokehouseSkeleton());
            entrees.Add(new PhillyPoacher());

            return entrees;
        }

        /// <summary>
        /// Gathers a list of all possible sides offered by the BleakwindBuffet
        /// </summary>
        /// <returns>A list of all sides which includes every different size of each item</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            
            foreach(Size s in Enum.GetValues(typeof(Size)))
            {
                sides.Add(new DragonbornWaffleFries()
                {
                    Size = s
                });

                sides.Add(new FriedMiraak()
                {
                    Size = s
                });

                sides.Add(new MadOtarGrits()
                {
                    Size = s
                });

                sides.Add(new VokunSalad()
                {
                    Size = s
                });
            }

            return sides;
        }

        /// <summary>
        /// Gathers a list of all possible drinks offered by the BleakwindBuffet
        /// </summary>
        /// <returns>A list of all drinks which includes every different size of each item</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();

            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                drinks.Add(new AretinoAppleJuice()
                {
                    Size = s
                });

                drinks.Add(new CandlehearthCoffee()
                {
                    Size = s
                });

                drinks.Add(new MarkarthMilk()
                {
                    Size = s
                });

                drinks.Add(new SailorSoda()
                {
                    Size = s
                });

                drinks.Add(new WarriorWater()
                {
                    Size = s
                });
            }

            return drinks;
        }

        /// <summary>
        /// Compile the entire menu using the above 3 methods (Entrees(), Drinks(), Sides())
        /// </summary>
        /// <returns>The complete BleakwindBuffet Menu</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> fullMenu = new List<IOrderItem>();

            /* The AddRange Method concats 2 list objects together */
            fullMenu.AddRange(Entrees());
            fullMenu.AddRange(Sides());
            fullMenu.AddRange(Drinks());

            return fullMenu;
        }
    }
}