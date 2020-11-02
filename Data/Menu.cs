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
    }
}
