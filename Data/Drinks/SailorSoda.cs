/*
 * Author: Hannah Chorn
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent the Sailor Soda with its 
 * possible sizes, prices, calories, and other contents.
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class representing the Sailor Soda drink.
    /// </summary>
    public class SailorSoda
    {
        /// <summary>
        /// Gets the size of the soda.
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
        /// Gets the price of the soda depending on its size. 
        /// <exception cref="NotImplementedException"> Thrown if a size other than small, medium, or large is specified. </exception>  
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small) return 1.42;
                if (size == Size.Medium) return 1.74;
                if (size == Size.Large) return 2.07;
                throw new NotImplementedException();
            }
            
        }

        /// <summary>
        /// Gets the calories of the soda depending on its size.
        /// <exception cref="NotImplementedException"> Thrown if a size other than small, medium, or large is specified. </exception>
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small) return 117;
                if (size == Size.Medium) return 153;
                if (size == Size.Large) return 205;
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets if the soda will or will not have ice.
        /// </summary>
        private bool ice = true;
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
        /// Gets the flavor of the soda.
        /// </summary>
        private SodaFlavor flavor = SodaFlavor.Cherry;
        public SodaFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
            }
        }

        /// <summary>
        /// Creates a special instruction list if the customer does
        /// not want ice. Otherwise returns an empty list.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString function to return item name.
        /// </summary>
        /// <returns> "[Size] [Flavor] Sailor Soda" </returns>
        public override string ToString()
        {
            return size + " " + flavor + " Sailor Soda";
        }
    }
}