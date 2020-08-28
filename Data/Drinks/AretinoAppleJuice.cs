/*
 * Author: Hannah Chorn
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent the Aretino Apple Juice with its 
 * possible sizes, prices, calories, and other contents.
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    class AretinoAppleJuice
    {
        /// <summary>
        /// Gets the size of the juice.
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
        /// Gets the price of the juice depending on its size. 
        /// Throws an exception if a size other than small, medium, or large is specified.  
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small) return 0.62;
                if (size == Size.Medium) return 0.87;
                if (size == Size.Large) return 1.01;
                throw new NotImplementedException();
            }

        }

        /// <summary>
        /// Gets the calories of the juice depending on its size.
        /// Throws an exception if a size other than small, medium, or large is specified.
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small) return 44;
                if (size == Size.Medium) return 88;
                if (size == Size.Large) return 132;
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets if the juice will or will not have ice.
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
        /// <returns> "[Size] Aretino Apple Juice" </returns>
        public override string ToString()
        {
            return size + " Aretino Apple Juice";
        }
    }
}
