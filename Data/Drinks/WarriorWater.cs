/*
 * Author: Hannah Chorn
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent the Warrior Water with its 
 * possible sizes, prices, calories, and other contents.
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class representing the Warrior Water drink.
    /// </summary>
    public class WarriorWater : Drink
    {
        /// <summary>
        /// Gets the price of the water ($0.00 for all sizes).  
        /// </summary>
        public override double Price
        {
            get
            {
                return 0.00;
            }

        }

        /// <summary>
        /// Gets the calories of the water (0 for all sizes).
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 0;
            }
        }

        private bool ice = true;
        /// <summary>
        /// Gets if the water will or will not have ice.
        /// </summary>
        public bool Ice
        {
            get
            {
                return ice;
            }

            set
            {
                ice = value;
                NotifyPropertyChanged("Ice");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        private bool lemon = false;
        /// <summary>
        /// Gets if the water will or will not have lemon.
        /// </summary>
        public bool Lemon
        {
            get
            {
                return lemon;
            }

            set
            {
                lemon = value;
                NotifyPropertyChanged("Lemon");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Creates a special instruction list if the customer
        /// wants lemon or doesn't want ice. Otherwise returns an empty list.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add(" - Hold ice");
                if (Lemon) instructions.Add(" - Add lemon");
                return instructions;
            }
        }

        /// </summary>
        /// Gets the description of the water.
        /// </summary>
        public override string Description
        {
            get
            {
                return "It’s water. Just water.";
            }
        }

        /// <summary>
        /// Overrides the ToString function to return item name.
        /// </summary>
        /// <returns> "[Size] Warrior Water" </returns>
        public override string ToString()
        {
            return size + " Warrior Water";
        }
    }
}
