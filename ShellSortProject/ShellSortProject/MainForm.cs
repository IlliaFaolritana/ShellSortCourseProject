using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace ShellSortProject
{
    public partial class MainForm : Form
    {
        int[] generatedArray;
        int[] sortedArray;
        public MainForm()
        {
            InitializeComponent();
            InitializeComboBoxes();
        }

        private void GenerateArrayButton_Click(object sender, EventArgs e)
        {
            ClearValues();
            if (minArrayValueNumericUpDown.Value > maxArrayValueNumericUpDown.Value)
                minArrayValueNumericUpDown.Value = maxArrayValueNumericUpDown.Value;

            ArrayGenerator arrayGenerator = new ArrayGenerator((int)arraySizeNumericUpDown.Value,
                                                               (int)maxArrayValueNumericUpDown.Value,
                                                               (int)minArrayValueNumericUpDown.Value);
            generatedArray = arrayGenerator.GetGeneratedArray(generationOrderComboBox.SelectedIndex);

            PrintArrayToTextBox(generatedArray, generatedArrayTextBox);
        }

        private void SortArrayButton_Click(object sender, EventArgs e)
        {
            if (generatedArray == null)
                GenerateArrayButton_Click(null, null);
            if(showSortVisualizationCheckBox.Checked && generatedArray.Length > 300)
            {
                MessageBox.Show("The array size for visualization exceeds 300.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ISortEngine sortEngine;
            sortedArray = new int[generatedArray.Length];
            Array.Copy(generatedArray, sortedArray, generatedArray.Length);

            if (showSortVisualizationCheckBox.Checked)
                sortEngine = InitializeSortVisualizationEngine();
            else
                sortEngine = InitializeSortEngine();
            
            sortEngine.DoSort();
            PrintArrayToTextBox(sortedArray, sortedArrayTextBox);
            sortVisualizationPanel.SendToBack();
        }

        private void SaveSortToFileButton_Click(object sender, EventArgs e)
        {
            if(sortedArray == null)
            {
                MessageBox.Show("Sorted array is empty.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                DefaultExt = "txt",
                Filter = "Text files (*.txt)|*.txt"
            };

            DialogResult result = saveFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;
                using (FileStream fs = File.Create(filename))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (int value in sortedArray)
                    {
                        sw.Write(value + " ");
                    }
                }
            }
        }
        private void ToolStripMenuExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void UpdateComparisonsCount(uint count)
        {
            comparisonsTextBox.Text = count.ToString();
        }
        private void UpdatePermutationsCount(uint count)
        {
            permutationsTextBox.Text = count.ToString();
        }
        private void ClearValues()
        {
            sortVisualizationPanel.SendToBack();
            sortedArrayTextBox.Text = "";
            generatedArrayTextBox.Text = "";
            comparisonsTextBox.Text = "0";
            permutationsTextBox.Text = "0";
        }
        private void PrintArrayToTextBox(int[] array, TextBox textBox)
        {
            int arrayLength = array.Length;
            int i = 0;
            textBox.Text = "";
            while (i < arrayLength && i < 300)
            {
                textBox.AppendText(array[i++] + " ");
            }
            if(arrayLength > 300)
                textBox.AppendText(" ...");
        }
        private ShellSortEngine InitializeSortEngine()
        {
            return new ShellSortEngine(sortedArray, algorithmOptionsComboBox.SelectedIndex,
                                        descendingOrderCheckBox.Checked, UpdateComparisonsCount, UpdatePermutationsCount);
        }
        private ShellSortEngine InitializeSortVisualizationEngine()
        {
            sortVisualizationPanel.BringToFront();
            Graphics g = sortVisualizationPanel.CreateGraphics();
            float heightScale = sortVisualizationPanel.Height / (float)sortedArray.Max();
            float widthScale = sortVisualizationPanel.Width / (float)sortedArray.Length;

            if (widthScale == 0) { widthScale = 1; }
            if (heightScale == 0) {  heightScale = 1; }

            float maxValue = sortVisualizationPanel.Height;
            for (int i = 0; i < sortedArray.Length; i++)
            {
                g.FillRectangle(new SolidBrush(Color.White), i * widthScale,
                    maxValue - sortedArray[i] * heightScale, widthScale, maxValue);
            }
            return new ShellSortEngine(sortedArray, algorithmOptionsComboBox.SelectedIndex,
                                             descendingOrderCheckBox.Checked, UpdateComparisonsCount, UpdatePermutationsCount,
                                             g, heightScale, widthScale, maxValue);
        }
        private void InitializeComboBoxes()
        {
            var algorithmDataSource = new List<string>
            {
                "Shell sort (classic)",
                "Shell sort (Sedgewick sequence)",
                "Shell sort (Fibonacci sequence)",
                "Shell sort (Tokuda sequence)"
            };
            algorithmOptionsComboBox.DataSource = algorithmDataSource;
            var generationOrderDataSource = new List<string>
            {
                "Random",
                "Ascending",
                "Descending"
            };
            generationOrderComboBox.DataSource = generationOrderDataSource;
        }
    }
}
