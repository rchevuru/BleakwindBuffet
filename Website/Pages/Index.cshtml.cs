/*
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data; 

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        /// <summary>
        /// gets and sets the Search terms 
        /// </summary>
        public string SearchTerms { get; set; }

        /// <summary>
        /// gets and sets the menu types 
        /// </summary>
        public string[] Category { get; set; } = new string[0];

        /// <summary>
        /// This property will get IOrder property and gets and sets in back end
        /// </summary>
        public IEnumerable<IOrderItem> Items { get; set; } 

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Program runs to set the program with user response 
        /// </summary>
        /// <param name="SearchTerms">the string to be searched</param>
        /// <param name="Types">The collection of menu items checked</param>
        /// <param name="minCal">minumum calories from user input</param>
        /// <param name="maxCal">>maximum calories from user input</param>
        /// <param name="minPrice">mininimum price from user</param>
        /// <param name="maxPrice">max price from user</param>
        public void OnGet(string SearchTerms,string[] Types, uint? minCal, uint? maxCal,  double? minPrice, double? maxPrice)
        {
            Items = Menu.All;
           
            // Search menu name and description for the SearchTerms
            if (SearchTerms != null)
            {
                List<IOrderItem> result = new List<IOrderItem>();
                //Items = Items.Where(item => item.Name != null && item.Name.Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase) || item.Description != null && item.Description.Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase));

                string[] individual = SearchTerms.Split(" ");
                IEnumerable<IOrderItem> terms = new List<IOrderItem>();
               
               foreach(string word in individual)
                {
                    terms = Items.Where(item => item.Name != null && item.Name.Contains(word, StringComparison.InvariantCultureIgnoreCase) || item.Description != null && item.Description.Contains(word, StringComparison.InvariantCultureIgnoreCase));
                    result.AddRange(terms); 
                }
                Items = result;
            }
            
            // Items = Menu.Search(SearchTerms);
            if (Types.Count() != 0)
            {
                Items = Items.Where(item => {
                   
                        if (item is Entree && Types.Contains("Entrees"))
                        {
                            return true; 
                        }
                        else if (item is Drink && Types.Contains("Drinks"))
                        {
                            return true; 
                        }
                        else if (item is Side && Types.Contains("Sides"))
                        {
                            return true; 
                        }

                    
                    return false; 
                });  
            }

            //Items = Menu.Category(Items, Types);
           
            if(minCal != null && maxCal != null)
            {
                List<IOrderItem> result = new List<IOrderItem>();
                Items = Items.Where(item =>
                {
                    if(item.Calories >= minCal && item.Calories <= maxCal)
                    {
                        return true; 
                    }
                   
                    return false; 
                }); 
            }
            else if (minCal == null )
            {
                Items.Where(item =>
                {
                    if (item.Calories >= maxCal) return false;
                    return false; 
                }); 
                
            }
            else if(maxCal == null)
            {
                Items = Items.Where(item =>
                {
                    if (item.Calories >= minCal) return true;
                    return false; 
                }); 
                
            }
            //Items = Menu.FilterByCalories(Items, minCal, maxCal);
            if (minPrice != null && maxPrice != null)
            {
                List<IOrderItem> result = new List<IOrderItem>();
                Items = Items.Where(item =>
                {
                    if (item.Price >= minCal && item.Price <= maxCal)
                    {
                        return true;
                    }

                    return false;
                });
            }
            else if (minPrice == null)
            {
                Items.Where(item =>
                {
                    if (item.Price >= maxPrice) return false;
                    return false;
                });

            }
            else if (maxCal == null)
            {
                Items = Items.Where(item =>
                {
                    if (item.Calories >= minPrice) return true;
                    return false;
                });

            }
            //Items = Menu.FilterByPrice(Items, minPrice, maxPrice); 
        }
       
    }
}
