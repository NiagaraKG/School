using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21._01._2021___classResults
{
    public partial class Form1 : Form
    {

        Student[] clas = new Student[26];
        public Form1()
        {
            InitializeComponent(); for (int i = 0; i < 26; i++) { clas[i] = new Student(); }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            double[] currentGrades = new double[]
            {
                double.Parse( textBoxBulgarian.Text),
                double.Parse( textBoxForeign.Text),
                double.Parse( textBoxMath.Text),
                double.Parse( textBoxPhysics.Text),
                double.Parse( textBoxChemistry.Text),
                double.Parse( textBoxBiology.Text),
            };
            Student current = new Student(textBoxName.Text, textBoxClas.Text, int.Parse(textBoxID.Text), currentGrades);
            clas[current.ID - 1] = new Student(current);
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            textBoxClas.Text = ""; textBoxID.Text = ""; textBoxName.Text = "";
            textBoxBulgarian.Text = ""; textBoxForeign.Text = ""; textBoxMath.Text = "";
            textBoxPhysics.Text = ""; textBoxChemistry.Text = ""; textBoxBiology.Text = "";
            labelAverageResult.Text = "";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textBoxID.Text)-1;
            textBoxClas.Text = clas[i].clas; textBoxName.Text = clas[i].name.ToString();
            textBoxBulgarian.Text = clas[i].grades[0].ToString(); textBoxForeign.Text = clas[i].grades[1].ToString(); textBoxMath.Text = clas[i].grades[2].ToString();
            textBoxPhysics.Text = clas[i].grades[3].ToString(); textBoxChemistry.Text = clas[i].grades[4].ToString(); textBoxBiology.Text = clas[i].grades[5].ToString();
            labelAverageResult.Text = clas[i].grades.Average().ToString();
        }

        private void buttonAverage_Click(object sender, EventArgs e)
        {
            double[] currentGrades = new double[]
            {
                double.Parse( textBoxBulgarian.Text),
                double.Parse( textBoxForeign.Text),
                double.Parse( textBoxMath.Text),
                double.Parse( textBoxPhysics.Text),
                double.Parse( textBoxChemistry.Text),
                double.Parse( textBoxBiology.Text),
            };
            labelAverageResult.Text = currentGrades.Average().ToString();            
        }

        public class Student
        {
            public string name, clas;
            public int ID;
            public double[] grades = new double[6];
            public Student() { }
            public Student(string name, string clas, int ID, double[] grades)
            {
                this.name = name; this.clas = clas; this.ID = ID;
                for (int i = 0; i < 6; i++) { this.grades[i] = grades[i]; }
            }
            public Student(Student B)
            {
                this.name = B.name; this.clas = B.clas; this.ID = B.ID;
                for (int i = 0; i < 6; i++) { this.grades[i] = B.grades[i]; }
            }
        }
    }
}
