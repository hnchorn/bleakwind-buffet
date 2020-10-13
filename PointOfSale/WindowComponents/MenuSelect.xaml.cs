/*
 * Author: Hannah Chorn
 * Class name: MenuSelect.xaml.cs
 * Purpose: Class used to represent the Menu Selection on the 
 * GUI interface.
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuSelect.xaml
    /// </summary>
    public partial class MenuSelect : UserControl
    {
        MainWindow mainWindow;

        /// <summary>
        /// Initalizes the menu selection screen and 
        /// sets its parent as the Main Window Screen.
        /// </summary>
        /// <param name="mainWindow">Parent screen.</param>
        public MenuSelect(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            BriarheartBurger bb = new BriarheartBurger();

        }

        //Entree click handles
        void BbClickHandle(object sender, EventArgs e)
        {
            BriarheartBurger bb = new BriarheartBurger();
            var screen = this.mainWindow.SwitchScreen("bbCustom");
            screen.DataContext = bb;
            if (mainWindow.DataContext is Order order)
            {
                order.Add(bb);
            }

        }
        
        void DdClickHandle(object sender, EventArgs e)
        {
            DoubleDraugr dd = new DoubleDraugr();
            var screen = this.mainWindow.SwitchScreen("ddCustom");
            screen.DataContext = dd;
            if (mainWindow.DataContext is Order order)
            {
                order.Add(dd);
            }
        }

        void TtClickHandle(object sender, EventArgs e)
        {
            ThalmorTriple tt = new ThalmorTriple();
            var screen = this.mainWindow.SwitchScreen("ttCustom");
            screen.DataContext = tt;
            if (mainWindow.DataContext is Order order)
            {
                order.Add(tt);
            }
        }
        void GooClickHandle(object sender, EventArgs e)
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            var screen = this.mainWindow.SwitchScreen("gooCustom");
            screen.DataContext = goo;
            if (mainWindow.DataContext is Order order)
            {
                order.Add(goo);
            }
        }
        void PpClickHandle(object sender, EventArgs e)
        {
            PhillyPoacher pp = new PhillyPoacher();
            var screen = this.mainWindow.SwitchScreen("ppCustom");
            screen.DataContext = pp;
            if (mainWindow.DataContext is Order order)
            {
                order.Add(pp);
            }
        }
        void SsClickHandle(object sender, EventArgs e)
        {
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            var screen = this.mainWindow.SwitchScreen("ssCustom");
            screen.DataContext = ss;
            if (mainWindow.DataContext is Order order)
            {
                order.Add(ss);
            }
        }
        void TtbClickHandle(object sender, EventArgs e)
        {
            ThugsTBone ttb = new ThugsTBone();
            if (mainWindow.DataContext is Order order)
            {
                order.Add(ttb);
            }
        }

        //Side click handles
        void DbwfClickHandle(object sender, EventArgs e)
        {
            DragonbornWaffleFries dbwf = new DragonbornWaffleFries();
            var screen = this.mainWindow.SwitchScreen("dbwfCustom");
            screen.DataContext = dbwf;
            if (mainWindow.DataContext is Order order)
            {
                order.Add(dbwf);
            }
        }
        void FmClickHandle(object sender, EventArgs e)
        {
            FriedMiraak fm = new FriedMiraak();
            var screen = this.mainWindow.SwitchScreen("fmCustom");
            screen.DataContext = fm;
            if (mainWindow.DataContext is Order order)
            {
                order.Add(fm);
            }
        }
        void MogClickHandle(object sender, EventArgs e)
        {
            MadOtarGrits mog = new MadOtarGrits();
            var screen = this.mainWindow.SwitchScreen("mogCustom");
            screen.DataContext = mog;
            if (mainWindow.DataContext is Order order)
            {
                order.Add(mog);
            }
        }
        void VsClickHandle(object sender, EventArgs e)
        {
            VokunSalad vs = new VokunSalad();
            var screen = this.mainWindow.SwitchScreen("vsCustom");
            screen.DataContext = vs;
            if (mainWindow.DataContext is Order order)
            {
                order.Add(vs);
            }
        }

        //Drink click handles
        void AajClickHandle(object sender, EventArgs e)
        {
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            var screen = this.mainWindow.SwitchScreen("aajCustom");
            screen.DataContext = aaj;
            if (mainWindow.DataContext is Order order)
            {
                order.Add(aaj);
            }
        }
        void CcClickHandle(object sender, EventArgs e)
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            var screen = this.mainWindow.SwitchScreen("ccCustom");
            screen.DataContext = cc;
            if (mainWindow.DataContext is Order order)
            {
                order.Add(cc);
            }
        }
        void MmClickHandle(object sender, EventArgs e)
        {
            MarkarthMilk mm = new MarkarthMilk();
            var screen = this.mainWindow.SwitchScreen("mmCustom");
            screen.DataContext = mm;
            if (mainWindow.DataContext is Order order)
            {
                order.Add(mm);
            }
        }
        void SsodaClickHandle(object sender, EventArgs e)
        {
            SailorSoda ssoda = new SailorSoda();
            var screen = this.mainWindow.SwitchScreen("ssodaCustom");
            screen.DataContext = ssoda;
            if (mainWindow.DataContext is Order order)
            {
                order.Add(ssoda);
            }
        }
        void WwClickHandle(object sender, EventArgs e)
        {
            WarriorWater ww = new WarriorWater();
            var screen = this.mainWindow.SwitchScreen("wwCustom");
            screen.DataContext = ww;
            if (mainWindow.DataContext is Order order)
            {
                order.Add(ww);
            }
        }
        
    }
}
