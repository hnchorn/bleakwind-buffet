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
    public class MarkarthMilk
    {
        /// <summary>
        /// Gets the size of the milk.
        /// </summary>
        private Size size = Size.Small;
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        /// <summary>
        /// Gets the price of the milk depending on its size. 
        /// Throws an exception if a size other than small, medium, or large is specified.  
        /// </summary>
        public double Price
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
        /// Throws an exception if a size other than small, medium, or large is specified.
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small) return 56;
                if (size == Size.Medium) return 72;
                if (size == Size.Large) return 93;
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets if the milk will or will not have ice.
        /// </summary>
        private bool ice = false;
        public bool Ice
        {
            get
            {
                return ice;
            }

            set
            {
                ice = value;
            }
        }

        /// <summary>
        /// Creates a special instruction list if the customer
        /// wants ice. Otherwise returns an empty list.
        /// </summary>
        public List<string> SpecialInstructions
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
