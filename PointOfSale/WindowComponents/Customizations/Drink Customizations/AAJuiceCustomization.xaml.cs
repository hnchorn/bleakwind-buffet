﻿using System;
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
    /// Interaction logic for AAJuiceCustomization.xaml
    /// </summary>
    public partial class AAJuiceCustomization : UserControl
    {
        MainWindow mainWindow;

        public AAJuiceCustomization(MainWindow mainWindow)
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
