/*
 * Author: Hannah Chorn
 * Class name: WWaterCustomization.xaml.cs
 * Purpose: Class used to represent the Warrior Water
 * customization screen on the GUI interface.
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for WWaterCustomization.xaml
    /// </summary>
    public partial class WWaterCustomization : UserControl
    {
        MainWindow mainWindow;

        /// <summary>
        /// Initalizes the screen and sets its 
        /// parent as the Main Window Screen.
        /// </summary>
        /// <param name="mainWindow">Parent screen.</param>
        public WWaterCustomization(MainWindow mainWindow)
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
