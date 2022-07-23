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
            public string firstname { get; set; }
            public string lastname { get; set; }
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
            public string Number { get; set; }
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

            string firstname = jsonResumeCreator.firstname;
            string lastname = jsonResumeCreator.lastname;
            string Profile = jsonResumeCreator.Profile;
            string Profile1 = jsonResumeCreator.Profile1;
            string Profile2 = jsonResumeCreator.Profile2;

            string Tertiary = jsonResumeCreator.Tertiary;
            string Tertiary1 = jsonResumeCreator.Tertiary1;
            string Secondary = jsonResumeCreator.Secondary;
            string Secondary1 = jsonResumeCreator.Secondary1;
            string Secondary2 = jsonResumeCreator.Secondary2;
            string Secondary3 = jsonResumeCreator.Secondary3;
            string Primary = jsonResumeCreator.Primary;

            string skill = jsonResumeCreator.skill;
            string skill1 = jsonResumeCreator.skill1;
            string skill2 = jsonResumeCreator.skill2;
            string skill3 = jsonResumeCreator.skill3;
            string skill4 = jsonResumeCreator.skill4;
            string skill5 = jsonResumeCreator.skill5;
            string skill6 = jsonResumeCreator.skill6;
            string skill7 = jsonResumeCreator.skill7;
            string skill8 = jsonResumeCreator.skill8;

            string Email = jsonResumeCreator.Email;
            string Number = jsonResumeCreator.Number;
            string githubacc = jsonResumeCreator.githubacc;
            string Address = jsonResumeCreator.Address;
            string Birth = jsonResumeCreator.Birth;
            string Citizenship = jsonResumeCreator.Citizenship;

         using (SaveFileDialog fileDialog = new SaveFileDialog())
            {
                fileDialog.InitialDirectory = @"C:\Users\acer\source\repos\Arcega Resume Creator\Arcega Resume Creator";
                fileDialog.FileName = lastname + "" + firstname + ".pdf";
                fileDialog.Filter = "PDF|*.pdf";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    PdfDocument pdfDocument = new PdfDocument();
                    pdfDocument.Info.Title = lastname + "_" + firstname + "Resume";
                    PdfPage page = pdfDocument.AddPage(); 
                }
            }

        }
    }
}
