using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        /*
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        */

        public IEnumerable<IOrderItem> Items { get; set; }

        public string SearchTerms { get; set; }

        public IEnumerable<string> Types { get; set; }

        public List<Entree> Entrees { get; set; }

        public List<Side> Sides { get; set; }

        public List<Drink> Drinks { get; set; }


        public void OnGet(int? CaloriesMin, int? CaloriesMax, double? PriceMin, double? PriceMax)
        {
            Items = Menu.FullMenu();
            Entrees = new List<Entree>();
            Sides = new List<Side>();
            Drinks = new List<Drink>();

            SearchTerms = Request.Query["SearchTerms"];
            Items = Menu.Search(Items, SearchTerms);

            Types = Request.Query["Types"];
            Items = Menu.FilterByCategory(Items, Types);

            Items = Menu.FilterByCalories(Items, CaloriesMin, CaloriesMax);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);

            foreach(IOrderItem item in Items)
            {
                if(item is Entree)
                {
                    Entrees.Add((Entree)item);
                }
                if(item is Side)
                {
                    Sides.Add((Side)item);
                }
                if(item is Drink)
                {
                    Drinks.Add((Drink)item);
                }
            }

        }
    }
}
