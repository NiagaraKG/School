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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        [Serializable()]
        public class Student
		{
			//атрибути
			public string clas;   // клас
			public string id;    // номер в класа
			public string name;  // име на ученика
								 //оценки по основните предмети
			public double dBEL, dForeign, dMath, dPhys, dChem, dBio;
			// среден успех
			public double average;
			// гетъри/сетъри
			public double DBEL
			{
				set
				{
					if (value >= 2.00 && value <= 6.00) this.dBEL = value;
					else Console.WriteLine("Невъзможна оценка!");
				}
				get { return this.dBEL; }
			}
			public double DForeign
			{
				set
				{
					if (value >= 2.00 && value <= 6.00) this.dForeign = value;
					else Console.WriteLine("Невъзможна оценка!");
				}
				get { return this.dForeign; }
			}
			public double DMath
			{
				set
				{
					if (value >= 2.00 && value <= 6.00) this.dMath = value;
					else Console.WriteLine("Невъзможна оценка!");
				}
				get { return this.dMath; }
			}
			public double DPhys
			{
				set
				{
					if (value >= 2.00 && value <= 6.00) this.dPhys = value;
					else Console.WriteLine("Невъзможна оценка!");
				}
				get { return this.dPhys; }
			}
			public double DChem
			{
				set
				{
					if (value >= 2.00 && value <= 6.00) this.dChem = value;
					else Console.WriteLine("Невъзможна оценка!");
				}
				get { return this.dChem; }
			}
			public double DBio
			{
				set
				{
					if (value >= 2.00 && value <= 6.00) this.dBio = value;
					else Console.WriteLine("Невъзможна оценка!");
				}
				get { return this.dBio; }
			}
			public double Average
			{
				set
				{
					if (value >= 2.00 && value <= 6.00) this.average = value;
					else Console.WriteLine("Невъзможна оценка!");
				}
				get { return this.average; }
			}
		}

		Student newStud = new Student();
		Student[] clasof = new Student[27];
	
		public Form1()
        {
            InitializeComponent();
			for(int i = 1; i <=26; i++)  clasof[i] = new Student(); 
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
			textBoxClas.Text = "";
			textBoxID.Text = "";
			textBoxName.Text = "";
			textBoxBEL.Text = "0";
			textBoxForeign.Text = "0";
			textBoxMath.Text = "0";
			textBoxPhys.Text = "0";
			textBoxChem.Text = "0";
			textBoxBio.Text = "0";
			labelAverage.Text = "0";
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
				int i = int.Parse(textBoxID.Text);
                double av;
                if (i >= 1 && i <= 26)
				{
                    clasof[i].clas = textBoxClas.Text;
                    clasof[i].id = textBoxID.Text;
                    clasof[i].name = textBoxName.Text;
                    clasof[i].DBEL = double.Parse(textBoxBEL.Text);
                    clasof[i].DForeign = double.Parse(textBoxForeign.Text);
                    clasof[i].DMath = double.Parse(textBoxMath.Text);
                    clasof[i].DPhys = double.Parse(textBoxPhys.Text);
                    clasof[i].DChem = double.Parse(textBoxChem.Text);
                    clasof[i].DBio = double.Parse(textBoxBio.Text);
                    av = (clasof[i].DBEL+ clasof[i].DForeign+ clasof[i].DMath+ clasof[i].DPhys+ clasof[i].DChem+ clasof[i].DBio) / 6;
                    clasof[i].Average = av;
            }			
		}		
		
         private void buttonFind_Click(object sender, EventArgs e)
         {
			int i = int.Parse(textBoxID.Text);
            if (i >= 1 && i <= 26)
            {
				textBoxClas.Text = clasof[i].clas;
				textBoxName.Text = clasof[i].name;
				textBoxBEL.Text = clasof[i].DBEL.ToString();
				textBoxForeign.Text = clasof[i].DForeign.ToString();
				textBoxMath.Text = clasof[i].DMath.ToString();
				textBoxPhys.Text = clasof[i].DPhys.ToString();
				textBoxChem.Text = clasof[i].DChem.ToString();
				textBoxBio.Text = clasof[i].DBio.ToString();
                labelAverage.Text = clasof[i].Average.ToString("0.00");                
			}
         }
        private void buttonAverage_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textBoxID.Text);
			labelAverage.Text = clasof[i].Average.ToString("0.00");
        }       

        private void buttonOpen1_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFD = new OpenFileDialog();
            oFD.Filter = "bin files (*.bin)|*.bin|All files (*.*)|*.*";
            oFD.FilterIndex = 1;
            oFD.RestoreDirectory = true;
            if (oFD.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(oFD.FileName, FileMode.Open, FileAccess.Read);
                clasof = (Student[])formatter.Deserialize(stream);
                stream.Close();
                string line = "";
                richTextBox1.Text = "";
                for (int i = 1; i <= 26; i++)
                {
                 line = clasof[i].clas + " " + clasof[i].id + " " + clasof[i].name + " " + clasof[i].DBEL + " " + clasof[i].DForeign + " " + clasof[i].DMath + " " + clasof[i].DPhys + " " + clasof[i].DChem + " " + clasof[i].DBio+" "+clasof[i].Average.ToString("0.00");
                 richTextBox1.Text += line + '\n';
                }
                textBoxID.Text = "1";
                buttonFind.PerformClick();
            }
        }
        // Записване на richTextBox във *.rtf файлов формат
        //  private void button2_Click(object sender, EventArgs e)
        //  {          
        //     SaveFileDialog sfd = new SaveFileDialog();
        //     sfd.Filter = "Файлов формат:|*.rtf";            
        //     if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //      {
        //         richTextBox1.SaveFile(sfd.FileName);       
        //      }
        //  }

        private void button3_Click(object sender, EventArgs e)
        {       
            SaveFileDialog sFD = new SaveFileDialog();
            sFD.Filter = "bin files (*.bin)|*.bin|All files (*.*)|*.*";
            sFD.FilterIndex = 1;
            sFD.RestoreDirectory = true;
            if (sFD.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(sFD.FileName, FileMode.Create, FileAccess.Write);
                formatter.Serialize(stream, clasof);
                stream.Close();
            }            
        }

        private void buttonXML_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.clas = "9а"; s.id = "5"; s.name = "Иван Петров";
            SaveFileDialog sFD = new SaveFileDialog();
            sFD.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            sFD.FilterIndex = 1;
            sFD.RestoreDirectory = true;
            if(sFD.ShowDialog() == DialogResult.OK)
            {
                System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(Student));
                System.IO.FileStream file = System.IO.File.Create(sFD.FileName);
                writer.Serialize(file, s);
                file.Close();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            buttonSave.PerformClick();
            int k = int.Parse(textBoxID.Text);
            if (k < 26)
            {
                k++;
                textBoxID.Text = k.ToString();
                buttonFind.PerformClick();
            }
        }
    }
}
