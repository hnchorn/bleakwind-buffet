using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml.Schema;
using RoundRegister;

namespace BleakwindBuffet.Data
{
    public class CashRegisterControl: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public CashRegisterControl(double total)
        {
            CashDrawer.OpenDrawer();
            this.Total = total;
            CashExchange(total);
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

        public double Total { get; }

        public double AmountDue
        {
            get
            {
                if(Total - CustomerPayment > 0)
                {
                    return Total - CustomerPayment;
                }
                else
                {
                    return 0;
                }
            }
        }

        public double CustomerPayment
        {
            get
            {
                return ((CustomerHundredsQuantity * 100) + (CustomerFiftiesQuantity * 50) + (CustomerTwentiesQuantity * 20) + (CustomerTensQuantity * 10) +
                    (CustomerFivesQuantity * 5) + (CustomerTwosQuantity*2) + (CustomerOnesQuantity) + (CustomerHalfDollarsQuantity * 0.5) + 
                    (CustomerQuartersQuantity * 0.25) + (CustomerDimesQuantity * 0.1) + (CustomerNickelsQuantity * 0.05) + (CustomerPenniesQuantity * 0.01));
            }
        }

        public double Change
        {
            get
            {
                if(CustomerPayment - Total > 0)
                {
                    return CustomerPayment - Total;
                }
                else
                {
                    return 0;
                }
            }
        }

        int DrawerHundredsQuantity
        {
            get { return CashDrawer.Hundreds; }
            set 
            { 
                CashDrawer.Hundreds = value;
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
            }
        }

        int DrawerFiftiesQuantity
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

        int DrawerTwentiesQuantity
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

        int DrawerTensQuantity
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

        int DrawerFivesQuantity
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

        int DrawerTwosQuantity
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
        int DrawerOnesQuantity
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
        int DrawerHalfDollarsQuantity
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

        int DrawerQuartersQuantity
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

        int DrawerDimesQuantity
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

        int DrawerNickelsQuantity
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

        int DrawerPenniesQuantity
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

        private int customerHundredsQuantity;
        int CustomerHundredsQuantity
        {
            get
            {
                return customerHundredsQuantity;
            }
            set
            {
                customerHundredsQuantity = value;
                NotifyPropertyChanged("CustomerHundredsQuantity");
                NotifyPropertyChanged("CustomerPayment");
                NotifyPropertyChanged("AmountDue");
                NotifyPropertyChanged("Change");
            }
        }
        int CustomerFiftiesQuantity { get; set; }
        int CustomerTwentiesQuantity { get; set; }
        int CustomerTensQuantity { get; set; }
        int CustomerFivesQuantity { get; set; }
        int CustomerTwosQuantity { get; set; }
        int CustomerOnesQuantity { get; set; }
        int CustomerHalfDollarsQuantity { get; set; }
        int CustomerQuartersQuantity { get; set; }
        int CustomerDimesQuantity { get; set; }
        int CustomerNickelsQuantity { get; set; }
        int CustomerPenniesQuantity { get; set; }

        int ChangeHundredsQuantity { get; set; }
        int ChangeFiftiesQuantity { get; set; }
        int ChangeTwentiesQuantity { get; set; }
        int ChangeTensQuantity { get; set; }
        int ChangeFivesQuantity { get; set; }
        int ChangeTwosQuantity { get; set; }
        int ChangeOnesQuantity { get; set; }
        int ChangeHalfDollarsQuantity { get; set; }
        int ChangeQuartersQuantity { get; set; }
        int ChangeDimesQuantity { get; set; }
        int ChangeNickelsQuantity { get; set; }
        int ChangePenniesQuantity { get; set; }

        void CashExchange(double total)
        {
            
        }

    }
}
