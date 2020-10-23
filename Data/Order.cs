/*
 * Author: Hannah Chorn
 * Class name: Order.cs
 * Purpose: Class used to represent a customer's order.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace BleakwindBuffet.Data
{
    public class Order: ObservableCollection<IOrderItem>, INotifyCollectionChanged, INotifyPropertyChanged
    {

        /// <summary>
        /// Constructor for the Order class.
        /// Attaches the CollectionChanged event listeners.
        /// </summary>
        public Order()
        {
            CollectionChanged += CollectionChangedListener;
            Number = nextOrderNumber++;
        }

        private static int nextOrderNumber = 1;
        /// <summary>
        /// Represents the order number.
        /// </summary>
        public int Number
        {
            get; private set;
        }
       
        /// <summary>
        /// Represents the subtotal price of the order.
        /// </summary>
        public double Subtotal
        {
            get
            {
                double subtotal = 0;
                foreach (IOrderItem item in this)
                {
                    subtotal += item.Price;
                }
                return Math.Round(subtotal, 2);
            }
        }

        /// <summary>
        /// Represents the sales tax rate for the order.
        /// </summary>
        public double SalesTaxRate { get; set; } = 0.12;

        /// <summary>
        /// Represents the specific order tax.
        /// </summary>
        public double Tax
        {
            get
            {
                return Math.Round(Subtotal * SalesTaxRate, 2);
            }

        }

        /// <summary>
        /// Represents the specific order total price.
        /// </summary>
        public double Total
        {
            get
            {
                return Math.Round(Subtotal + Tax, 2);
            }
        }

        /// <summary>
        /// Represents the combined calories of the order.
        /// </summary>
        public uint Calories
        {
            get
            {
                uint calories = 0;
                foreach(IOrderItem item in this)
                {
                    calories += item.Calories;
                }
                return calories;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(new PropertyChangedEventArgs("Price"));
            OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
            OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
            OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (IOrderItem item in e.NewItems)
                    {
                        item.PropertyChanged += CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (IOrderItem item in e.OldItems)
                    {
                        item.PropertyChanged -= CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    throw new NotImplementedException("NotifyCollectionChangedAction.Reset not supported.");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CollectionItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Decaf" || e.PropertyName == "Flavor")
            {
                int ind = this.IndexOf((IOrderItem)sender);
                this.RemoveAt(ind);
                this.InsertItem(ind, (IOrderItem)sender);
                
            }
            if (e.PropertyName == "Size")
            {
                int ind = this.IndexOf((IOrderItem)sender);
                this.RemoveAt(ind);
                this.InsertItem(ind, (IOrderItem)sender);
            }
            if (e.PropertyName == "Price")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            }
            if(e.PropertyName == "Calories")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            }
        }
    }
}
