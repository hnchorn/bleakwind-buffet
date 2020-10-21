/*
 * Author: Hannah Chorn
 * Class name: OrderSummary.xaml.cs
 * Purpose: Class used to represent the customer's order
 * summery on the GUI interface.
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
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
using System.Linq;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummary.xaml
    /// </summary>
    public partial class OrderSummary : UserControl
    {
        MainWindow mainWindow;

        /// <summary>
        /// Initalizes the Order Summary screen.
        /// </summary>
        public OrderSummary(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelOrderClickHandle(object sender, RoutedEventArgs e)
        {
            if (mainWindow.DataContext is Order order)
            {
                for(int i = order.Count-1; i >= 0; i--)
                {
                    order.RemoveAt(i);
                }
                mainWindow.SwitchScreen("menuSelect");
            }
        }

        /// <summary>
        /// Click Handle 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompleteOrderClickHandle(object sender, RoutedEventArgs e)
        {
            mainWindow.SwitchScreen("paymentOptions");
            if(mainWindow.DataContext is Order order)
            {
                PaymentOptions payment = new PaymentOptions(mainWindow, order.Total);
            }
        }

        private void RemoveButtonClickHandle(object sender, RoutedEventArgs e)
        {
            if (mainWindow.DataContext is Order order)
            {
                if(sender is Button removeButton)
                {
                    if(removeButton.Parent is StackPanel itemStack)
                    {
                        order.Remove((IOrderItem)itemStack.DataContext);
                    }
                }
            }
        }


        public void SelectionChangedHandler(object sender, SelectionChangedEventArgs args)
        {
            if(sender is ListBox lb)
            {
                if(lb.SelectedItem is IOrderItem item)
                {
                    if (item is Entree)
                    {
                        if (item is BriarheartBurger)
                        {
                            var screen = this.mainWindow.SwitchScreen("bbCustom");
                            screen.DataContext = item;
                        }
                        if (item is DoubleDraugr)
                        {
                            var screen = this.mainWindow.SwitchScreen("ddCustom");
                            screen.DataContext = item;
                        }
                        if (item is ThalmorTriple)
                        {
                            var screen = this.mainWindow.SwitchScreen("ttCustom");
                            screen.DataContext = item;
                        }
                        if (item is GardenOrcOmelette)
                        {
                            var screen = this.mainWindow.SwitchScreen("gooCustom");
                            screen.DataContext = item;
                        }
                        if (item is PhillyPoacher)
                        {
                            var screen = this.mainWindow.SwitchScreen("ppCustom");
                            screen.DataContext = item;
                        }
                        if (item is SmokehouseSkeleton)
                        {
                            var screen = this.mainWindow.SwitchScreen("ssCustom");
                            screen.DataContext = item;
                        }
                    }
                    if (item is Side)
                    {
                        if (item is DragonbornWaffleFries)
                        {
                            var screen = this.mainWindow.SwitchScreen("dbwfCustom");
                            screen.DataContext = item;
                        }
                        if (item is FriedMiraak)
                        {
                            var screen = this.mainWindow.SwitchScreen("fmCustom");
                            screen.DataContext = item;
                        }
                        if (item is MadOtarGrits)
                        {
                            var screen = this.mainWindow.SwitchScreen("mogCustom");
                            screen.DataContext = item;
                        }
                        if (item is VokunSalad)
                        {
                            var screen = this.mainWindow.SwitchScreen("vsCustom");
                            screen.DataContext = item;
                        }
                    }
                    if (item is Drink)
                    {
                        if (item is AretinoAppleJuice)
                        {
                            var screen = this.mainWindow.SwitchScreen("aajCustom");
                            screen.DataContext = item;
                        }
                        if (item is CandlehearthCoffee)
                        {
                            var screen = this.mainWindow.SwitchScreen("ccCustom");
                            screen.DataContext = item;
                        }
                        if (item is MarkarthMilk)
                        {
                            var screen = this.mainWindow.SwitchScreen("mmCustom");
                            screen.DataContext = item;
                        }
                        if (item is SailorSoda)
                        {
                            var screen = this.mainWindow.SwitchScreen("ssodaCustom");
                            screen.DataContext = item;
                        }
                        if (item is WarriorWater)
                        {
                            var screen = this.mainWindow.SwitchScreen("wwCustom");
                            screen.DataContext = item;
                        }
                    }
                    if(item is Combo combo)
                    {
                        var screen = this.mainWindow.SwitchScreen("comboCustom");
                        screen.DataContext = item;
                    }
                }
            }
        }



    }
}
