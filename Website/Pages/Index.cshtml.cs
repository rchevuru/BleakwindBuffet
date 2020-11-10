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

        public IEnumerable<IOrderItem> Items { get; set; } 

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public  IEnumerable<IOrderItem> All { get { return Menu.FullMenu(); } }

        public string[] CategoryProperty
        {
            get => new string[]
            {
                "Entrees",
                "Drinks",
                "Sides"
            }; 
        }

        public void OnGet(string SearchTerms,string[] Types, uint? minCal, uint? maxCal,  double? minPrice, double? maxPrice)
        {
            Items = Search(SearchTerms);
            Types = CategoryProperty; 
            Items = Category(Items, Types); 
        }
        public IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            if (terms == null)
                return All; 
            foreach(IOrderItem menu in All)
            {
                if (menu.Name != null && menu.Name.Contains(terms, StringComparison.CurrentCultureIgnoreCase))
                    results.Add(menu); 
            }
            return results; 
        }

        public IEnumerable<IOrderItem> Category(IEnumerable<IOrderItem> items, IEnumerable<string> menuTypes)
        {
            if (menuTypes == null || menuTypes.Count() == 0) return items;

            // Filter the supplied collection of movies
            List<IOrderItem> results = new List<IOrderItem>();

            foreach (IOrderItem item in Items)
            {
                if (item is Entree  && menuTypes.Contains("Entrees"))
                {
                    results.Add(item);
                }
                else if (item is Drink && menuTypes.Contains("Drinks"))
                {
                    results.Add(item);
                }
                else if(item is Side && menuTypes.Contains("Sides"))
                {
                    results.Add(item); 
                }
            }

            return results;
        }
    }
}
