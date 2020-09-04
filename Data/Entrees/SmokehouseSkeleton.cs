/*
 * Author: Hannah Chorn
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the Smokehouse Skeleton 
 * brekfast combo with its contents, calories, and price.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class representing the Smokehouse Skeleton breakfast combo.
    /// </summary>
    public class SmokehouseSkeleton
    {
        /// <summary>
        /// Gets the price of the combo.
        /// </summary>
        public double Price
        {
            get
            {
                return 5.62;
            }
        }

        /// <summary>
        /// Gets the calories of the combo.
        /// </summary>
        public uint Calories
        {
            get
            {
                return 602;
            }
        }

        /// <summary>
        /// Gets if the combo will or will not have a sausage link.
        /// </summary>
        private bool sausageLink = true;
        public bool SausageLink
        {
            get
            {
                return sausageLink;
            }

            set
            {
                sausageLink = value;
            }
        }

        /// <summary>
        /// Gets if the combo will or will not have eggs.
        /// </summary>
        private bool egg = true;
        public bool Egg
        {
            get
            {
                return egg;
            }

            set
            {
                egg = value;
            }
        }

        /// <summary>
        /// Gets if the combo will or will not have hashbrowns.
        /// </summary>
        private bool hashBrowns = true;
        public bool HashBrowns
        {
            get
            {
                return hashBrowns;
            }

            set
            {
                hashBrowns = value;
            }
        }

        /// <summary>
        /// Gets if the combo will or will not have pancakes.
        /// </summary>
        private bool pancake = true;
        public bool Pancake
        {
            get
            {
                return pancake;
            }

            set
            {
                pancake = value;
            }
        }

        /// <summary>
        /// Creates a list of special instructions depending on how the
        /// customer orders their combo.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add("Hold sausage");
                if (!Egg) instructions.Add("Hold eggs");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString function to return item name.
        /// </summary>
        /// <returns> "Smokehouse Skeleton" </returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
