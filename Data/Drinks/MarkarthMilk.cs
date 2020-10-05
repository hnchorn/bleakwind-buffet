/*
 * Author: Hannah Chorn
 * Class name: MarkarthMilk.cs
 * Purpose: Class used to represent the Markarth Milk with its 
 * possible sizes, prices, calories, and other contents.
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class representing the Markarth Milk drink.
    /// </summary>
    public class MarkarthMilk : Drink
    {
        /// <summary>
        /// Gets the price of the milk depending on its size. 
        /// <exception cref="NotImplementedException"> Thrown if a size other than small, medium, or large is specified. </exception>  
        /// </summary>
        public override double Price
        {
            get
            {
                if (size == Size.Small) return 1.05;
                if (size == Size.Medium) return 1.11;
                if (size == Size.Large) return 1.22;
                throw new NotImplementedException();
            }

        }

        /// <summary>
        /// Gets the calories of the milk depending on its size.
        /// <exception cref="NotImplementedException"> Thrown if a size other than small, medium, or large is specified. </exception> 
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (size == Size.Small) return 56;
                if (size == Size.Medium) return 72;
                if (size == Size.Large) return 93;
                throw new NotImplementedException();
            }
        }


        private bool ice = false;
        /// <summary>
        /// Gets if the milk will or will not have ice.
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
            }
        }

        /// <summary>
        /// Creates a special instruction list if the customer
        /// wants ice. Otherwise returns an empty list.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString function to return item name.
        /// </summary>
        /// <returns> "[Size] Markarth Milk" </returns>
        public override string ToString()
        {
            return size + " Markarth Milk";
        }
    }
}
