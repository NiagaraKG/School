using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toto
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int n1, n2, n3, n4, n5, n6;
        public Form1() { InitializeComponent(); }
        int GetRandom() { return r.Next() % 49 + 1; }
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            n1 = GetRandom(); number1.Text = n1.ToString();
            do { n2 = GetRandom(); } while (n2 == n1); number2.Text = n2.ToString();
            do { n3 = GetRandom(); } while (n3 == n1 || n3 == n2); number3.Text = n3.ToString();
            do { n4 = GetRandom(); } while (n4 == n1 || n4 == n2 || n4 == n3); number4.Text = n4.ToString();
            do { n5 = GetRandom(); } while (n5 == n1 || n5 == n2 || n5 == n3 || n5 == n4); number5.Text = n5.ToString();
            do { n6 = GetRandom(); } while (n6 == n1 || n6 == n2 || n6 == n3 || n6 == n4 || n6 == n5); number6.Text = n6.ToString();
        }
    }
}
