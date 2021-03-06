﻿/*
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
    public class SmokehouseSkeleton : Entree
    {
        /// <summary>
        /// Gets the price of the combo.
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.62;
            }
        }

        /// <summary>
        /// Gets the calories of the combo.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 602;
            }
        }


        private bool sausageLink = true;
        /// <summary>
        /// Gets if the combo will or will not have a sausage link.
        /// </summary>
        public bool SausageLink
        {
            get
            {
                return sausageLink;
            }

            set
            {
                sausageLink = value;
                NotifyPropertyChanged("SausageLink");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }


        private bool egg = true;
        /// <summary>
        /// Gets if the combo will or will not have eggs.
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


        private bool hashBrowns = true;
        /// <summary>
        /// Gets if the combo will or will not have hashbrowns.
        /// </summary>
        public bool HashBrowns
        {
            get
            {
                return hashBrowns;
            }

            set
            {
                hashBrowns = value;
                NotifyPropertyChanged("HashBrowns");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }


        private bool pancake = true;
        /// <summary>
        /// Gets if the combo will or will not have pancakes.
        /// </summary>
        public bool Pancake
        {
            get
            {
                return pancake;
            }

            set
            {
                pancake = value;
                NotifyPropertyChanged("Pancake");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Creates a list of special instructions depending on how the
        /// customer orders their combo.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!SausageLink) instructions.Add(" - Hold sausage");
                if (!Egg) instructions.Add(" - Hold eggs");
                if (!HashBrowns) instructions.Add(" - Hold hash browns");
                if (!Pancake) instructions.Add(" - Hold pancakes");
                return instructions;
            }
        }

        /// <summary>
        /// Gets the description of the combo.
        /// </summary>
        public override string Description
        {
            get
            {
                return "Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.";
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
