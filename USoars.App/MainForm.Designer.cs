namespace SortingApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxInput = new TextBox();
            comboBoxSortingStrategy = new ComboBox();
            buttonSort = new Button();
            labelOutput = new Label();
            labelTimeElapsed = new Label();
            listBoxHistory = new ListBox();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxInput.Location = new Point(353, 56);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(390, 45);
            textBoxInput.TabIndex = 0;
            // 
            // comboBoxSortingStrategy
            // 
            comboBoxSortingStrategy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxSortingStrategy.FormattingEnabled = true;
            comboBoxSortingStrategy.Location = new Point(353, 128);
            comboBoxSortingStrategy.Name = "comboBoxSortingStrategy";
            comboBoxSortingStrategy.Size = new Size(265, 40);
            comboBoxSortingStrategy.TabIndex = 1;
            // 
            // buttonSort
            // 
            buttonSort.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSort.Location = new Point(631, 118);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(112, 50);
            buttonSort.TabIndex = 2;
            buttonSort.Text = "Sort";
            buttonSort.UseVisualStyleBackColor = true;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOutput.Location = new Point(353, 244);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(171, 54);
            labelOutput.TabIndex = 4;
            labelOutput.Text = "OUTPUT";
            // 
            // labelTimeElapsed
            // 
            labelTimeElapsed.AutoSize = true;
            labelTimeElapsed.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTimeElapsed.Location = new Point(353, 191);
            labelTimeElapsed.Name = "labelTimeElapsed";
            labelTimeElapsed.Size = new Size(116, 25);
            labelTimeElapsed.TabIndex = 5;
            labelTimeElapsed.Text = "Time Elapsed";
            labelTimeElapsed.TextAlign = ContentAlignment.TopCenter;
            // 
            // listBoxHistory
            // 
            listBoxHistory.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxHistory.FormattingEnabled = true;
            listBoxHistory.ItemHeight = 21;
            listBoxHistory.Location = new Point(27, 39);
            listBoxHistory.MaximumSize = new Size(296, 379);
            listBoxHistory.Name = "listBoxHistory";
            listBoxHistory.Size = new Size(296, 361);
            listBoxHistory.TabIndex = 6;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxHistory);
            Controls.Add(labelTimeElapsed);
            Controls.Add(labelOutput);
            Controls.Add(buttonSort);
            Controls.Add(comboBoxSortingStrategy);
            Controls.Add(textBoxInput);
            Name = "MainForm";
            Text = "Text Sorting App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInput;
        private ComboBox comboBoxSortingStrategy;
        private Button buttonSort;
        private Label labelOutput;
        private Label labelTimeElapsed;
        private ListBox listBoxHistory;
    }
}
