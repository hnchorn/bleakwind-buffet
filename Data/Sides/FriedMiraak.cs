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
    /// <summary>
    /// Class to represent the Fried Miraak side.
    /// </summary>
    public class FriedMiraak : Side
    {
        /// <summary>
        /// Gets the price of the pancakes depending on its size. 
        /// <exception cref="NotImplementedException"> Thrown if a size other than small, medium, or large is specified. </exception>  
        /// </summary>
        public override double Price
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
        /// <exception cref="NotImplementedException"> Thrown if a size other than small, medium, or large is specified. </exception> 
        /// </summary>
        public override uint Calories
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
        /// Gets the description of the pancakes.
        /// </summary>
        public override string Description
        {
            get
            {
                return "Perfectly prepared hash brown pancakes.";
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
