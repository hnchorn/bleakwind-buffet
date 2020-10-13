/*
 * Author: Hannah Chorn
 * Class name: Combo.cs
 * Purpose: Class used to represent a Combonation order
 * consisting of one Entree, Side, and Drink.
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace BleakwindBuffet.Data
{
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Constructor for the Combo class. 
        /// </summary>
        /// <param name="e">Entree to be used in the combo.</param>
        /// <param name="s">Side to be used in the combo.</param>
        /// <param name="d">Drink to be used in the combo.</param>
        public Combo(Entree e, Side s, Drink d)
        {
            Entree = e;
            Side = s;
            Drink = d;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Notifies a property if it has been changed.
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
        /// Represents the entree portion of the combo.
        /// Attaches/disattaches the appropriate property changed listener, 
        /// and notifies the respective properties.
        /// </summary>
        private Entree entree;
        public Entree Entree
        {
            get
            {
                return entree;
            }
            set
            {
                if(entree != null)
                {
                    entree.PropertyChanged -= PropertyChangedListener;
                }
                entree = value;
                entree.PropertyChanged += PropertyChangedListener;
                NotifyPropertyChanged("Entree");
                NotifyPropertyChanged("Price");
                NotifyPropertyChanged("Calories");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Represents the side portion of the combo.
        /// Attaches/disattaches the appropriate property changed listener, 
        /// and notifies the respective properties.
        /// </summary>
        private Side side;
        public Side Side
        {
            get
            {
                return side;
            }
            set
            {
                if (side != null)
                {
                    side.PropertyChanged -= PropertyChangedListener;
                }
                side = value;
                side.PropertyChanged += PropertyChangedListener;
                NotifyPropertyChanged("Side");
                NotifyPropertyChanged("Price");
                NotifyPropertyChanged("Calories");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Represents the drink portion of the combo.
        /// Attaches/disattaches the appropriate property changed listener, 
        /// and notifies the respective properties.
        /// </summary>
        private Drink drink;
        public Drink Drink
        {
            get
            {
                return drink;
            }
            set
            {
                if (drink != null)
                {
                    drink.PropertyChanged -= PropertyChangedListener;
                }
                drink = value;
                drink.PropertyChanged += PropertyChangedListener;
                NotifyPropertyChanged("Drink");
                NotifyPropertyChanged("Price");
                NotifyPropertyChanged("Calories");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Represents the total price of the combo with a $1 discount applied.
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 1;
            }
        }

        /// <summary>
        /// Represents the total calories of the combo.
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        /// <summary>
        /// Represents the total special instructions for the combo.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                instructions.Add(Entree.ToString());
                instructions.AddRange(Entree.SpecialInstructions);
                instructions.Add(Side.ToString());
                instructions.AddRange(Side.SpecialInstructions);
                instructions.Add(Drink.ToString());
                instructions.AddRange(Drink.SpecialInstructions);
                return instructions;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void PropertyChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price")
            {
                this.NotifyPropertyChanged("Price");

            }
            if (e.PropertyName == "Calories")
            {
                this.NotifyPropertyChanged("Price");

            }
            if (e.PropertyName == "SpecialInstructions")
            {
                this.NotifyPropertyChanged("SpecialInstructions");
            }
        }
    }
}
