using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toto2
{
    public partial class Form1 : Form
    {
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        int GetRandom() { return r.Next(1, 50); }

        bool InArray(int[] arr, int n)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i]==n) { return true; }
            }
            return false;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            int n;
            int[] numbers = new int[6];
            for (int i = 0; i < 6; i++)
            {
                do { n = GetRandom(); } while (InArray(numbers, n));
                numbers[i] = n;
            }
            labelNumbers.Text = string.Join("; ", numbers);
        }

        private void buttonClean_Click(object sender, EventArgs e) { labelNumbers.Text = ""; }
    }
}
