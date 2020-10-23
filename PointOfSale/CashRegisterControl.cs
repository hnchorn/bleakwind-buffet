/*
 * Author: Hannah Chorn
 * Class name: CashRegisterControl.cs
 * Purpose: Class used to represent the View-Model of the Cash Register.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml.Schema;
using RoundRegister;

namespace PointOfSale
{
    public class CashRegisterControl: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Constructor for the CashRegisterControl that takes in the 
        /// order total to handle the payment process.
        /// </summary>
        /// <param name="total">Total of the order.</param>
        public CashRegisterControl(double total)
        {
            this.Total = total;
        }

        /// <summary>
        /// Notifies a property if the button representing it changes.
        /// </summary>
        /// <param name="propertyName">Name of the property changing.</param>
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /// <summary>
        /// Local variable of the order total.
        /// </summary>
        public double Total { get; }

        /// <summary>
        /// Represents the amount of money the customer still owes.
        /// </summary>
        public double AmountDue
        {
            get
            {
                if(Total - CustomerPayment > 0)
                {
                    return Math.Round(Total - CustomerPayment, 2);
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// Represents the amount of money the customer has paid.
        /// </summary>
        public double CustomerPayment
        {
            get
            {
                return ((CustomerHundredsQuantity * 100) + (CustomerFiftiesQuantity * 50) + (CustomerTwentiesQuantity * 20) + (CustomerTensQuantity * 10) +
                    (CustomerFivesQuantity * 5) + (CustomerTwosQuantity*2) + (CustomerOnesQuantity) + (CustomerHalfDollarsQuantity * 0.5) + 
                    (CustomerQuartersQuantity * 0.25) + (CustomerDimesQuantity * 0.1) + (CustomerNickelsQuantity * 0.05) + (CustomerPenniesQuantity * 0.01));
            }
        }

        /// <summary>
        /// Represents how much change should be returned to the customer.
        /// </summary>
        public double Change
        {
            get
            {
                if(CustomerPayment - Total > 0)
                {
                    return Math.Round(CustomerPayment - Total, 2);
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// Represents how many $100 bills are in the cash register.
        /// </summary>
        public int DrawerHundredsQuantity
        {
            get { return CashDrawer.Hundreds; }
            set 
            { 
                CashDrawer.Hundreds = value;
                NotifyPropertyChanged("DrawerHundredsQuantity");
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
            }
        }

        /// <summary>
        /// Represents how many $50 bills are in the cash register.
        /// </summary>
        public int DrawerFiftiesQuantity
        {
            get { return CashDrawer.Fifties; }
            set
            {
                CashDrawer.Fifties = value;
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
            }
        }

        /// <summary>
        /// Represents how many $20 bills are in the cash register.
        /// </summary>
        public int DrawerTwentiesQuantity
        {
            get { return CashDrawer.Twenties; }
            set
            {
                CashDrawer.Twenties = value;
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
            }
        }

        /// <summary>
        /// Represents how many $10 bills are in the cash register.
        /// </summary>
        public int DrawerTensQuantity
        {
            get { return CashDrawer.Tens; }
            set
            {
                CashDrawer.Tens = value;
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
            }
        }

        /// <summary>
        /// Represents how many $5 bills are in the cash register.
        /// </summary>
        public int DrawerFivesQuantity
        {
            get { return CashDrawer.Fives; }
            set
            {
                CashDrawer.Fives = value;
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
            }
        }

        /// <summary>
        /// Represents how many $2 bills are in the cash register.
        /// </summary>
        public int DrawerTwosQuantity
        {
            get { return CashDrawer.Twos; }
            set
            {
                CashDrawer.Twos = value;
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
            }
        }

        /// <summary>
        /// Represents how many $1 bills are in the cash register.
        /// </summary>
        public int DrawerOnesQuantity
        {
            get { return CashDrawer.Ones; }
            set
            {
                CashDrawer.Ones = value;
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
            }
        }

        /// <summary>
        /// Represents how many half dollars are in the cash register.
        /// </summary>
        public int DrawerHalfDollarsQuantity
        {
            get { return CashDrawer.HalfDollars; }
            set
            {
                CashDrawer.HalfDollars = value;
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
            }
        }

        /// <summary>
        /// Represents how many quarters are in the cash register.
        /// </summary>
        public int DrawerQuartersQuantity
        {
            get { return CashDrawer.Quarters; }
            set
            {
                CashDrawer.Quarters = value;
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
            }
        }

        /// <summary>
        /// Represents how many dimes are in the cash register.
        /// </summary>
        public int DrawerDimesQuantity
        {
            get { return CashDrawer.Dimes; }
            set
            {
                CashDrawer.Dimes = value;
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
            }
        }

        /// <summary>
        /// Represents how many nickels are in the cash register.
        /// </summary>
        public int DrawerNickelsQuantity
        {
            get { return CashDrawer.Nickels; }
            set
            {
                CashDrawer.Nickels = value;
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
            }
        }

        /// <summary>
        /// Represents how many pennies are in the cash register.
        /// </summary>
        public int DrawerPenniesQuantity
        {
            get { return CashDrawer.Pennies; }
            set
            {
                CashDrawer.Pennies = value;
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
            }
        }

        /// <summary>
        /// Represents how many $100 bills the customer is paying with.
        /// </summary>
        private int customerHundredsQuantity;
        public int CustomerHundredsQuantity
        {
            get
            {
                return customerHundredsQuantity;
            }
            set
            {
                customerHundredsQuantity = value;
                NotifyPropertyChanged("DrawerHundredsQuantity");
                NotifyPropertyChanged("CustomerHundredsQuantity");
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
                CashExchange();
            }
        }

        /// <summary>
        /// Represents how many $50 bills the customer is paying with.
        /// </summary>
        private int customerFiftiesQuantity;
        public int CustomerFiftiesQuantity
        {
            get
            {
                return customerFiftiesQuantity;
            }
            set
            {
                customerFiftiesQuantity = value;
                NotifyPropertyChanged("CustomerFiftiesQuantity");
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
                CashExchange();
            }
        }

        /// <summary>
        /// Represents how many $20 bills the customer is paying with.
        /// </summary>
        private int customerTwentiesQuantity;
        public int CustomerTwentiesQuantity
        {
            get
            {
                return customerTwentiesQuantity;
            }
            set
            {
                customerTwentiesQuantity = value;
                NotifyPropertyChanged("CustomerTwentiesQuantity");
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
                CashExchange();
            }
        }

        /// <summary>
        /// Represents how many $10 bills the customer is paying with.
        /// </summary>
        private int customerTensQuantity;
        public int CustomerTensQuantity
        {
            get
            {
                return customerTensQuantity;
            }
            set
            {
                customerTensQuantity = value;
                NotifyPropertyChanged("CustomerTensQuantity");
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
                CashExchange();
            }
        }

        /// <summary>
        /// Represents how many $5 bills the customer is paying with.
        /// </summary>
        private int customerFivesQuantity;
        public int CustomerFivesQuantity
        {
            get
            {
                return customerFivesQuantity;
            }
            set
            {
                customerFivesQuantity = value;
                NotifyPropertyChanged("CustomerFivesQuantity");
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
                CashExchange();
            }
        }

        /// <summary>
        /// Represents how many $2 bills the customer is paying with.
        /// </summary>
        private int customerTwosQuantity;
        public int CustomerTwosQuantity
        {
            get
            {
                return customerTwosQuantity;
            }
            set
            {
                customerTwosQuantity = value;
                NotifyPropertyChanged("CustomerTwosQuantity");
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
                CashExchange();
            }
        }

        /// <summary>
        /// Represents how many $1 bills the customer is paying with.
        /// </summary>
        private int customerOnesQuantity;
        public int CustomerOnesQuantity
        {
            get
            {
                return customerOnesQuantity;
            }
            set
            {
                customerOnesQuantity = value;
                NotifyPropertyChanged("CustomerOnesQuantity");
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
                CashExchange();
            }
        }

        /// <summary>
        /// Represents how many half dollars the customer is paying with.
        /// </summary>
        private int customerHalfDollarsQuantity;
        public int CustomerHalfDollarsQuantity
        {
            get
            {
                return customerHalfDollarsQuantity;
            }
            set
            {
                customerHalfDollarsQuantity = value;
                NotifyPropertyChanged("CustomerHalfDollarsQuantity");
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
                CashExchange();
            }
        }

        /// <summary>
        /// Represents how many quarters the customer is paying with.
        /// </summary>
        private int customerQuartersQuantity;
        public int CustomerQuartersQuantity
        {
            get
            {
                return customerQuartersQuantity;
            }
            set
            {
                customerQuartersQuantity = value;
                NotifyPropertyChanged("CustomerQuartersQuantity");
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
                CashExchange();
            }
        }

        /// <summary>
        /// Represents how many dimes the customer is paying with.
        /// </summary>
        private int customerDimesQuantity;
        public int CustomerDimesQuantity
        {
            get
            {
                return customerDimesQuantity;
            }
            set
            {
                customerDimesQuantity = value;
                NotifyPropertyChanged("CustomerDimesQuantity");
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
                CashExchange();
            }
        }

        /// <summary>
        /// Represents how many nickels the customer is paying with.
        /// </summary>
        private int customerNickelsQuantity;
        public int CustomerNickelsQuantity
        {
            get
            {
                return customerNickelsQuantity;
            }
            set
            {
                customerNickelsQuantity = value;
                NotifyPropertyChanged("CustomerNickelsQuantity");
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
                CashExchange();
            }
        }

        /// <summary>
        /// Represents how many pennies the customer is paying with.
        /// </summary>
        private int customerPenniesQuantity;
        public int CustomerPenniesQuantity
        {
            get
            {
                return customerPenniesQuantity;
            }
            set
            {
                customerPenniesQuantity = value;
                NotifyPropertyChanged("CustomerPenniesQuantity");
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
                CashExchange();
            }
        }


        /// <summary>
        /// Represents how many $100 bills are returned as change.
        /// </summary>
        private int changeHundredsQuantity;
        public int ChangeHundredsQuantity
        {
            get
            {
                return changeHundredsQuantity;
            }
            set
            {
                changeHundredsQuantity = value;
                NotifyPropertyChanged("ChangeHundredsQuantity");
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
            }
        }

        /// <summary>
        /// Represents how many $50 bills are returned as change.
        /// </summary>
        private int changeFiftiesQuantity;
        public int ChangeFiftiesQuantity
        {
            get
            {
                return changeFiftiesQuantity;
            }
            set
            {
                changeFiftiesQuantity = value;
                NotifyPropertyChanged("ChangeFiftiesQuantity");
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
            }
        }


        /// <summary>
        /// Represents how many $20 bills are returned as change.
        /// </summary>
        private int changeTwentiesQuantity;
        public int ChangeTwentiesQuantity
        {
            get
            {
                return changeTwentiesQuantity;
            }
            set
            {
                changeTwentiesQuantity = value;
                NotifyPropertyChanged("ChangeTwentiesQuantity");
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
            }
        }

        /// <summary>
        /// Represents how many $10 bills are returned as change.
        /// </summary>
        private int changeTensQuantity;
        public int ChangeTensQuantity
        {
            get
            {
                return changeTensQuantity;
            }
            set
            {
                changeTensQuantity = value;
                NotifyPropertyChanged("ChangeTensQuantity");
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
            }
        }

        /// <summary>
        /// Represents how many $5 bills are returned as change.
        /// </summary>
        private int changeFivesQuantity;
        public int ChangeFivesQuantity
        {
            get
            {
                return changeFivesQuantity;
            }
            set
            {
                changeFivesQuantity = value;
                NotifyPropertyChanged("ChangeFivesQuantity");
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
            }
        }

        /// <summary>
        /// Represents how many $2 bills are returned as change.
        /// </summary>
        private int changeTwosQuantity;
        public int ChangeTwosQuantity
        {
            get
            {
                return changeTwosQuantity;
            }
            set
            {
                changeTwosQuantity = value;
                NotifyPropertyChanged("ChangeTwosQuantity");
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
            }
        }

        /// <summary>
        /// Represents how many $1 bills are returned as change.
        /// </summary>
        private int changeOnesQuantity;
        public int ChangeOnesQuantity
        {
            get
            {
                return changeOnesQuantity;
            }
            set
            {
                changeOnesQuantity = value;
                NotifyPropertyChanged("ChangeOnesQuantity");
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
            }
        }

        /// <summary>
        /// Represents how many half dollars are returned as change.
        /// </summary>
        private int changeHalfDollarsQuantity;
        public int ChangeHalfDollarsQuantity
        {
            get
            {
                return changeHalfDollarsQuantity;
            }
            set
            {
                changeHalfDollarsQuantity = value;
                NotifyPropertyChanged("ChangeHalfDollarsQuantity");
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
            }
        }

        /// <summary>
        /// Represents how many quarters are returned as change.
        /// </summary>
        private int changeQuartersQuantity;
        public int ChangeQuartersQuantity
        {
            get
            {
                return changeQuartersQuantity;
            }
            set
            {
                changeQuartersQuantity = value;
                NotifyPropertyChanged("ChangeQuartersQuantity");
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
            }
        }

        /// <summary>
        /// Represents how many dimes are returned as change.
        /// </summary>
        private int changeDimesQuantity;
        public int ChangeDimesQuantity
        {
            get
            {
                return changeDimesQuantity;
            }
            set
            {
                changeDimesQuantity = value;
                NotifyPropertyChanged("ChangeDimesQuantity");
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
            }
        }

        /// <summary>
        /// Represents how many nickels are returned as change.
        /// </summary>
        private int changeNickelsQuantity;
        public int ChangeNickelsQuantity
        {
            get
            {
                return changeNickelsQuantity;
            }
            set
            {
                changeNickelsQuantity = value;
                NotifyPropertyChanged("ChangeNickelsQuantity");
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
            }
        }

        /// <summary>
        /// Represents how many pennies are returned as change.
        /// </summary>
        private int changePenniesQuantity;
        public int ChangePenniesQuantity
        {
            get
            {
                return changePenniesQuantity;
            }
            set
            {
                changePenniesQuantity = value;
                NotifyPropertyChanged("ChangePenniesQuantity");
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
            }
        }

        /// <summary>
        /// Method for handling the cash exchange logic.
        /// Updates all properties after cash exchange is complete.
        /// </summary>
        public void CashExchange()
        {
            int dollarsDue = (int)Change;
            int coinsDue = (int)(Math.Round((Change % 1.0), 2) * 100);

            if(DrawerHundredsQuantity != 0)
            {
                ChangeHundredsQuantity = dollarsDue / 100;
                dollarsDue = dollarsDue % 100;
                DrawerHundredsQuantity -= ChangeHundredsQuantity;
            }
            if (DrawerFiftiesQuantity != 0)
            {
                ChangeFiftiesQuantity = dollarsDue / 50;
                dollarsDue = dollarsDue % 50;
                DrawerFiftiesQuantity -= ChangeFiftiesQuantity;
            }
            if(DrawerTwentiesQuantity != 0)
            {
                ChangeTwentiesQuantity = dollarsDue / 20;
                dollarsDue = dollarsDue % 20;
                DrawerTwentiesQuantity -= ChangeTwentiesQuantity;
            }
            if(DrawerTensQuantity != 0)
            {
                ChangeTensQuantity = dollarsDue / 10;
                dollarsDue = dollarsDue % 10;
                DrawerTensQuantity -= ChangeTensQuantity;
            }
            if(DrawerFivesQuantity != 0)
            {
                ChangeFivesQuantity = dollarsDue / 5;
                dollarsDue = dollarsDue % 5;
                DrawerFivesQuantity -= ChangeFivesQuantity;
            }
            if(DrawerTwosQuantity != 0)
            {
                ChangeTwosQuantity = dollarsDue / 2;
                dollarsDue = dollarsDue % 2;
                DrawerTwosQuantity -= ChangeTwosQuantity;
            }
            if(DrawerOnesQuantity != 0)
            {
                ChangeOnesQuantity = dollarsDue;
                DrawerOnesQuantity -= ChangeOnesQuantity;
            }
            
            if(DrawerHalfDollarsQuantity != 0)
            {
                ChangeHalfDollarsQuantity = coinsDue / 50;
                coinsDue = coinsDue % 50;
            }
            if(DrawerQuartersQuantity != 0)
            {
                ChangeQuartersQuantity = coinsDue / 25;
                coinsDue = coinsDue % 25;
            }
            if(DrawerDimesQuantity != 0)
            {
                ChangeDimesQuantity = coinsDue / 10;
                coinsDue = coinsDue % 10;
            }
            if(DrawerNickelsQuantity != 0)
            {
                ChangeNickelsQuantity = coinsDue / 5;
                coinsDue = coinsDue % 5;
            }
            if(DrawerPenniesQuantity != 0)
            {
                ChangePenniesQuantity = coinsDue;
            } 
        }

        public void StoreCash()
        {
            CashDrawer.OpenDrawer();
            DrawerHundredsQuantity += CustomerHundredsQuantity;
            DrawerFiftiesQuantity += CustomerFiftiesQuantity;
            DrawerTwentiesQuantity += CustomerTwentiesQuantity;
            DrawerTensQuantity += CustomerTensQuantity;
            DrawerFivesQuantity += CustomerFivesQuantity;
            DrawerTwosQuantity += CustomerTwosQuantity;
            DrawerOnesQuantity += CustomerOnesQuantity;
            DrawerHalfDollarsQuantity += CustomerHalfDollarsQuantity;
            DrawerQuartersQuantity += CustomerQuartersQuantity;
            DrawerDimesQuantity += CustomerDimesQuantity;
            DrawerNickelsQuantity += CustomerNickelsQuantity;
            DrawerPenniesQuantity += CustomerPenniesQuantity;
        }
    }
}
