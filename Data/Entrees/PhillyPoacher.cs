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
    /// <summary>
    /// Class representing the Philly Poacher cheesesteak sandwich.
    /// </summary>
    public class PhillyPoacher : Entree
    {
        /// <summary>
        /// Gets the price of the sandwich.
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.23;
            }
        }

        /// <summary>
        /// Gets the calories of the sandwich.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 784;
            }
        }

        private bool sirloin = true;
        /// <summary>
        /// Gets if sirloin will or will not be on the sandwich.
        /// </summary>
        public bool Sirloin
        {
            get
            {
                return sirloin;
            }

            set
            {
                sirloin = value;
                NotifyPropertyChanged("Sirloin");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        private bool onion = true;
        /// <summary>
        /// Gets if onion will or will not be on the sandwich.
        /// </summary>
        public bool Onion
        {
            get
            {
                return onion;
            }

            set
            {
                onion = value;
                NotifyPropertyChanged("Onion");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }
        
        private bool roll = true;
        /// <summary>
        /// Gets if the sandwich will or will not be on a roll.
        /// </summary>
        public bool Roll
        {
            get
            {
                return roll;
            }

            set
            {
                roll = value;
                NotifyPropertyChanged("Roll");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Creates a list of special instructions depending on how the
        /// customer orders their sandwich.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Sirloin) instructions.Add(" - Hold sirloin");
                if (!Onion) instructions.Add(" - Hold onions");
                if (!Roll) instructions.Add(" - Hold roll");
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
