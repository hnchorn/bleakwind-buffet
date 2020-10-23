/*
 * Author: Hannah Chorn
 * Class name: PaymentOptions.xaml.cs
 * Purpose: Class used to represent the payment selection screen on the 
 * GUI interface.
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using RoundRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for PaymentOptions.xaml
    /// </summary>
    public partial class PaymentOptions : UserControl
    {
        MainWindow mainWindow;

        /// <summary>
        /// Initializes the PaymentOptions screen and sets its parent
        /// as the MainWindow screen.
        /// </summary>
        /// <param name="mainWindow">Parent screen.</param>
        public PaymentOptions(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        //Click handle for when the Cash payment option is clicked.
        void CashClickHandle(object sender, EventArgs e)
        {
            var screen = this.mainWindow.SwitchScreen("cashRegister");
            if(mainWindow.DataContext is Order order)
            {
                CashRegisterControl crc = new CashRegisterControl(order.Total);
                screen.DataContext = crc;
            }
        }

        //Click handle for when the Card paymention option is clicked.
        void DebitCreditClickHandle(object sender, EventArgs e)
        {
            if (mainWindow.DataContext is Order order)
            {
                CardTransactionResult transactionResult = CardReader.RunCard(order.Total);
                if (transactionResult == CardTransactionResult.Approved)
                {
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
                    RecieptPrinter.PrintLine("Payment Method: Card");
                    RecieptPrinter.CutTape();

                    var result = MessageBox.Show("Card Approved!", "Card Approved");
                    if (result == MessageBoxResult.OK)
                    {
                        this.mainWindow.SwitchScreen("menuSelect");
                    }

                    mainWindow.DataContext = new Order();
                }
                if (transactionResult == CardTransactionResult.Declined)
                {
                    MessageBox.Show("Card Declined. Please try again.", "Card Error");
                }
                if (transactionResult == CardTransactionResult.ReadError)
                {
                    MessageBox.Show("Unable to read card. Please try again.", "Card Error");
                }
                if (transactionResult == CardTransactionResult.InsufficientFunds)
                {
                    MessageBox.Show("Insufficient funds. Please try another card.", "Card Error");
                }
                if (transactionResult == CardTransactionResult.IncorrectPin)
                {
                    MessageBox.Show("Incorrect pin. Please try again.", "Card Error");
                }
            }
        }

        //Click handle for when the Return button is clicked
        void ReturnClickHandle(object sender, EventArgs e)
        {
            this.mainWindow.SwitchScreen("menuSelect");
        }
    }
}
