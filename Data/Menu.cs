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
using System.Linq;
using System.IO; 

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

        /// <summary>
        /// This property will get IOrder property and gets and sets in back end
        /// </summary>
        public static IEnumerable<IOrderItem> Items { get; set; }

        /// <summary>
        /// This property gets the whole menu 
        /// </summary>
        public static IEnumerable<IOrderItem> All { get { return Menu.FullMenu(); } }

        /// <summary>
        ///  Gets the Menu Types represented in the database 
        /// </summary>
        public static string[] CategoryProperty
        {
            get => new string[]
            {
                "Entrees",
                "Drinks",
                "Sides"
            };
        }

        /// <summary>
        /// Searchs the database
        /// </summary>
        /// <param name="terms">user input for search</param>
        /// <returns>the list of items searched</returns>
        public static IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            if (terms == null)
                return All;
            foreach (IOrderItem menu in All)
            {
                if (menu.Name != null && menu.Name.Contains(terms))
                    results.Add(menu);
            }
            return results;
        }

        /// <summary>
        /// Filters the provided collection of movies
        /// </summary>
        /// <param name="items">The collection of movies to filter</param>
        /// <param name="menuTypes">The ratings to include</param>
        /// <returns>A collection containing only movies that match the filter</returns>
        public static IEnumerable<IOrderItem> Category(IEnumerable<IOrderItem> items, IEnumerable<string> menuTypes)
        {
            if (menuTypes == null || menuTypes.Count() == 0) return items; 

            // Filter the supplied collection of Menu types 
            List<IOrderItem> results = new List<IOrderItem>();

            foreach (IOrderItem item in items)
            {
                if (item is Entree && menuTypes.Contains("Entrees"))
                {
                    results.Add(item);
                }
                else if (item is Drink && menuTypes.Contains("Drinks"))
                {
                    results.Add(item);
                }
                else if (item is Side && menuTypes.Contains("Sides"))
                {
                    results.Add(item);
                }
            }

            return results;
        }

        /// <summary>
        /// Filters the provided collection of Menu items
        /// </summary>
        /// <param name="items">The collection of movies to filter</param>
        /// <param name="ratings">The ratings to include</param>
        /// <returns>A collection containing only movies that match the filter</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, uint? min, uint? max)
        {
            if (min == null && max == null) return items;

            var results = new List<IOrderItem>();
            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in items)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> menu, double? min, double? max)
        {
            if (min == null && max == null) return menu;

            var results = new List<IOrderItem>();
            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in menu)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in menu)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in menu)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}