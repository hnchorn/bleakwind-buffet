/*
 * Author: Hannah Chorn
 * Class name: DDraugrCustomization.xaml.cs
 * Purpose: Class used to represent the DoubleDraugr
 * customization screen on the GUI interface.
 */

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
using BleakwindBuffet.Data.Entrees;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ddCustom.xaml
    /// </summary>
    public partial class DDraugrCustomization : UserControl
    {
        MainWindow mainWindow;

        /// <summary>
        /// Initalizes the screen and sets its 
        /// parent as the Main Window Screen.
        /// </summary>
        /// <param name="mainWindow">Parent screen.</param>
        public DDraugrCustomization(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }
        void DoneClickHandle(object sender, EventArgs e)
        {
            this.mainWindow.SwitchScreen("menuSelect");
        }
    }
}
