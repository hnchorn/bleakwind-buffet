/*
 * Author: Hannah Chorn
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent the Mad Otar Grits side
 * with its available sizes, prices, and calories.
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    class MadOtarGrits
    {
        /// <summary>
        /// Gets the size of the grits.
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
        /// Gets the price of the grits depending on its size. 
        /// Throws an exception if a size other than small, medium, or large is specified.  
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small) return 1.22;
                if (size == Size.Medium) return 1.58;
                if (size == Size.Large) return 1.93;
                throw new NotImplementedException();
            }

        }

        /// <summary>
        /// Gets the calories of the grits depending on its size.
        /// Throws an exception if a size other than small, medium, or large is specified.
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small) return 105;
                if (size == Size.Medium) return 142;
                if (size == Size.Large) return 179;
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
        /// <returns> "[Size] Mad Otar Grits" </returns>
        public override string ToString()
        {
            return size + " Mad Otar Grits";
        }
    }
}
