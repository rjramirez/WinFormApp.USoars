// <auto-generated>
// This file is part of SortingApp.
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </auto-generated>

#nullable enable

using SortingApp.Models;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace SortingApp;

/// <summary>
/// The main form for the SortingApp.
/// </summary>
public partial class MainForm : Form
{
    private SortContext? sortContext;
    private List<string> sortHistory = new();

    /// <summary>
    /// Initializes a new instance of the <see cref="MainForm"/> class.
    /// </summary>
    public MainForm()
    {
        InitializeComponent();
        InitializeCustomComponents();
    }

    private void InitializeCustomComponents()
    {
        // Set up ComboBox with sorting strategies
        this.comboBoxSortingStrategy.Items.Add("BubbleSort");
        this.comboBoxSortingStrategy.Items.Add("QuickSort");
        this.comboBoxSortingStrategy.Items.Add("MergeSort");
        this.comboBoxSortingStrategy.SelectedIndex = 0; // Default selection

        this.buttonSort.Click += ButtonSort_Click;
    }

    private void ButtonSort_Click(object sender, EventArgs e)
    {
        string input = this.textBoxInput.Text;

        if (string.IsNullOrWhiteSpace(input))
        {
            MessageBox.Show("Please enter a string to sort.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        string selectedStrategy = this.comboBoxSortingStrategy.SelectedItem?.ToString() ?? string.Empty;

        this.sortContext = selectedStrategy switch
        {
            "BubbleSort" => new SortContext(new BubbleSort()),
            "QuickSort" => new SortContext(new QuickSort()),
            "MergeSort" => new SortContext(new MergeSort()),
            _ => null
        };

        if (this.sortContext == null)
        {
            MessageBox.Show("Invalid sorting strategy selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var stopwatch = Stopwatch.StartNew();
        string sortedString = this.sortContext.Sort(input);
        stopwatch.Stop();

        this.labelOutput.Text = sortedString;
        this.labelTimeElapsed.Text = $"Time Elapsed: {stopwatch.ElapsedTicks} ticks";

        // Add history entry
        string historyEntry = $"Input: {input}";
        this.listBoxHistory.Items.Add(historyEntry);

        historyEntry = $"Sorted: {sortedString}";
        this.listBoxHistory.Items.Add(historyEntry);

        historyEntry = $"Strategy: {selectedStrategy}";
        this.listBoxHistory.Items.Add(historyEntry);

        historyEntry = $"Time: {stopwatch.ElapsedTicks} ticks";
        this.listBoxHistory.Items.Add(historyEntry);
    }
}