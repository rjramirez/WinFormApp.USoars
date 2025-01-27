﻿// <auto-generated>
// This file contains the ISortStrategy interface of SortingApp.
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </auto-generated>

namespace SortingApp.Models
{
    /// <summary>
    /// Defines the interface for sorting strategies.
    /// </summary>
    public interface ISortStrategy
    {
        /// <summary>
        /// Sorts the input string.
        /// </summary>
        /// <param name="input">The string to sort.</param>
        /// <returns>The sorted string.</returns>
        string Sort(string input);
    }
}
