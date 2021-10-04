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

namespace PRG282GitQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();
            using (StreamReader sr = new StreamReader("File.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lbxFile.Items.Add(line);
                }
                sr.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<String> Data = new List<string>();
            Data.Add("Username: 007, Name: James Bond, Ocupation: Assassin");
            Data.Add("Username: Stig, Name: The Stig, Ocupation: Reckless Driver");
            Data.Add("Username: Beast, Name: Tendai Mtawarira, Ocupation: Prop");
            Data.Add("UserName: Starlord, Name: Peter Quill, Ocupation: Galactic Idiot");
            string fName = "File.txt";
            if (File.Exists(fName))
            {
                File.Delete(fName);
            }
            File.Create(fName);
            TextWriter tw = new StreamWriter(fName);
            tw.WriteLine(Data);
            tw.Close();

        }
    }
}
