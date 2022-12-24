using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindMinimal
{
    public partial class Form1 : Form
    {
        int minN;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            listBox1.Items.Clear();
            minN = int.MaxValue;
            for (int i = 1; i <= 10; i++)
            {
                int number = r.Next() % 100 + 1;
                listBox1.Items.Add(number);
                if (number < minN) { minN = number; }
            }
        }

        private void buttonMin_Click(object sender, EventArgs e) { textBoxMin.Text = minN.ToString(); }
    }
}
