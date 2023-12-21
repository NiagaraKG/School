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

namespace _28._01__clasResults
{
    public partial class Form1 : Form
    {
        public class Student
        {
            public string clas;
            public string ID;
            public string name;
            private double bulgarian, foreign, math, physics, chemistry, biology, average;

            public double Bulgarian
            {
                get { return this.bulgarian; }
                set
                {
                    if (value >= 2.00 && value <= 6.00) { this.bulgarian = value; }
                    else { Console.WriteLine("Невалидна оценка"); }
                }
            }
            public double Foreign
            {
                get { return this.foreign; }
                set
                {
                    if (value >= 2.00 && value <= 6.00) { this.foreign = value; }
                    else { Console.WriteLine("Невалидна оценка"); }
                }
            }
            public double Math
            {
                get { return this.math; }
                set
                {
                    if (value >= 2.00 && value <= 6.00) { this.math = value; }
                    else { Console.WriteLine("Невалидна оценка"); }
                }
            }
            public double Physics
            {
                get { return this.physics; }
                set
                {
                    if (value >= 2.00 && value <= 6.00) { this.physics = value; }
                    else { Console.WriteLine("Невалидна оценка"); }
                }
            }
            public double Chemistry
            {
                get { return this.chemistry; }
                set
                {
                    if (value >= 2.00 && value <= 6.00) { this.chemistry = value; }
                    else { Console.WriteLine("Невалидна оценка"); }
                }
            }
            public double Biology
            {
                get { return this.biology; }
                set
                {
                    if (value >= 2.00 && value <= 6.00) { this.biology = value; }
                    else { Console.WriteLine("Невалидна оценка"); }
                }
            }
            public double Average
            {
                get { return this.average; }
                set
                {
                    if (value >= 2.00 && value <= 6.00) { this.average = value; }
                    else { Console.WriteLine("Невалидна оценка"); }
                }
            }
        }

        Student currentStudent = new Student();
        Student[] clas = new Student[27];


        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i <= 26; i++) { clas[i] = new Student(); }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            textBoxClas.Text = "";
            textBoxID.Text = "";
            textBoxName.Text = "";
            textBoxBulgarian.Text = "";
            textBoxForeign.Text = "";
            textBoxMath.Text = "";
            textBoxPhysics.Text = "";
            textBoxChemistry.Text = "";
            textBoxBiology.Text = "";
            labelAverageGrade.Text = "";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textBoxID.Text);
            double average;
            if (i >= 1 && i <= 26)
            {
                clas[i].clas = textBoxClas.Text;
                clas[i].ID = textBoxID.Text;
                clas[i].name = textBoxName.Text;
                clas[i].Bulgarian = double.Parse(textBoxBulgarian.Text);
                clas[i].Foreign = double.Parse(textBoxForeign.Text);
                clas[i].Math = double.Parse(textBoxMath.Text);
                clas[i].Physics = double.Parse(textBoxPhysics.Text);
                clas[i].Chemistry = double.Parse(textBoxChemistry.Text);
                clas[i].Biology = double.Parse(textBoxBiology.Text);
                average = (double.Parse(textBoxBulgarian.Text) + double.Parse(textBoxForeign.Text) + double.Parse(textBoxMath.Text) + double.Parse(textBoxPhysics.Text) + double.Parse(textBoxChemistry.Text) + double.Parse(textBoxBiology.Text)) / 6;
                clas[i].Average = average;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textBoxID.Text);
            if (i >= 1 && i <= 26)
            {
                textBoxClas.Text = clas[i].clas;
                textBoxName.Text = clas[i].name;
                textBoxBulgarian.Text = clas[i].Bulgarian.ToString();
                textBoxForeign.Text = clas[i].Foreign.ToString();
                textBoxMath.Text = clas[i].Math.ToString();
                textBoxPhysics.Text = clas[i].Physics.ToString();
                textBoxChemistry.Text = clas[i].Chemistry.ToString();
                textBoxBiology.Text = clas[i].Biology.ToString();
                labelAverageGrade.Text = clas[i].Average.ToString("0.00");
            }
        }

        private void buttonAverage_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textBoxID.Text);
            labelAverageGrade.Text = clas[i].Average.ToString("0.00");
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            string s;
            StreamWriter writer = new StreamWriter("C:/Users/Public/9aClas.txt", false);
            for (int i = 1; i <= 26; i++)
            {
                s = clas[i].clas + " " + clas[i].ID + " " + clas[i].name + " " + clas[i].Bulgarian + " " + clas[i].Foreign + " " + clas[i].Math + " " + clas[i].Physics + " " + clas[i].Chemistry + " " + clas[i].Biology + " " + clas[i].Average;
                writer.WriteLine(s);
            }
            writer.Close();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("C:/Users/Public/9aClas.txt");
            string line = "";
            richTextBoxClas.Text = "";
            int i = 1, position, position1, next;
            line = reader.ReadLine();
            while (line != null)
            {
                position = 0;
                richTextBoxClas.Text += line + Environment.NewLine;
                if (line != "   0 0 0 0 0 0 0")
                {
                    position = 0;
                    next = line.IndexOf(" ", position);
                    clas[i].clas = line.Substring(position, next - position);
                    position = next + 1; next = line.IndexOf(" ", position);
                    clas[i].ID = line.Substring(position, next - position);
                    position = next + 1; next = line.IndexOf(" ", position);
                    position1 = next + 1; next = line.IndexOf(" ", position1);
                    clas[i].name = line.Substring(position, next - position);
                    position = next + 1; next = line.IndexOf(" ", position);

                    clas[i].Bulgarian = double.Parse(line.Substring(position, next - position));
                    position = next + 1; next = line.IndexOf(" ", position);
                    clas[i].Foreign = double.Parse(line.Substring(position, next - position));
                    position = next + 1; next = line.IndexOf(" ", position);
                    clas[i].Math = double.Parse(line.Substring(position, next - position));
                    position = next + 1; next = line.IndexOf(" ", position);
                    clas[i].Physics = double.Parse(line.Substring(position, next - position));
                    position = next + 1; next = line.IndexOf(" ", position);
                    clas[i].Chemistry = double.Parse(line.Substring(position, next - position));
                    position = next + 1; next = line.IndexOf(" ", position);
                    clas[i].Biology = double.Parse(line.Substring(position, next - position));
                    position = next + 1; next = line.IndexOf(" ", position);
                    clas[i].Average = double.Parse(line.Substring(position));
                }
                i++;
                line = reader.ReadLine();
            }
            reader.Close();
        }

       
    }
}
