/*
 * Author: Hannah Chorn
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent the Garden Orc
 * omelette with its contents, calories, and price.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    class GardenOrcOmelette
    {
        /// <summary>
        /// Gets the price of the omelette.
        /// </summary>
        public double Price
        {
            get
            {
                return 4.57;
            }
        }

        /// <summary>
        /// Gets the calories of the omelette.
        /// </summary>
        public uint Calories
        {
            get
            {
                return 404;
            }
        }

        /// <summary>
        /// Gets if broccoli will or will not be on the omelette.
        /// </summary>
        private bool broccoli = true;
        public bool Broccoli
        {
            get
            {
                return broccoli;
            }

            set
            {
                broccoli = value;
            }
        }

        /// <summary>
        /// Gets if mushrooms will or will not be on the omelette.
        /// </summary>
        private bool mushrooms = true;
        public bool Mushrooms
        {
            get
            {
                return mushrooms;
            }

            set
            {
                mushrooms = value;
            }
        }

        /// <summary>
        /// Gets if tomato will or will not be on the omelette.
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
        /// Gets if cheddar will or will not be on the omelette.
        /// </summary>
        private bool cheddar = true;
        public bool Cheddar
        {
            get
            {
                return cheddar;
            }

            set
            {
                cheddar = value;
            }
        }

        /// <summary>
        /// Creates a list of special instructions depending on how the
        /// customer orders their omelette.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Cheddar) instructions.Add("Hold cheddar");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides the ToString function to return item name.
        /// </summary>
        /// <returns> "Garden Orc Omelette" </returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
