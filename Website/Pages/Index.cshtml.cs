/*
 * Author: Hannah Chorn
 * Class: Index.cshtml.cs
 * Purpose: Represents the home page of the Bleakwind Buffet website and what is displayed on it.
 */

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
        /// <summary>
        /// List of items to be displayed on the menu.
        /// </summary>
        public IEnumerable<IOrderItem> Items { get; set; }

        /// <summary>
        /// Search term(s) entered into search bar.
        /// </summary>
        public string SearchTerms { get; set; }

        /// <summary>
        /// Filtering category of item type. (Entree, side, or drink)
        /// </summary>
        public IEnumerable<string> Types { get; set; }

        /// <summary>
        /// List of entrees to be displayed on the menu.
        /// </summary>
        public List<Entree> Entrees { get; set; }

        /// <summary>
        /// List of sides to be displayed on the menu.
        /// </summary>
        public List<Side> Sides { get; set; }

        /// <summary>
        /// List of drinks to be displayed on the menu.
        /// </summary>
        public List<Drink> Drinks { get; set; }

        /// <summary>
        /// Updates the menu depending on search and filtering options.
        /// </summary>
        /// <param name="CaloriesMin">Minimum number of calories to filter.</param>
        /// <param name="CaloriesMax">Maximum number of calories to filter.</param>
        /// <param name="PriceMin">Minimum price to filter.</param>
        /// <param name="PriceMax">Maximum price to filter.</param>
        public void OnGet(int? CaloriesMin, int? CaloriesMax, double? PriceMin, double? PriceMax)
        {
            Items = Menu.FullMenu();
            Entrees = new List<Entree>();
            Sides = new List<Side>();
            Drinks = new List<Drink>();
            
            //Filters by terms in item name or description
            SearchTerms = Request.Query["SearchTerms"];
            if(SearchTerms != null)
            {
                Items = Items.Where(item => item.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase) || item.Description.Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase));
            }

            //Filters by item type
            Types = Request.Query["Types"];
            if(Types != null)
            {
                if (Types.Contains("entree"))
                {
                    Items = Items.Where(item => item is Entree);
                }
                if (Types.Contains("side"))
                {
                    Items = Items.Where(item => item is Side);
                }
                if (Types.Contains("drink"))
                {
                    Items = Items.Where(item => item is Drink);
                }
            }

            //Filters by Calories
            if (CaloriesMin != null && CaloriesMax == null)
            {
                Items = Items.Where(item => item.Calories >= CaloriesMin);
            }
            if(CaloriesMin == null && CaloriesMax != null)
            {
                Items = Items.Where(item => item.Calories <= CaloriesMax);
            }
            if(CaloriesMin != null && CaloriesMax != null)
            {
                Items = Items.Where(item => item.Calories >= CaloriesMin).Where(item => item.Calories <= CaloriesMax);
            }

            //Filters by Price
            if(PriceMin != null && PriceMax == null)
            {
                Items = Items.Where(item => item.Price >= PriceMin);
            }
            if(PriceMin == null && PriceMax != null)
            {
                Items = Items.Where(item => item.Price <= PriceMax);
            }
            if (PriceMin != null && PriceMax != null)
            {
                Items = Items.Where(item => item.Price >= PriceMin).Where(item => item.Price <= PriceMax);
            }
            
            //Divides items into their respective type lists
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
