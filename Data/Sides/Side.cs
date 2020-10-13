/*
 * Author: Hannah Chorn
 * Class name: Side.cs
 * Purpose: Base class to represent all sides.
 * All sides inherit from this class.
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A base class representing the common properties of sides.
    /// </summary>
    public abstract class Side : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The size of the side.
        /// </summary>
        protected Size size = Size.Small;
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                NotifyPropertyChanged("Size");
                NotifyPropertyChanged("Price");
                NotifyPropertyChanged("Calories");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// The price of the side.
        /// </summary>
        /// <value>
        /// In US dollars.
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the side.
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Creates and returns a new list since there are no 
        /// special instructions for sides.
        /// </summary>
        public virtual List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
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
    }
}
