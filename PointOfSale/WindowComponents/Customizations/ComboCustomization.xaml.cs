using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for ComboCustomization.xaml
    /// </summary>
    public partial class ComboCustomization : UserControl
    {
        MainWindow mainWindow;

        public ComboCustomization(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }


        private void EntreeButtonChangeHandler(object sender, EventArgs e)
        {
            if(sender is ListBox lb)
            {
                if (this.DataContext is Combo combo)
                {
                    if (lb.SelectedIndex == 0)
                    {
                        BriarheartBurger bb = new BriarheartBurger();
                        combo.Entree = bb;
                    }
                    if (lb.SelectedIndex == 1)
                    {
                        DoubleDraugr dd = new DoubleDraugr();
                        combo.Entree = dd;
                    }
                    if (lb.SelectedIndex == 2)
                    {
                        ThalmorTriple tt = new ThalmorTriple();
                        combo.Entree = tt;
                    }
                    if (lb.SelectedIndex == 3)
                    {
                        GardenOrcOmelette goo = new GardenOrcOmelette();
                        combo.Entree = goo;
                    }
                    if (lb.SelectedIndex == 4)
                    {
                        PhillyPoacher pp = new PhillyPoacher();
                        combo.Entree = pp;
                    }
                    if (lb.SelectedIndex == 5)
                    {
                        SmokehouseSkeleton ss = new SmokehouseSkeleton();
                        combo.Entree = ss;
                    }
                    if (lb.SelectedIndex == 6)
                    {
                        ThugsTBone ttb = new ThugsTBone();
                        combo.Entree = ttb;
                    }

                }

            }
            
        }

        private void SideButtonChangeHandler(object sender, EventArgs e)
        {
            if (sender is ListBox lb)
            {
                if (this.DataContext is Combo combo)
                {
                    if (lb.SelectedIndex == 0)
                    {
                        DragonbornWaffleFries dbwf = new DragonbornWaffleFries();
                        combo.Side = dbwf;
                    }
                    if (lb.SelectedIndex == 1)
                    {
                        FriedMiraak fm = new FriedMiraak();
                        combo.Side = fm;
                    }
                    if (lb.SelectedIndex == 2)
                    {
                        MadOtarGrits mog = new MadOtarGrits();
                        combo.Side = mog;
                    }
                    if (lb.SelectedIndex == 3)
                    {
                        VokunSalad vs = new VokunSalad();
                        combo.Side = vs;
                    }

                }

            }

        }

        private void DrinkButtonChangeHandler(object sender, EventArgs e)
        {
            if (sender is ListBox lb)
            {
                if (this.DataContext is Combo combo)
                {
                    if (lb.SelectedIndex == 0)
                    {
                        AretinoAppleJuice aaj = new AretinoAppleJuice();
                        combo.Drink = aaj;
                    }
                    if (lb.SelectedIndex == 1)
                    {
                        CandlehearthCoffee cc = new CandlehearthCoffee();
                        combo.Drink = cc;
                    }
                    if (lb.SelectedIndex == 2)
                    {
                        MarkarthMilk mm = new MarkarthMilk();
                        combo.Drink = mm;
                    }
                    if (lb.SelectedIndex == 3)
                    {
                        SailorSoda ssoda = new SailorSoda();
                        combo.Drink = ssoda;
                    }
                    if (lb.SelectedIndex == 4)
                    {
                        WarriorWater ww = new WarriorWater();
                        combo.Drink = ww;
                    }

                }

            }

        }

        void CustomizeEntreeHandle(object sender, EventArgs e)
        {
            if (this.DataContext is Combo combo)
            {
                if (combo.Entree is BriarheartBurger)
                {
                    var screen = this.mainWindow.SwitchScreen("bbCustom");
                    screen.DataContext = combo.Entree;
                }
                if (combo.Entree is DoubleDraugr)
                {
                    var screen = this.mainWindow.SwitchScreen("ddCustom");
                    screen.DataContext = combo.Entree;
                }
                if (combo.Entree is ThalmorTriple)
                {
                    var screen = this.mainWindow.SwitchScreen("ttCustom");
                    screen.DataContext = combo.Entree;
                }
                if (combo.Entree is GardenOrcOmelette)
                {
                    var screen = this.mainWindow.SwitchScreen("gooCustom");
                    screen.DataContext = combo.Entree;
                }
                if (combo.Entree is PhillyPoacher)
                {
                    var screen = this.mainWindow.SwitchScreen("ppCustom");
                    screen.DataContext = combo.Entree;
                }
                if (combo.Entree is SmokehouseSkeleton)
                {
                    var screen = this.mainWindow.SwitchScreen("ssCustom");
                    screen.DataContext = combo.Entree;
                }
            } 
        }

        void CustomizeSideHandle(object sender, EventArgs e)
        {
            if (this.DataContext is Combo combo)
            {
                if (combo.Side is DragonbornWaffleFries)
                {
                    var screen = this.mainWindow.SwitchScreen("dbwfCustom");
                    screen.DataContext = combo.Side;
                }
                if (combo.Side is FriedMiraak)
                {
                    var screen = this.mainWindow.SwitchScreen("fmCustom");
                    screen.DataContext = combo.Side;
                }
                if (combo.Side is MadOtarGrits)
                {
                    var screen = this.mainWindow.SwitchScreen("mogCustom");
                    screen.DataContext = combo.Side;
                }
                if (combo.Side is VokunSalad)
                {
                    var screen = this.mainWindow.SwitchScreen("vsCustom");
                    screen.DataContext = combo.Side;
                }
            }
        }

        void CustomizeDrinkHandle(object sender, EventArgs e)
        {
            if (this.DataContext is Combo combo)
            {
                if (combo.Drink is AretinoAppleJuice)
                {
                    var screen = this.mainWindow.SwitchScreen("aajCustom");
                    screen.DataContext = combo.Drink;
                }
                if (combo.Drink is CandlehearthCoffee)
                {
                    var screen = this.mainWindow.SwitchScreen("ccCustom");
                    screen.DataContext = combo.Drink;
                }
                if (combo.Drink is MarkarthMilk)
                {
                    var screen = this.mainWindow.SwitchScreen("mmCustom");
                    screen.DataContext = combo.Drink;
                }
                if (combo.Drink is SailorSoda)
                {
                    var screen = this.mainWindow.SwitchScreen("ssodaCustom");
                    screen.DataContext = combo.Drink;
                }
                if (combo.Drink is WarriorWater)
                {
                    var screen = this.mainWindow.SwitchScreen("wwCustom");
                    screen.DataContext = combo.Drink;
                }
            }
        }

        void DoneClickHandle(object sender, EventArgs e)
        {
            this.mainWindow.SwitchScreen("menuSelect");
        }
    }
}
