/*
 * Author: Hannah Chorn
 * Class name: Menu.cs
 * Purpose: Static class that returns an instance of all 
 * items on the menu.
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using System.IO;
using System.Linq;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Class for representing the menu.
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Creates a list of all entrees on the menu.
        /// </summary>
        /// <returns>A list containing all entrees on the menu.</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> list = new List<IOrderItem>();

            BriarheartBurger bb = new BriarheartBurger();
            list.Add(bb);
            DoubleDraugr dd = new DoubleDraugr();
            list.Add(dd);
            ThalmorTriple tt = new ThalmorTriple();
            list.Add(tt);
            GardenOrcOmelette goo = new GardenOrcOmelette();
            list.Add(goo);
            PhillyPoacher pp = new PhillyPoacher();
            list.Add(pp);
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            list.Add(ss);
            ThugsTBone ttb = new ThugsTBone();
            list.Add(ttb);

            return list;
        }

        /// <summary>
        /// Creates a list of all sides on the menu.
        /// </summary>
        /// <returns>A list containing all sides on the menu.</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> list = new List<IOrderItem>();

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                DragonbornWaffleFries dwf = new DragonbornWaffleFries();
                dwf.Size = size;
                list.Add(dwf);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                FriedMiraak fm = new FriedMiraak();
                fm.Size = size;
                list.Add(fm);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                MadOtarGrits mog = new MadOtarGrits();
                mog.Size = size;
                list.Add(mog);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                VokunSalad vs = new VokunSalad();
                vs.Size = size;
                list.Add(vs);
            }

            return list;
        }

        /// <summary>
        /// Creates a list of all drinks on the menu.
        /// </summary>
        /// <returns>A list containing all drinks on the menu.</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            
            foreach(Size size in Enum.GetValues(typeof(Size)))
            {
                AretinoAppleJuice aj = new AretinoAppleJuice();
                aj.Size = size;
                list.Add(aj);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                CandlehearthCoffee cc = new CandlehearthCoffee();
                cc.Size = size;
                list.Add(cc);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                MarkarthMilk mm = new MarkarthMilk();
                mm.Size = size;
                list.Add(mm);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                WarriorWater ww = new WarriorWater();
                ww.Size = size;
                list.Add(ww);
            }

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                foreach (SodaFlavor flavor in Enum.GetValues(typeof(SodaFlavor)))
                {
                    SailorSoda ss = new SailorSoda();
                    ss.Size = size;
                    ss.Flavor = flavor;
                    list.Add(ss);
                }
            }

            return list;
        }

        /// <summary>
        /// Creates a list of all items on the menu.
        /// </summary>
        /// <returns>A list containing all items on the menu.</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.AddRange(Entrees());
            list.AddRange(Sides());
            list.AddRange(Drinks());
            return list;
        }

        /// <summary>
        /// Filters all the items on the menu depending on the category chosen.
        /// </summary>
        /// <param name="menu">Menu of all items to filter.</param>
        /// <param name="type">The category to filter items into.</param>
        /// <returns>List of all items on the menu that fit into the specified category.</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> menu, IEnumerable<string> type)
        {
            if (type == null || type.Count() == 0) return menu;

            var results = new List<IOrderItem>();
            foreach(IOrderItem item in menu)
            {
                if(type.Contains("entree"))
                {
                    if(item is Entree)
                    {
                        results.Add(item);
                    }
                }
                if (type.Contains("side"))
                {
                    if (item is Side)
                    {
                        results.Add(item);
                    }
                }
                if (type.Contains("drink"))
                {
                    if (item is Drink)
                    {
                        results.Add(item);
                    }
                }
            }
            return results;
        }

        /// <summary>
        /// Filters all the items on the menu depending on a user search.
        /// </summary>
        /// <param name="menu">Menu of all items to filter.</param>
        /// <param name="name">String typed in by user.</param>
        /// <returns>List of all items that fall within the search term(s)</returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> menu, string name)
        {
            var results = new List<IOrderItem>();

            if (name == null) return menu;

            foreach(IOrderItem item in menu)
            {
                string itemString = item.ToString().ToLower();
                if (itemString.Contains(name.ToLower()))
                {
                    results.Add(item);
                }
            }
            
            return results;
        }

        /// <summary>
        /// Filters all of the items on the menu based on calorie count.
        /// </summary>
        /// <param name="menu">Menu of all items to filter.</param>
        /// <param name="min">Minimum calorie search.</param>
        /// <param name="max">Maximum calorie search.</param>
        /// <returns>A list of all menu items that fall into the calorie range.</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> menu, int? min, int? max)
        {
            //if both are empty
            if (min == null && max == null) return menu;

            var results = new List<IOrderItem>();

            //only a maximum specified
            if(min == null)
            {
                foreach(IOrderItem item in menu)
                {
                    if(item.Calories <= max)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }

            //only a minimum specified
            if(max == null)
            {
                foreach(IOrderItem item in menu)
                {
                    if(item.Calories >= min)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }

            //both minimum and maximum specified
            foreach(IOrderItem item in menu)
            {
                if(item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters all of the items on the menu based on price.
        /// </summary>
        /// <param name="menu">Menu of all items to filter.</param>
        /// <param name="min">Minimum price search.</param>
        /// <param name="max">Maximum price search.</param>
        /// <returns>A list of all menu items that fall into the price range.</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> menu, double? min, double? max)
        {
            //if both are empty
            if (min == null && max == null) return menu;

            var results = new List<IOrderItem>();

            //only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in menu)
                {
                    if (item.Price <= max)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }

            //only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in menu)
                {
                    if (item.Price >= min)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }

            //both minimum and maximum specified
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
