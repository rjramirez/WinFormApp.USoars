﻿// <auto-generated>
// This file is part of SortingApp.
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </auto-generated>

using SortingApp.Models;


/// <summary>
/// Represents the context for applying a sorting strategy.
/// </summary>
public class SortContext
{
    private readonly ISortStrategy sortStrategy;

    /// <summary>
    /// Initializes a new instance of the <see cref="SortContext"/> class.
    /// </summary>
    /// <param name="sortStrategy">The sorting strategy to use.</param>
    public SortContext(ISortStrategy sortStrategy)
    {
        this.sortStrategy = sortStrategy;
    }

    /// <summary>
    /// Sorts the input string using the specified strategy.
    /// </summary>
    /// <param name="input">The input string to sort.</param>
    /// <returns>The sorted string.</returns>
    public string Sort(string input)
    {
        return this.sortStrategy.Sort(input);
    }
}