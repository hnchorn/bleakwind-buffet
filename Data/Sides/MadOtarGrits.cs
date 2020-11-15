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
    /// <summary>
    /// Class representing the Mad Otar Grits side.
    /// </summary>
    public class MadOtarGrits : Side
    {
        /// <summary>
        /// Gets the price of the grits depending on its size. 
        /// <exception cref="NotImplementedException"> Thrown if a size other than small, medium, or large is specified. </exception>  
        /// </summary>
        public override double Price
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
        /// <exception cref="NotImplementedException"> Thrown if a size other than small, medium, or large is specified. </exception> 
        /// </summary>
        public override uint Calories
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
        /// Gets the description of the grits.
        /// </summary>
        public override string Description
        {
            get
            {
                return "Cheesey Grits.";
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
