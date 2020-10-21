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
    /// <summary>
    /// Class representing the Thalmor Triple burger.
    /// </summary>
    public class ThalmorTriple : Entree
    {
        /// <summary>
        /// Gets the price of the burger.
        /// </summary>
        public override double Price
        {
            get
            {
                return 8.32;
            }
        }

        /// <summary>
        /// Gets the calories of the burger.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 943;
            }
        }


        private bool bun = true;
        /// <summary>
        /// Gets if the burger will or will not have a bun.
        /// </summary>
        public bool Bun
        {
            get
            {
                return bun;
            }

            set
            {
                bun = value;
                NotifyPropertyChanged("Bun");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }


        private bool ketchup = true;
        /// <summary>
        /// Gets if ketchup will or will not be on the burger.
        /// </summary>
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }

            set
            {
                ketchup = value;
                NotifyPropertyChanged("Ketchup");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }


        private bool mustard = true;
        /// <summary>
        /// Gets if mustard will or will not be on the burger.
        /// </summary>
        public bool Mustard
        {
            get
            {
                return mustard;
            }

            set
            {
                mustard = value;
                NotifyPropertyChanged("Mustard");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }


        private bool mayo = true;
        /// <summary>
        /// Gets if mayo will or will not be on the burger.
        /// </summary>
        public bool Mayo
        {
            get
            {
                return mayo;
            }

            set
            {
                mayo = value;
                NotifyPropertyChanged("Mayo");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }


        private bool pickle = true;
        /// <summary>
        /// Gets if pickle will or will not be on the burger.
        /// </summary>
        public bool Pickle
        {
            get
            {
                return pickle;
            }

            set
            {
                pickle = value;
                NotifyPropertyChanged("Pickle");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }


        private bool tomato = true;
        /// <summary>
        /// Gets if tomato will or will not be on the burger.
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


        private bool lettuce = true;
        /// <summary>
        /// Gets if lettuce will or will not be on the burger.
        /// </summary>
        public bool Lettuce
        {
            get
            {
                return lettuce;
            }

            set
            {
                lettuce = value;
                NotifyPropertyChanged("Lettuce");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }


        private bool cheese = true;
        /// <summary>
        /// Gets if cheese will or will not be on the burger. 
        /// </summary>
        public bool Cheese
        {
            get
            {
                return cheese;
            }

            set
            {
                cheese = value;
                NotifyPropertyChanged("Cheese");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }


        private bool bacon = true;
        /// <summary>
        /// Gets if bacon will or will not be on the burger. 
        /// </summary>
        public bool Bacon
        {
            get
            {
                return bacon;
            }

            set
            {
                bacon = value;
                NotifyPropertyChanged("Bacon");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }


        private bool egg = true;
        /// <summary>
        /// Gets if egg will or will not be on the burger. 
        /// </summary>
        public bool Egg
        {
            get
            {
                return egg;
            }

            set
            {
                egg = value;
                NotifyPropertyChanged("Egg");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Creates a list of special instructions depending on how the
        /// customer orders their burger.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add(" - Hold bun");
                if (!Ketchup) instructions.Add(" - Hold ketchup");
                if (!Mustard) instructions.Add(" - Hold mustard");
                if (!Mayo) instructions.Add(" - Hold mayo");
                if (!Pickle) instructions.Add(" - Hold pickle");
                if (!Tomato) instructions.Add(" - Hold tomato");
                if (!Lettuce) instructions.Add(" - Hold lettuce");
                if (!Cheese) instructions.Add(" - Hold cheese");
                if (!Bacon) instructions.Add(" - Hold bacon");
                if (!Egg) instructions.Add(" - Hold egg");
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
