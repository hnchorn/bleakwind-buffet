/*
 * Author: Hannah Chorn
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent the Vokun Salad side
 * with its available sizes, prices, and calories.
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class representing the Vokun Salad side.
    /// </summary>
    public class VokunSalad
    {
        /// <summary>
        /// Gets the size of the salad.
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
        /// Gets the price of the salad depending on its size. 
        /// <exception cref="NotImplementedException"> Thrown if a size other than small, medium, or large is specified. </exception>   
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small) return 0.93;
                if (size == Size.Medium) return 1.28;
                if (size == Size.Large) return 1.82;
                throw new NotImplementedException();
            }

        }

        /// <summary>
        /// Gets the calories of the salad depending on its size.
        /// <exception cref="NotImplementedException"> Thrown if a size other than small, medium, or large is specified. </exception> 
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small) return 41;
                if (size == Size.Medium) return 52;
                if (size == Size.Large) return 73;
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
        /// <returns> "[Size] Vokun Salad" </returns>
        public override string ToString()
        {
            return size + " Vokun Salad";
        }
    }
}
