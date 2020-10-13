/*
 * Author: Hannah Chorn
 * Class name: CandleheartCoffee.cs
 * Purpose: Class used to represent the Candlehearth Coffee with its 
 * possible sizes, prices, calories, and other contents.
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class representing the Candlehearth Coffee drink.
    /// </summary>
    public class CandlehearthCoffee : Drink
    {
        /// <summary>
        /// Gets the price of the coffee depending on its size. 
        /// <exception cref="NotImplementedException"> Thrown if a size other than small, medium, or large is specified. </exception> 
        /// </summary>
        public override double Price
        {
            get
            {
                if (size == Size.Small) return 0.75;
                if (size == Size.Medium) return 1.25;
                if (size == Size.Large) return 1.75;
                throw new NotImplementedException();
            }

        }

        /// <summary>
        /// Gets the calories of the coffee depending on its size.
        /// <exception cref="NotImplementedException"> Thrown if a size other than small, medium, or large is specified. </exception> 
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (size == Size.Small) return 7;
                if (size == Size.Medium) return 10;
                if (size == Size.Large) return 20;
                throw new NotImplementedException();
            }
        }


        private bool ice = false;
        /// <summary>
        /// Gets if the coffee will or will not have ice.
        /// </summary>
        public bool Ice
        {
            get
            {
                return ice;
            }

            set
            {
                ice = value;
                NotifyPropertyChanged("Ice");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }


        private bool roomForCream = false;
        /// <summary>
        /// Gets if the coffee will or will not have room for cream.
        /// </summary>
        public bool RoomForCream
        {
            get
            {
                return roomForCream;
            }

            set
            {
                roomForCream = value;
                NotifyPropertyChanged("RoomForCream");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }


        private bool decaf = false;
        /// <summary>
        /// Gets if the coffee will or will not be decaf.
        /// </summary>
        public bool Decaf
        {
            get
            {
                return decaf;
            }

            set
            {
                decaf = value;
                NotifyPropertyChanged("Decaf");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Creates a special instruction list if the customer
        /// wants ice or cream. Otherwise returns an empty list.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add cream");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString function to return item name.
        /// </summary>
        /// <returns> "[Size] Candleheart Coffee" or 
        /// "[Size] Decaf Candleheart Coffee" </returns>
        public override string ToString()
        {
            if (decaf) return size + " Decaf Candlehearth Coffee";
            else return size + " Candlehearth Coffee";
        }
    }
}
