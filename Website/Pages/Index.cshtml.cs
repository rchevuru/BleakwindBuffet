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
            Items = Menu.Search(SearchTerms);
            Items = Menu.Category(Items, Types);
            Items = Menu.FilterByCalories(Items, minCal, maxCal);
            Items = Menu.FilterByPrice(Items, minPrice, maxPrice); 
        }
       
    }
}
