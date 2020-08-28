/*
 * Author: Hannah Chorn
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent the Dragonborn Waffle Fries
 * side with its available sizes, prices, and calories.
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    class DragonbornWaffleFries
    {
        /// <summary>
        /// Gets the size of the fries.
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
        /// Gets the price of the fries depending on its size. 
        /// Throws an exception if a size other than small, medium, or large is specified.  
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small) return 0.42;
                if (size == Size.Medium) return 0.76;
                if (size == Size.Large) return 0.96;
                throw new NotImplementedException();
            }

        }

        /// <summary>
        /// Gets the calories of the fries depending on its size.
        /// Throws an exception if a size other than small, medium, or large is specified.
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small) return 77;
                if (size == Size.Medium) return 89;
                if (size == Size.Large) return 100;
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
        /// <returns> "[Size] Dragonborn Waffle Fries" </returns>
        public override string ToString()
        {
            return size + " Dragonborn Waffle Fries";
        }
    }
}
