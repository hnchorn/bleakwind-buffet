/*
 * Author: Hannah Chorn
 * Class name: MainWindow.xaml.cs
 * Purpose: Class used to represent the Main Window of the GUI interface.
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
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
        OrderSummary orderSummary;
        PaymentOptions paymentOptions;
        CashRegister cashRegister;

        ComboCustomization comboCustom;

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

        /// <summary>
        /// Initalizes MainWindow an decalres variables for each
        /// of the screens.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new Order();

            menuSelect = new MenuSelect(this);
            orderSummary = new OrderSummary(this);
            paymentOptions = new PaymentOptions(this);
            cashRegister = new CashRegister(this);

            comboCustom = new ComboCustomization(this);

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
            orderScreen.Child = orderSummary;
        }


        /// <summary>
        /// Switches the menu selection screen out for the
        /// item customization screen, depending on the item 
        /// chosen from the menu.
        /// </summary>
        /// <param name="name">Variable representing the screen.</param>
        public FrameworkElement SwitchScreen(string name)
        {
            switch (name)
            {
                //Default menu screen
                case "menuSelect":
                    screen.Child = menuSelect;
                    return menuSelect;

                //Payment Option screen
                case "paymentOptions":
                    screen.Child = paymentOptions;
                    return paymentOptions;
                //Cash Payment screen
                case "cashRegister":
                    screen.Child = cashRegister;
                    return cashRegister;

                //Combo customization screen
                case "comboCustom":
                    screen.Child = comboCustom;
                    return comboCustom;

                //Entree customization screens
                case "bbCustom":
                    screen.Child = bbCustom;
                    return bbCustom;
                case "ddCustom":
                    screen.Child = ddCustom;
                    return ddCustom;
                case "ttCustom":
                    screen.Child = ttCustom;
                    return ttCustom;
                case "gooCustom":
                    screen.Child = gooCustom;
                    return gooCustom;
                case "ppCustom":
                    screen.Child = ppCustom;
                    return ppCustom;
                case "ssCustom":
                    screen.Child = ssCustom;
                    return ssCustom;

                //Side customization screens
                case "dbwfCustom":
                    screen.Child = dbwfCustom;
                    return dbwfCustom;
                case "fmCustom":
                    screen.Child = fmCustom;
                    return fmCustom;
                case "mogCustom":
                    screen.Child = mogCustom;
                    return mogCustom;
                case "vsCustom":
                    screen.Child = vsCustom;
                    return vsCustom;

                //Drink customization screens
                case "aajCustom":
                    screen.Child = aajCustom;
                    return aajCustom;
                case "ccCustom":
                    screen.Child = ccCustom;
                    return ccCustom;
                case "mmCustom":
                    screen.Child = mmCustom;
                    return mmCustom;
                case "ssodaCustom":
                    screen.Child = ssodaCustom;
                    return ssodaCustom;
                case "wwCustom":
                    screen.Child = wwCustom;
                    return wwCustom;
                default:
                    return null;

            }
        }
    }
}
