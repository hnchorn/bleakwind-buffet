/*
 * Author: Hannah Chorn
 * Class name: IOrderItem.cs
 * Purpose: Interface used for ordering an item. 
 * All entrees, sides, and drinks implement this interface.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Class for representing the IOrderItem interface.
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// Defines the price of an item.
        /// </summary>
        /// <returns></returns>
        double Price { get; }

        /// <summary>
        /// Defines the calories of an item.
        /// </summary>
        /// <returns></returns>
        uint Calories { get; }

        /// <summary>
        /// Defines the special isntructions for an item.
        /// </summary>
        /// <returns></returns>
        List<string> SpecialInstructions { get; }
    }
}
