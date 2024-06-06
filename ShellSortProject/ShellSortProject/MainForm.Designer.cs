namespace ShellSortProject
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.sortingAlgorithmLabel = new System.Windows.Forms.Label();
            this.algorithmOptionsComboBox = new System.Windows.Forms.ComboBox();
            this.generateArrayButton = new System.Windows.Forms.Button();
            this.sortArrayButton = new System.Windows.Forms.Button();
            this.arraySizeLabel = new System.Windows.Forms.Label();
            this.maxArrayValueLabel = new System.Windows.Forms.Label();
            this.arraySizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxArrayValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.generatedArrayTextBox = new System.Windows.Forms.TextBox();
            this.comparisonsLabel = new System.Windows.Forms.Label();
            this.comparisonsTextBox = new System.Windows.Forms.TextBox();
            this.sortedArrayTextBox = new System.Windows.Forms.TextBox();
            this.generatedArrayLabel = new System.Windows.Forms.Label();
            this.sortedArrayLabel = new System.Windows.Forms.Label();
            this.minArrayValueLabel = new System.Windows.Forms.Label();
            this.generationOrderLabel = new System.Windows.Forms.Label();
            this.generationOrderComboBox = new System.Windows.Forms.ComboBox();
            this.minArrayValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.descendingOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.showSortVisualizationCheckBox = new System.Windows.Forms.CheckBox();
            this.sortVisualizationPanel = new System.Windows.Forms.Panel();
            this.saveSortToFileButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.permutationsLabel = new System.Windows.Forms.Label();
            this.permutationsTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arraySizeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxArrayValueNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minArrayValueNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(639, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenu});
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenu.Text = "File";
            // 
            // exitToolStripMenu
            // 
            this.exitToolStripMenu.Name = "exitToolStripMenu";
            this.exitToolStripMenu.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenu.Text = "Exit";
            this.exitToolStripMenu.Click += new System.EventHandler(this.ToolStripMenuExit_Click);
            // 
            // sortingAlgorithmLabel
            // 
            this.sortingAlgorithmLabel.AutoSize = true;
            this.sortingAlgorithmLabel.Location = new System.Drawing.Point(320, 34);
            this.sortingAlgorithmLabel.Name = "sortingAlgorithmLabel";
            this.sortingAlgorithmLabel.Size = new System.Drawing.Size(88, 13);
            this.sortingAlgorithmLabel.TabIndex = 1;
            this.sortingAlgorithmLabel.Text = "Sorting algorithm:";
            // 
            // algorithmOptionsComboBox
            // 
            this.algorithmOptionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algorithmOptionsComboBox.FormattingEnabled = true;
            this.algorithmOptionsComboBox.Location = new System.Drawing.Point(414, 31);
            this.algorithmOptionsComboBox.Name = "algorithmOptionsComboBox";
            this.algorithmOptionsComboBox.Size = new System.Drawing.Size(209, 21);
            this.algorithmOptionsComboBox.TabIndex = 2;
            // 
            // generateArrayButton
            // 
            this.generateArrayButton.Location = new System.Drawing.Point(14, 137);
            this.generateArrayButton.Name = "generateArrayButton";
            this.generateArrayButton.Size = new System.Drawing.Size(168, 23);
            this.generateArrayButton.TabIndex = 3;
            this.generateArrayButton.Text = "Generate array";
            this.generateArrayButton.UseVisualStyleBackColor = true;
            this.generateArrayButton.Click += new System.EventHandler(this.GenerateArrayButton_Click);
            // 
            // sortArrayButton
            // 
            this.sortArrayButton.Location = new System.Drawing.Point(323, 137);
            this.sortArrayButton.Name = "sortArrayButton";
            this.sortArrayButton.Size = new System.Drawing.Size(157, 23);
            this.sortArrayButton.TabIndex = 5;
            this.sortArrayButton.Text = "Sort";
            this.sortArrayButton.UseVisualStyleBackColor = true;
            this.sortArrayButton.Click += new System.EventHandler(this.SortArrayButton_Click);
            // 
            // arraySizeLabel
            // 
            this.arraySizeLabel.AutoSize = true;
            this.arraySizeLabel.Location = new System.Drawing.Point(11, 34);
            this.arraySizeLabel.Name = "arraySizeLabel";
            this.arraySizeLabel.Size = new System.Drawing.Size(55, 13);
            this.arraySizeLabel.TabIndex = 6;
            this.arraySizeLabel.Text = "Array size:";
            // 
            // maxArrayValueLabel
            // 
            this.maxArrayValueLabel.AutoSize = true;
            this.maxArrayValueLabel.Location = new System.Drawing.Point(11, 60);
            this.maxArrayValueLabel.Name = "maxArrayValueLabel";
            this.maxArrayValueLabel.Size = new System.Drawing.Size(85, 13);
            this.maxArrayValueLabel.TabIndex = 7;
            this.maxArrayValueLabel.Text = "Max array value:";
            // 
            // arraySizeNumericUpDown
            // 
            this.arraySizeNumericUpDown.Location = new System.Drawing.Point(102, 32);
            this.arraySizeNumericUpDown.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.arraySizeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.arraySizeNumericUpDown.Name = "arraySizeNumericUpDown";
            this.arraySizeNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.arraySizeNumericUpDown.TabIndex = 8;
            this.arraySizeNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // maxArrayValueNumericUpDown
            // 
            this.maxArrayValueNumericUpDown.Location = new System.Drawing.Point(102, 58);
            this.maxArrayValueNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.maxArrayValueNumericUpDown.Name = "maxArrayValueNumericUpDown";
            this.maxArrayValueNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.maxArrayValueNumericUpDown.TabIndex = 9;
            this.maxArrayValueNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // generatedArrayTextBox
            // 
            this.generatedArrayTextBox.Location = new System.Drawing.Point(17, 196);
            this.generatedArrayTextBox.MaxLength = 2500;
            this.generatedArrayTextBox.Multiline = true;
            this.generatedArrayTextBox.Name = "generatedArrayTextBox";
            this.generatedArrayTextBox.ReadOnly = true;
            this.generatedArrayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.generatedArrayTextBox.Size = new System.Drawing.Size(300, 200);
            this.generatedArrayTextBox.TabIndex = 10;
            // 
            // comparisonsLabel
            // 
            this.comparisonsLabel.AutoSize = true;
            this.comparisonsLabel.Location = new System.Drawing.Point(483, 163);
            this.comparisonsLabel.Name = "comparisonsLabel";
            this.comparisonsLabel.Size = new System.Drawing.Size(70, 13);
            this.comparisonsLabel.TabIndex = 11;
            this.comparisonsLabel.Text = "Comparisons:";
            // 
            // comparisonsTextBox
            // 
            this.comparisonsTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.comparisonsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.comparisonsTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comparisonsTextBox.Location = new System.Drawing.Point(556, 163);
            this.comparisonsTextBox.Name = "comparisonsTextBox";
            this.comparisonsTextBox.ReadOnly = true;
            this.comparisonsTextBox.Size = new System.Drawing.Size(64, 13);
            this.comparisonsTextBox.TabIndex = 12;
            this.comparisonsTextBox.Text = "0";
            // 
            // sortedArrayTextBox
            // 
            this.sortedArrayTextBox.Location = new System.Drawing.Point(323, 196);
            this.sortedArrayTextBox.MaxLength = 2500;
            this.sortedArrayTextBox.Multiline = true;
            this.sortedArrayTextBox.Name = "sortedArrayTextBox";
            this.sortedArrayTextBox.ReadOnly = true;
            this.sortedArrayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sortedArrayTextBox.Size = new System.Drawing.Size(300, 200);
            this.sortedArrayTextBox.TabIndex = 15;
            // 
            // generatedArrayLabel
            // 
            this.generatedArrayLabel.AutoSize = true;
            this.generatedArrayLabel.Location = new System.Drawing.Point(14, 180);
            this.generatedArrayLabel.Name = "generatedArrayLabel";
            this.generatedArrayLabel.Size = new System.Drawing.Size(86, 13);
            this.generatedArrayLabel.TabIndex = 16;
            this.generatedArrayLabel.Text = "Generated array:";
            // 
            // sortedArrayLabel
            // 
            this.sortedArrayLabel.AutoSize = true;
            this.sortedArrayLabel.Location = new System.Drawing.Point(320, 180);
            this.sortedArrayLabel.Name = "sortedArrayLabel";
            this.sortedArrayLabel.Size = new System.Drawing.Size(67, 13);
            this.sortedArrayLabel.TabIndex = 17;
            this.sortedArrayLabel.Text = "Sorted array:";
            // 
            // minArrayValueLabel
            // 
            this.minArrayValueLabel.AutoSize = true;
            this.minArrayValueLabel.Location = new System.Drawing.Point(11, 86);
            this.minArrayValueLabel.Name = "minArrayValueLabel";
            this.minArrayValueLabel.Size = new System.Drawing.Size(82, 13);
            this.minArrayValueLabel.TabIndex = 18;
            this.minArrayValueLabel.Text = "Min array value:";
            // 
            // generationOrderLabel
            // 
            this.generationOrderLabel.AutoSize = true;
            this.generationOrderLabel.Location = new System.Drawing.Point(11, 114);
            this.generationOrderLabel.Name = "generationOrderLabel";
            this.generationOrderLabel.Size = new System.Drawing.Size(89, 13);
            this.generationOrderLabel.TabIndex = 19;
            this.generationOrderLabel.Text = "Generation order:";
            // 
            // generationOrderComboBox
            // 
            this.generationOrderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generationOrderComboBox.FormattingEnabled = true;
            this.generationOrderComboBox.Location = new System.Drawing.Point(102, 110);
            this.generationOrderComboBox.Name = "generationOrderComboBox";
            this.generationOrderComboBox.Size = new System.Drawing.Size(80, 21);
            this.generationOrderComboBox.TabIndex = 20;
            // 
            // minArrayValueNumericUpDown
            // 
            this.minArrayValueNumericUpDown.Location = new System.Drawing.Point(102, 84);
            this.minArrayValueNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.minArrayValueNumericUpDown.Name = "minArrayValueNumericUpDown";
            this.minArrayValueNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.minArrayValueNumericUpDown.TabIndex = 21;
            // 
            // descendingOrderCheckBox
            // 
            this.descendingOrderCheckBox.AutoSize = true;
            this.descendingOrderCheckBox.Location = new System.Drawing.Point(323, 73);
            this.descendingOrderCheckBox.Name = "descendingOrderCheckBox";
            this.descendingOrderCheckBox.Size = new System.Drawing.Size(110, 17);
            this.descendingOrderCheckBox.TabIndex = 22;
            this.descendingOrderCheckBox.Text = "Descending order";
            this.descendingOrderCheckBox.UseVisualStyleBackColor = true;
            // 
            // showSortVisualizationCheckBox
            // 
            this.showSortVisualizationCheckBox.AutoSize = true;
            this.showSortVisualizationCheckBox.Location = new System.Drawing.Point(323, 96);
            this.showSortVisualizationCheckBox.Name = "showSortVisualizationCheckBox";
            this.showSortVisualizationCheckBox.Size = new System.Drawing.Size(296, 17);
            this.showSortVisualizationCheckBox.TabIndex = 23;
            this.showSortVisualizationCheckBox.Text = "Show sort visualization (for arrays less than 300 elements)";
            this.showSortVisualizationCheckBox.UseVisualStyleBackColor = true;
            // 
            // sortVisualizationPanel
            // 
            this.sortVisualizationPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sortVisualizationPanel.Location = new System.Drawing.Point(323, 196);
            this.sortVisualizationPanel.Name = "sortVisualizationPanel";
            this.sortVisualizationPanel.Size = new System.Drawing.Size(300, 200);
            this.sortVisualizationPanel.TabIndex = 24;
            // 
            // saveSortToFileButton
            // 
            this.saveSortToFileButton.Location = new System.Drawing.Point(486, 137);
            this.saveSortToFileButton.Name = "saveSortToFileButton";
            this.saveSortToFileButton.Size = new System.Drawing.Size(137, 23);
            this.saveSortToFileButton.TabIndex = 25;
            this.saveSortToFileButton.Text = "Save result";
            this.saveSortToFileButton.UseVisualStyleBackColor = true;
            this.saveSortToFileButton.Click += new System.EventHandler(this.SaveSortToFileButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // permutationsLabel
            // 
            this.permutationsLabel.AutoSize = true;
            this.permutationsLabel.Location = new System.Drawing.Point(483, 180);
            this.permutationsLabel.Name = "permutationsLabel";
            this.permutationsLabel.Size = new System.Drawing.Size(71, 13);
            this.permutationsLabel.TabIndex = 26;
            this.permutationsLabel.Text = "Permutations:";
            // 
            // permutationsTextBox
            // 
            this.permutationsTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.permutationsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.permutationsTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.permutationsTextBox.Location = new System.Drawing.Point(556, 180);
            this.permutationsTextBox.Name = "permutationsTextBox";
            this.permutationsTextBox.ReadOnly = true;
            this.permutationsTextBox.Size = new System.Drawing.Size(64, 13);
            this.permutationsTextBox.TabIndex = 27;
            this.permutationsTextBox.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 411);
            this.Controls.Add(this.permutationsTextBox);
            this.Controls.Add(this.permutationsLabel);
            this.Controls.Add(this.saveSortToFileButton);
            this.Controls.Add(this.sortedArrayTextBox);
            this.Controls.Add(this.showSortVisualizationCheckBox);
            this.Controls.Add(this.descendingOrderCheckBox);
            this.Controls.Add(this.minArrayValueNumericUpDown);
            this.Controls.Add(this.generationOrderComboBox);
            this.Controls.Add(this.generationOrderLabel);
            this.Controls.Add(this.minArrayValueLabel);
            this.Controls.Add(this.sortedArrayLabel);
            this.Controls.Add(this.generatedArrayLabel);
            this.Controls.Add(this.comparisonsTextBox);
            this.Controls.Add(this.comparisonsLabel);
            this.Controls.Add(this.generatedArrayTextBox);
            this.Controls.Add(this.maxArrayValueNumericUpDown);
            this.Controls.Add(this.arraySizeNumericUpDown);
            this.Controls.Add(this.maxArrayValueLabel);
            this.Controls.Add(this.arraySizeLabel);
            this.Controls.Add(this.sortArrayButton);
            this.Controls.Add(this.generateArrayButton);
            this.Controls.Add(this.algorithmOptionsComboBox);
            this.Controls.Add(this.sortingAlgorithmLabel);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.sortVisualizationPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(655, 450);
            this.Name = "MainForm";
            this.Text = "Shell Sort";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arraySizeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxArrayValueNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minArrayValueNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenu;
        private System.Windows.Forms.Label sortingAlgorithmLabel;
        private System.Windows.Forms.ComboBox algorithmOptionsComboBox;
        private System.Windows.Forms.Button generateArrayButton;
        private System.Windows.Forms.Button sortArrayButton;
        private System.Windows.Forms.Label arraySizeLabel;
        private System.Windows.Forms.Label maxArrayValueLabel;
        private System.Windows.Forms.Label minArrayValueLabel;
        private System.Windows.Forms.NumericUpDown arraySizeNumericUpDown;
        private System.Windows.Forms.NumericUpDown maxArrayValueNumericUpDown;
        private System.Windows.Forms.TextBox generatedArrayTextBox;
        private System.Windows.Forms.Label comparisonsLabel;
        private System.Windows.Forms.TextBox comparisonsTextBox;
        private System.Windows.Forms.TextBox sortedArrayTextBox;
        private System.Windows.Forms.Label generatedArrayLabel;
        private System.Windows.Forms.Label sortedArrayLabel;
        private System.Windows.Forms.Label generationOrderLabel;
        private System.Windows.Forms.ComboBox generationOrderComboBox;
        private System.Windows.Forms.NumericUpDown minArrayValueNumericUpDown;
        private System.Windows.Forms.CheckBox descendingOrderCheckBox;
        private System.Windows.Forms.CheckBox showSortVisualizationCheckBox;
        private System.Windows.Forms.Panel sortVisualizationPanel;
        private System.Windows.Forms.Button saveSortToFileButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox permutationsTextBox;
        private System.Windows.Forms.Label permutationsLabel;
    }
}

