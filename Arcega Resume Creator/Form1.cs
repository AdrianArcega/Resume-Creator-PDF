using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.IO;

namespace Arcega_Resume_Creator
{
    public partial class Form1 : Form
    {
        private readonly string resumecreatorpath = @"C:\Users\acer\source\repos\Arcega Resume Creator\Arcega Resume Creator\resumecreator.json";
        public Form1()
        {
            InitializeComponent();
        }

        public class resumecreator
        {
            public string Fullname { get; set; }
            public string Profile { get; set; }
            public string Profile1 { get; set; }
            public string Profile2 { get; set; }
            public string Tertiary { get; set; }
            public string Tertiary1 { get; set; }
            public string Secondary { get; set; }
            public string Secondary1 { get; set; }
            public string Secondary2 { get; set; }
            public string Secondary3 { get; set; }
            public string Primary { get; set; }
            public string skill { get; set; }
            public string skill1 { get; set; }
            public string skill2 { get; set; }
            public string skill3 { get; set; }
            public string skill4 { get; set; }
            public string skill5 { get; set; }
            public string skill6 { get; set; }
            public string skill7 { get; set; }
            public string skill8 { get; set; }
            public string Email { get; set; }
            public string number { get; set; }
            public string githubacc { get; set; }
            public string Address { get; set; }
            public string Birth { get; set; }
            public string Citizenship { get; set; }
        }
        private void btnGenerateClick(object sender, EventArgs e)
        {
            string jsonResume;
            using (var reader = new StreamReader(resumecreatorpath))
            {
                jsonResume = reader.ReadToEnd();
            }
            var jsonResumeCreator = JsonConvert.DeserializeObject<resumecreator>(jsonResume);

            string Fullname = jsonResumeCreator.Fullname;


        }
    }
}
