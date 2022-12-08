using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26._01._2021___CompareTextBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            textBox1.Text = "";
            label1.Text = "";
        StreamReader reader = new StreamReader($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\test.txt");
            string s = "";
            while (s != null)
            {
                s = reader.ReadLine();
                richTextBox1.Text += s + Environment.NewLine;
                textBox1.Text += s + Environment.NewLine;
                label1.Text += s + Environment.NewLine;
            }
            reader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\test.txt");
            for (int i = 0; i < richTextBox1.Lines.Count(); i++)
            { writer.WriteLine(richTextBox1.Lines[i]); }
            writer.Close();
        }
    }
}
