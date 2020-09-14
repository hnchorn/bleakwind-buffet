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

        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> list = new List<IOrderItem>();

            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                DragonbornWaffleFries dwf = new DragonbornWaffleFries();
                dwf.Size = size;
                list.Add(dwf);

                FriedMiraak fm = new FriedMiraak();
                fm.Size = size;
                list.Add(fm);

                MadOtarGrits mog = new MadOtarGrits();
                mog.Size = size;
                list.Add(mog);

                VokunSalad vs = new VokunSalad();
                vs.Size = size;
                list.Add(vs);
            }

            return list;
        }

        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            
            foreach(Size size in Enum.GetValues(typeof(Size)))
            {
                AretinoAppleJuice aj = new AretinoAppleJuice();
                aj.Size = size;
                list.Add(aj);

                CandlehearthCoffee cc = new CandlehearthCoffee();
                cc.Size = size;
                list.Add(cc);

                MarkarthMilk mm = new MarkarthMilk();
                mm.Size = size;
                list.Add(mm);

                WarriorWater ww = new WarriorWater();
                ww.Size = size;
                list.Add(ww);

                foreach(SodaFlavor flavor in Enum.GetValues(typeof(SodaFlavor)))
                {
                    SailorSoda ss = new SailorSoda();
                    ss.Size = size;
                    ss.Flavor = flavor;
                    list.Add(ss);
                }
            }

            return list;
        }

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
