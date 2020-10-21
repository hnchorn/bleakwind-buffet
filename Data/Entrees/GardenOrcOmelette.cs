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
    /// <summary>
    /// Class to represent the Garden Orc omelette.
    /// </summary>
    public class GardenOrcOmelette : Entree
    {
        /// <summary>
        /// Gets the price of the omelette.
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.57;
            }
        }

        /// <summary>
        /// Gets the calories of the omelette.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 404;
            }
        }

        private bool broccoli = true;
        /// <summary>
        /// Gets if broccoli will or will not be on the omelette.
        /// </summary>
        public bool Broccoli
        {
            get
            {
                return broccoli;
            }

            set
            {
                broccoli = value;
                NotifyPropertyChanged("Broccoli");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        private bool mushrooms = true;
        /// <summary>
        /// Gets if mushrooms will or will not be on the omelette.
        /// </summary>
        public bool Mushrooms
        {
            get
            {
                return mushrooms;
            }

            set
            {
                mushrooms = value;
                NotifyPropertyChanged("Mushrooms");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        private bool tomato = true;
        /// <summary>
        /// Gets if tomato will or will not be on the omelette.
        /// </summary>
        public bool Tomato
        {
            get
            {
                return tomato;
            }

            set
            {
                tomato = value;
                NotifyPropertyChanged("Tomato");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        private bool cheddar = true;
        /// <summary>
        /// Gets if cheddar will or will not be on the omelette.
        /// </summary>
        public bool Cheddar
        {
            get
            {
                return cheddar;
            }

            set
            {
                cheddar = value;
                NotifyPropertyChanged("Cheddar");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Creates a list of special instructions depending on how the
        /// customer orders their omelette.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add(" - Hold broccoli");
                if (!Mushrooms) instructions.Add(" - Hold mushrooms");
                if (!Tomato) instructions.Add(" - Hold tomato");
                if (!Cheddar) instructions.Add(" - Hold cheddar");
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
