/*
 * Author: Hannah Chorn
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent the Briarheart Burger with
 * its contents, calories, and price.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class representing the Briarheart Burger.
    /// </summary>
    public class BriarheartBurger
    {
        /// <summary>
        /// Gets the price of the burger.
        /// </summary>
        public double Price
        {
            get 
            { 
                return 6.32; 
            }
        }

        /// <summary>
        /// Gets the calories of the burger.
        /// </summary>
        public uint Calories
        {
            get
            {
                return 743;
            }
        }

        /// <summary>
        /// Gets if the burger will or will not have a bun.
        /// </summary>
        private bool bun = true;
        public bool Bun
        {
            get
            {
                return bun;
            }

            set
            {
                bun = value;
            }
        }

        /// <summary>
        /// Gets if ketchup will or will not be on the burger.
        /// </summary>
        private bool ketchup = true;
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }

            set
            {
                ketchup = value;
            }
        }

        /// <summary>
        /// Gets if mustard will or will not be on the burger.
        /// </summary>
        private bool mustard = true;
        public bool Mustard
        {
            get
            {
                return mustard;
            }

            set
            {
                mustard = value;
            }
        }

        /// <summary>
        /// Gets if a pickle will or will not be on the burger.
        /// </summary>
        private bool pickle = true;
        public bool Pickle
        {
            get
            {
                return pickle;
            }

            set
            {
                pickle = value;
            }
        }

        /// <summary>
        /// Gets if cheese will or will not be on the burger. 
        /// </summary>
        private bool cheese = true;
        public bool Cheese
        {
            get
            {
                return cheese;
            }

            set
            {
                cheese = value;
            }
        }

        /// <summary>
        /// Creates a list of special instructions depending on how the
        /// customer orders their burger.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString function to return item name.
        /// </summary>
        /// <returns> "Briarheart Burger" </returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
