using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MenuSelect menuSelect;

        //Entrees
        BBurgerCustomization bbCustom;
        DDraugrCustomization ddCustom;
        TTripleCustomization ttCustom;
        GOOmeletteCustomization gooCustom;
        PPoacherCustomization ppCustom;
        SSkeletonCustomization ssCustom;
        
        //Sides
        DBWFriesCustomization dbwfCustom;
        FMiraakCustomization fmCustom;
        MOGritsCustomization mogCustom;
        VSaladCustomization vsCustom;

        //Drinks
        AAJuiceCustomization aajCustom;
        CCoffeeCustomization ccCustom;
        MMilkCustomization mmCustom;
        SSodaCustomization ssodaCustom;
        WWaterCustomization wwCustom;

        public MainWindow()
        {
            InitializeComponent();
            menuSelect = new MenuSelect(this);

            //Entrees
            bbCustom = new BBurgerCustomization(this);
            ddCustom = new DDraugrCustomization(this);
            ttCustom = new TTripleCustomization(this);
            gooCustom = new GOOmeletteCustomization(this);
            ppCustom = new PPoacherCustomization(this);
            ssCustom = new SSkeletonCustomization(this);

            //Sides
            dbwfCustom = new DBWFriesCustomization(this);
            fmCustom = new FMiraakCustomization(this);
            mogCustom = new MOGritsCustomization(this);
            vsCustom = new VSaladCustomization(this);

            //Drinks
            aajCustom = new AAJuiceCustomization(this);
            ccCustom = new CCoffeeCustomization(this);
            mmCustom = new MMilkCustomization(this);
            ssodaCustom = new SSodaCustomization(this);
            wwCustom = new WWaterCustomization(this);

            screen.Child = menuSelect;
        }

        public void SwitchScreen(string name)
        {
            switch (name)
            {
                //Default menu screen
                case "menuSelect":
                    screen.Child = menuSelect;
                    break;

                //Entree customization screens
                case "bbCustom":
                    screen.Child = bbCustom;
                    break;
                case "ddCustom":
                    screen.Child = ddCustom;
                    break;
                case "ttCustom":
                    screen.Child = ttCustom;
                    break;
                case "gooCustom":
                    screen.Child = gooCustom;
                    break;
                case "ppCustom":
                    screen.Child = ppCustom;
                    break;
                case "ssCustom":
                    screen.Child = ssCustom;
                    break;

                //Side customization screens
                case "dbwfCustom":
                    screen.Child = dbwfCustom;
                    break;
                case "fmCustom":
                    screen.Child = fmCustom;
                    break;
                case "mogCustom":
                    screen.Child = mogCustom;
                    break;
                case "vsCustom":
                    screen.Child = vsCustom;
                    break;

                //Drink customization screens
                case "aajCustom":
                    screen.Child = aajCustom;
                    break;
                case "ccCustom":
                    screen.Child = ccCustom;
                    break;
                case "mmCustom":
                    screen.Child = mmCustom;
                    break;
                case "ssodaCustom":
                    screen.Child = ssodaCustom;
                    break;
                case "wwCustom":
                    screen.Child = wwCustom;
                    break;

            }
        }
    }
}
