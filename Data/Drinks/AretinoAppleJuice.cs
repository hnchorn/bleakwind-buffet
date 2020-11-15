/*
 * Author: Hannah Chorn
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent the Aretino Apple Juice with its 
 * possible sizes, prices, calories, and other contents.
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class for representing Aretino Apple Juice.
    /// </summary>
    public class AretinoAppleJuice : Drink
    {
        /// <summary>
        /// Gets the price of the juice depending on its size. 
        /// <exception cref="NotImplementedException"> Thrown if a size other than small, medium, or large is specified. </exception>   
        /// </summary>
        public override double Price
        {
            get
            {
                if (size == Size.Small) return 0.62;
                if (size == Size.Medium) return 0.87;
                if (size == Size.Large) return 1.01;
                throw new NotImplementedException();
            }

        }

        /// <summary>
        /// Gets the calories of the juice depending on its size.
        /// <exception cref="NotImplementedException"> Thrown if a size other than small, medium, or large is specified. </exception> 
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (size == Size.Small) return 44;
                if (size == Size.Medium) return 88;
                if (size == Size.Large) return 132;
                throw new NotImplementedException();
            }
        }


        private bool ice = false;
        /// <summary>
        /// Gets if the juice will or will not have ice.
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

        /// <summary>
        /// Creates a special instruction list if the customer
        /// wants ice. Otherwise returns an empty list.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add(" - Add ice");
                return instructions;
            }
        }

        /// </summary>
        /// Gets the description of the juice.
        /// </summary>
        public override string Description
        {
            get
            {
                return "Fresh squeezed apple juice.";
            }
        }

        /// <summary>
        /// Overrides the ToString function to return item name.
        /// </summary>
        /// <returns> "[Size] Aretino Apple Juice" </returns>
        public override string ToString()
        {
            return size + " Aretino Apple Juice";
        }
    }
}
