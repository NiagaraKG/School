using System;
using System.Windows.Forms;

namespace WithWords
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (textBox1.Text)
            {
                case "0": label1.Text = "нула"; break;
                case "1": label1.Text = "едно"; break;
                case "2": label1.Text = "две"; break;
                case "3": label1.Text = "три"; break;
                case "4": label1.Text = "четири"; break;
                case "5": label1.Text = "пет"; break;
                case "6": label1.Text = "шест"; break;
                case "7": label1.Text = "седем"; break;
                case "8": label1.Text = "осем"; break;
                case "9": label1.Text = "девет"; break;
                default: label1.Text = "Грешка!"; break;
            }
        }
    }
}
