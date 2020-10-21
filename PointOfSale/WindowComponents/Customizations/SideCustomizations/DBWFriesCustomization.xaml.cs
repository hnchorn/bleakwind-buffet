/*
 * Author: Hannah Chorn
 * Class name: DBWFriesCustomization.xaml.cs
 * Purpose: Class used to represent the Dragonborn Waffle Fries
 * customization screen on the GUI interface.
 */

using System;
using System.Collections.Generic;
using System.Linq;
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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DBWFriesCustomization.xaml
    /// </summary>
    public partial class DBWFriesCustomization : UserControl
    {
        MainWindow mainWindow;

        /// <summary>
        /// Initalizes the screen and sets its 
        /// parent as the Main Window Screen.
        /// </summary>
        /// <param name="mainWindow">Parent screen.</param>
        public DBWFriesCustomization(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        void DoneClickHandle(object sender, EventArgs e)
        {
            if (mainWindow.DataContext is Order order)
            {
                IOrderItem item = order.Last();
                if (item is Combo)
                {

                    this.mainWindow.SwitchScreen("comboCustom");
                }
                else
                {
                    this.mainWindow.SwitchScreen("menuSelect");
                }
            }
        }
    }
}
