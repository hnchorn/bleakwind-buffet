/*
 * Author: Hannah Chorn
 * Class name: TTripleCustomization.xaml.cs
 * Purpose: Class used to represent the Thalmor Triple
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
    /// Interaction logic for TTripleCustomization.xaml
    /// </summary>
    public partial class TTripleCustomization : UserControl
    {
        MainWindow mainWindow;

        /// <summary>
        /// Initalizes the screen and sets its 
        /// parent as the Main Window Screen.
        /// </summary>
        /// <param name="mainWindow">Parent screen.</param>
        public TTripleCustomization(MainWindow mainWindow)
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
