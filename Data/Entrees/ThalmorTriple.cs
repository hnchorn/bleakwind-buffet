/*
 * Author: Hannah Chorn
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent the Thalmor Triple burger 
 * with its contents, calories, and price.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class ThalmorTriple
    {
        /// <summary>
        /// Gets the price of the burger.
        /// </summary>
        public double Price
        {
            get
            {
                return 8.32;
            }
        }

        /// <summary>
        /// Gets the calories of the burger.
        /// </summary>
        public uint Calories
        {
            get
            {
                return 943;
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
        /// Gets if mayo will or will not be on the burger.
        /// </summary>
        private bool mayo = true;
        public bool Mayo
        {
            get
            {
                return mayo;
            }

            set
            {
                mayo = value;
            }
        }

        /// <summary>
        /// Gets if pickle will or will not be on the burger.
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
        /// Gets if tomato will or will not be on the burger.
        /// </summary>
        private bool tomato = true;
        public bool Tomato
        {
            get
            {
                return tomato;
            }

            set
            {
                tomato = value;
            }
        }

        /// <summary>
        /// Gets if lettuce will or will not be on the burger.
        /// </summary>
        private bool lettuce = true;
        public bool Lettuce
        {
            get
            {
                return lettuce;
            }

            set
            {
                lettuce = value;
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
        /// Gets if bacon will or will not be on the burger. 
        /// </summary>
        private bool bacon = true;
        public bool Bacon
        {
            get
            {
                return bacon;
            }

            set
            {
                bacon = value;
            }
        }

        /// <summary>
        /// Gets if egg will or will not be on the burger. 
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
                if (!Mayo) instructions.Add("Hold mayo");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString function to return item name.
        /// </summary>
        /// <returns> "Thalmor Triple" </returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
