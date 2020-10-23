/*
 * Author: Hannah Chorn
 * Class name: CashRegister.xaml.cs
 * Purpose: Class used to represent the CashRegister on the 
 * GUI interface.
 */

using BleakwindBuffet.Data;
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
using RoundRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashRegister.xaml
    /// </summary>
    public partial class CashRegister : UserControl
    {
        MainWindow mainWindow;

        /// <summary>
        /// Initializes the CashRegister window and sets its parent as
        /// MainWindow screen.
        /// </summary>
        /// <param name="mainWindow">Parent screen.</param>
        public CashRegister(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        //Click handle for the Return Button.
        void ReturnClickHandle(object sender, EventArgs e)
        {
            this.mainWindow.SwitchScreen("paymentOptions");
        }

        //Click handle for the Finish Button.
        void FinishClickHandle(object sender, EventArgs e)
        {
            if(this.mainWindow.DataContext is Order order)
            {
                if(this.DataContext is CashRegisterControl crc)
                {
                    crc.StoreCash();

                    RecieptPrinter.PrintLine(DateTime.Now.ToString("MM/dd/yyyy HH:mm"));
                    RecieptPrinter.PrintLine(" ");
                    RecieptPrinter.PrintLine("Order #" + order.Number.ToString());
                    RecieptPrinter.PrintLine(" ");
                    foreach (IOrderItem item in order)
                    {
                        RecieptPrinter.PrintLine(item.ToString());
                        foreach (String instruction in item.SpecialInstructions)
                        {
                            RecieptPrinter.PrintLine(instruction);
                        }
                    }
                    RecieptPrinter.PrintLine(" ");
                    RecieptPrinter.PrintLine("Subtotal: $" + order.Subtotal.ToString());
                    RecieptPrinter.PrintLine("Tax: $" + order.Tax.ToString());
                    RecieptPrinter.PrintLine("Total: $" + order.Total.ToString());
                    RecieptPrinter.PrintLine(" ");
                    RecieptPrinter.PrintLine("Payment Method: Cash");
                    RecieptPrinter.PrintLine("Change: " + crc.Change);
                    RecieptPrinter.CutTape();

                    this.mainWindow.SwitchScreen("menuSelect");
                    mainWindow.DataContext = new Order();
                }
            }
        }

    }
}
