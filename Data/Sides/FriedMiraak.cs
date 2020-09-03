/*
 * Author: Hannah Chorn
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent the Fried Miraak side
 * with its available sizes, prices, and calories.
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak
    {
        /// <summary>
        /// Gets the size of the pancakes.
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
        /// Gets the price of the pancakes depending on its size. 
        /// Throws an exception if a size other than small, medium, or large is specified.  
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small) return 1.78;
                if (size == Size.Medium) return 2.01;
                if (size == Size.Large) return 2.88;
                throw new NotImplementedException();
            }

        }

        /// <summary>
        /// Gets the calories of the pancakes depending on its size.
        /// Throws an exception if a size other than small, medium, or large is specified.
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small) return 151;
                if (size == Size.Medium) return 236;
                if (size == Size.Large) return 306;
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Creates and returns a new list since there are no 
        /// special instructions.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString function to return item name.
        /// </summary>
        /// <returns> "[Size] Fried Miraak" </returns>
        public override string ToString()
        {
            return size + " Fried Miraak";
        }
    }
}
