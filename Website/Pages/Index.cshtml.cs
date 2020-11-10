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

        public string SearchTerms { get; set; }

        public string[] Category { get; set; } = new string[0];

        public IEnumerable<IOrderItem> Items { get; set; } 

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

      
        public void OnGet(string SearchTerms,string[] Types, uint? minCal, uint? maxCal,  double? minPrice, double? maxPrice)
        {
            Items = Menu.Search(SearchTerms);
            Items = Menu.Category(Items, Types);
            Items = Menu.FilterByCalories(Items, minCal, maxCal);
            Items = Menu.FilterByPrice(Items, minPrice, maxPrice); 
        }
       
    }
}
