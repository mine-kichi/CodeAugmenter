using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lines = textBox1.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            var newLines = new List<string>();
            bool shouldAddText = false;

            foreach (var line in lines)
            {
                newLines.Add(line);

                if (shouldAddText)
                {
                    newLines.Add("任意の文字"); // 任意の文字を追加
                    shouldAddText = false;
                }

                if (line.Trim().EndsWith(")")) // 行末が ")" で終わるかどうかをチェック
                {
                    shouldAddText = true;
                }
            }

            textBox2.Text = string.Join(Environment.NewLine, newLines);
        }
    }
}
