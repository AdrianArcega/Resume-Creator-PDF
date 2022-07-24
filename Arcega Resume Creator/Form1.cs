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
                fileDialog.FileName = lastname + "_" + firstname + ".pdf";
                fileDialog.Filter = "PDF|*.pdf";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    PdfDocument pdfDocument = new PdfDocument();
                    pdfDocument.Info.Title = lastname + "_" + firstname + "Resume";
                    PdfPage pdfpage = pdfDocument.AddPage(); 

                    XGraphics xgraphics = XGraphics.FromPdfPage(pdfpage);
                    //Font size
                    XFont largeFont = new XFont(" ", 18, XFontStyle.Regular);
                    XFont largeFont1 = new XFont(" ", 18, XFontStyle.Bold);
                    XFont mediumFont = new XFont(" ", 16, XFontStyle.Regular);
                    XFont mediumFont1 = new XFont(" ", 16, XFontStyle.Bold);
                    XFont smallFont = new XFont(" ", 12, XFontStyle.Regular);
                    XFont smallFont1 = new XFont(" ", 12, XFontStyle.Bold);

                    //Margin
                    int leftmargin = 25;
                    int leftinitial = 200;
                    int middlemargin = 220;
                    int middleinitial = 200;

                    //Design
                    xgraphics.DrawRectangle(XBrushes.LightGray, 0, 0, pdfpage.Width.Point, pdfpage.Height.Point);
                    xgraphics.DrawRectangle(XBrushes.WhiteSmoke, 200, 0, pdfpage.Width.Point, pdfpage.Height.Point);
                    //Resume Picture
                    string pic = @"C:\Users\acer\Desktop\Adrian\Resume Generator\resumepic.png";
                    XImage respic = XImage.FromFile(pic);
                    xgraphics.DrawImage(respic, leftmargin, 52, 150, 150);
                    //Name
                    xgraphics.DrawString(firstname + " " + lastname, largeFont, XBrushes.Black, new XRect(leftmargin , leftinitial + 10, pdfpage.Width.Point, pdfpage.Height.Point + 30), XStringFormats.TopLeft);
                    //Contacts
                    xgraphics.DrawString("Contact Info", mediumFont1, XBrushes.Black, new XRect(leftmargin, leftinitial + 60, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(Email, smallFont, XBrushes.Black, new XRect(leftmargin, leftinitial + 90, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(Number, smallFont, XBrushes.Black, new XRect(leftmargin, leftinitial + 110, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(Address, smallFont, XBrushes.Black, new XRect(leftmargin, leftinitial + 130, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(githubacc, smallFont, XBrushes.Black, new XRect(leftmargin, leftinitial + 150, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);

                    //Hard Skills
                    xgraphics.DrawString("Hard Skills", mediumFont1, XBrushes.Black, new XRect(leftmargin, leftinitial + 200, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(skill5, smallFont, XBrushes.Black, new XRect(leftmargin, leftinitial + 220, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(skill6, smallFont, XBrushes.Black, new XRect(leftmargin, leftinitial + 240, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(skill7, smallFont, XBrushes.Black, new XRect(leftmargin, leftinitial + 260, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(skill8, smallFont, XBrushes.Black, new XRect(leftmargin, leftinitial + 280, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);

                    //Soft Skills
                    xgraphics.DrawString("Soft Skills", mediumFont1, XBrushes.Black, new XRect(leftmargin, leftinitial + 330, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(skill, smallFont, XBrushes.Black, new XRect(leftmargin, leftinitial + 360, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(skill1, smallFont, XBrushes.Black, new XRect(leftmargin, leftinitial + 380, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(skill2, smallFont, XBrushes.Black, new XRect(leftmargin, leftinitial + 400, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(skill3, smallFont, XBrushes.Black, new XRect(leftmargin, leftinitial + 420, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(skill4, smallFont, XBrushes.Black, new XRect(leftmargin, leftinitial + 440, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);

                    //Profile
                    xgraphics.DrawString("Profile", largeFont1, XBrushes.Black, new XRect(middlemargin + 170, middleinitial - 120, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(Profile, smallFont, XBrushes.Black, new XRect(middlemargin, middleinitial - 85, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(Profile1, smallFont, XBrushes.Black, new XRect(middlemargin, middleinitial - 70, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(Profile2, smallFont, XBrushes.Black, new XRect(middlemargin, middleinitial - 55, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);

                    //Education History
                    xgraphics.DrawString("Education History", largeFont1, XBrushes.Black, new XRect(middlemargin + 120, middleinitial + 20, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString("Tertiary Education", largeFont1, XBrushes.Black, new XRect(middlemargin, middleinitial + 60, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(Tertiary, smallFont1, XBrushes.Black, new XRect(middlemargin, middleinitial + 80, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(Tertiary1, smallFont, XBrushes.Black, new XRect(middlemargin, middleinitial + 100, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString("Secondary Education", largeFont1, XBrushes.Black, new XRect(middlemargin, middleinitial + 140, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString("Senior High School", mediumFont1, XBrushes.Black, new XRect(middlemargin, middleinitial + 170, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(Secondary, smallFont1, XBrushes.Black, new XRect(middlemargin, middleinitial + 190, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(Secondary1, smallFont, XBrushes.Black, new XRect(middlemargin, middleinitial + 210, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString("Junior High School", mediumFont1, XBrushes.Black, new XRect(middlemargin, middleinitial +240, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(Secondary2, smallFont1, XBrushes.Black, new XRect(middlemargin, middleinitial + 260, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(Secondary3, smallFont, XBrushes.Black, new XRect(middlemargin, middleinitial + 280, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString("Primary Education", mediumFont1, XBrushes.Black, new XRect(middlemargin, middleinitial + 310, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    xgraphics.DrawString(Primary, smallFont1, XBrushes.Black, new XRect(middlemargin, middleinitial + 330, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormats.TopLeft);
                    pdfDocument.Save(fileDialog.FileName);
                    MessageBox.Show("Thank you!");
                    this.Close();
                }
            }

        }
    }
}
