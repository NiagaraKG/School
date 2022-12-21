using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassworkMin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        { labelSelected.Text = listBox1.SelectedItem.ToString(); }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < 10; i++) { listBox1.Items.Add(r.Next(1, 101)); }
        }

        private void button2_Click(object sender, EventArgs e) { listBox1.Items.Clear(); }

        private void button3_Click(object sender, EventArgs e)
        {
            int min = int.Parse(listBox1.Items[0].ToString()), b;
            for (int i = 1; i < listBox1.Items.Count; i++)
            {
                b = int.Parse(listBox1.Items[i].ToString());
                if (b < min) { min = b; }
            }
            labelMin.Text = min.ToString();
        }
    }
}
