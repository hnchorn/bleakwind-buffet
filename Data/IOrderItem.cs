﻿/*
 * Author: Hannah Chorn
 * Class name: IOrderItem.cs
 * Purpose: Interface used for ordering an item. 
 * All entrees, sides, and drinks implement this interface.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Class for representing the IOrderItem interface.
    /// </summary>
    public interface IOrderItem: INotifyPropertyChanged
    {

        /// <summary>
        /// Defines the price of an item.
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Defines the calories of an item.
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Defines the special isntructions for an item.
        /// </summary>
        List<string> SpecialInstructions { get; }

        /// <summary>
        /// Defines the description of an item.
        /// </summary>
        string Description { get; }
    }
}
