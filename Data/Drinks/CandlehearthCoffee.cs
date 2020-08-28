/*
 * Author: Hannah Chorn
 * Class name: CandleheartCoffee.cs
 * Purpose: Class used to represent the Candlehearth Coffee with its 
 * possible sizes, prices, calories, and other contents.
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    class CandlehearthCoffee
    {
        /// <summary>
        /// Gets the size of the coffee.
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
        /// Gets the price of the coffee depending on its size. 
        /// Throws an exception if a size other than small, medium, or large is specified.  
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small) return 0.75;
                if (size == Size.Medium) return 1.25;
                if (size == Size.Large) return 1.75;
                throw new NotImplementedException();
            }

        }

        /// <summary>
        /// Gets the calories of the coffee depending on its size.
        /// Throws an exception if a size other than small, medium, or large is specified.
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small) return 7;
                if (size == Size.Medium) return 10;
                if (size == Size.Large) return 20;
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets if the coffee will or will not have ice.
        /// </summary>
        private bool ice = false;
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
        /// Gets if the coffee will or will not have room for cream.
        /// </summary>
        private bool roomForCream = false;
        public bool RoomForCream
        {
            get
            {
                return roomForCream;
            }

            set
            {
                roomForCream = value;
            }
        }

        /// <summary>
        /// Gets if the coffee will or will not be decaf.
        /// </summary>
        private bool decaf = false;
        public bool Decaf
        {
            get
            {
                return decaf;
            }

            set
            {
                decaf = value;
            }
        }

        /// <summary>
        /// Creates a special instruction list if the customer
        /// wants ice or cream. Otherwise returns an empty list.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add cream");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString function to return item name.
        /// </summary>
        /// <returns> "[Size] Candleheart Coffee" or 
        /// "[Size] Decaf Candleheart Coffee" </returns>
        public override string ToString()
        {
            if (decaf) return size + " Decaf Candleheart Coffee";
            else return size + " Candleheart Coffee";
        }
    }
}
