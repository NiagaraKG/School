using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            textBoxResult.Visible = true;
            textBoxResult.Text = "Hello World";
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            textBoxResult.Visible = false;
        }
    }
}
