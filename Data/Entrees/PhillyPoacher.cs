/*
 * Author: Hannah Chorn
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent the Philly Poacher
 * cheesesteak sandwich with its contents, calories, and price.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher
    {
        /// <summary>
        /// Gets the price of the sandwich.
        /// </summary>
        public double Price
        {
            get
            {
                return 7.23;
            }
        }

        /// <summary>
        /// Gets the calories of the sandwich.
        /// </summary>
        public uint Calories
        {
            get
            {
                return 784;
            }
        }

        /// <summary>
        /// Gets if sirloin will or will not be on the sandwich.
        /// </summary>
        private bool sirloin = true;
        public bool Sirloin
        {
            get
            {
                return sirloin;
            }

            set
            {
                sirloin = value;
            }
        }

        /// <summary>
        /// Gets if onion will or will not be on the sandwich.
        /// </summary>
        private bool onion = true;
        public bool Onion
        {
            get
            {
                return onion;
            }

            set
            {
                onion = value;
            }
        }

        /// <summary>
        /// Gets if the sandwich will or will not be on a roll.
        /// </summary>
        private bool roll = true;
        public bool Roll
        {
            get
            {
                return roll;
            }

            set
            {
                roll = value;
            }
        }

        /// <summary>
        /// Creates a list of special instructions depending on how the
        /// customer orders their sandwich.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add("Hold sirloin");
                if (!Onion) instructions.Add("Hold onions");
                if (!Roll) instructions.Add("Hold roll");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString function to return item name.
        /// </summary>
        /// <returns> "Philly Poacher" </returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
