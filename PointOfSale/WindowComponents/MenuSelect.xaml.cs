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
    /// Interaction logic for MenuSelect.xaml
    /// </summary>
    public partial class MenuSelect : UserControl
    {
        MainWindow mainWindow;

        public MenuSelect(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }
        
        //Entree click handles
        void BbClickHandle(object sender, EventArgs e)
        {
            this.mainWindow.SwitchScreen("bbCustom");
        }

        void DdClickHandle(object sender, EventArgs e)
        {
            this.mainWindow.SwitchScreen("ddCustom");
        }

        void TtClickHandle(object sender, EventArgs e)
        {
            this.mainWindow.SwitchScreen("ttCustom");
        }
        void GooClickHandle(object sender, EventArgs e)
        {
            this.mainWindow.SwitchScreen("gooCustom");
        }
        void PpClickHandle(object sender, EventArgs e)
        {
            this.mainWindow.SwitchScreen("ppCustom");
        }
        void SsClickHandle(object sender, EventArgs e)
        {
            this.mainWindow.SwitchScreen("ssCustom");
        }
        void TtbClickHandle(object sender, EventArgs e)
        {
            //Empty, for now.
        }

        //Side click handles
        void DbwfClickHandle(object sender, EventArgs e)
        {
            this.mainWindow.SwitchScreen("dbwfCustom");
        }
        void FmClickHandle(object sender, EventArgs e)
        {
            this.mainWindow.SwitchScreen("fmCustom");
        }
        void MogClickHandle(object sender, EventArgs e)
        {
            this.mainWindow.SwitchScreen("mogCustom");
        }
        void VsClickHandle(object sender, EventArgs e)
        {
            this.mainWindow.SwitchScreen("vsCustom");
        }

        //Drink click handles
        void AajClickHandle(object sender, EventArgs e)
        {
            this.mainWindow.SwitchScreen("aajCustom");
        }
        void CcClickHandle(object sender, EventArgs e)
        {
            this.mainWindow.SwitchScreen("ccCustom");
        }
        void MmClickHandle(object sender, EventArgs e)
        {
            this.mainWindow.SwitchScreen("mmCustom");
        }
        void SsodaClickHandle(object sender, EventArgs e)
        {
            this.mainWindow.SwitchScreen("ssodaCustom");
        }
        void WwClickHandle(object sender, EventArgs e)
        {
            this.mainWindow.SwitchScreen("wwCustom");
        }
    }
}
