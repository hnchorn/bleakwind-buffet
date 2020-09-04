/*
 * Author: Hannah Chorn
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent the Thugs T-Bone
 * with its calories and price.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class to represent Thugs T-Bone.
    /// </summary>
    public class ThugsTBone
    {
        /// <summary>
        /// Gets the price of the t-bone.
        /// </summary>
        public double Price
        {
            get
            {
                return 6.44;
            }
        }

        /// <summary>
        /// Gets the calories of the t-bone.
        /// </summary>
        public uint Calories
        {
            get
            {
                return 982;
            }
        }

        /// <summary>
        /// Creates an empty list of special instructions since
        /// this class has no boolean properties.
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
        /// <returns> "Thugs T-Bone" </returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
