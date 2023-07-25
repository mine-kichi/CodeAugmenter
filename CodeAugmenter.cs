using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var lines = File.ReadAllLines(openFileDialog.FileName);
                var modifiedLines = ModifyLines(lines);
                File.WriteAllLines(openFileDialog.FileName, modifiedLines);
                MessageBox.Show("File modified successfully!");
            }
        }

        private string[] ModifyLines(string[] lines)
        {
            var modifiedLines = new List<string>();
            for (int i = 0; i < lines.Length; i++)
            {
                modifiedLines.Add(lines[i]);

                if (lines[i].EndsWith(")"))
                {
                    modifiedLines.Add("任意の文字"); // Insert arbitrary text
                }
            }
            return modifiedLines.ToArray();
        }
    }
}
