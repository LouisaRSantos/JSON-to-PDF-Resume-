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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace JSON_Reader_PDF
{
    public partial class JSONResume : Form
    {
        public JSONResume()
        {
            InitializeComponent();
        }
        class Resume
        {
            public string FirstName { get; set; }
            public string MiddleInitital { get; set; }
            public string Surname { get; set; }
            public string Address { get; set; }
            public string ZIP { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string Objectives { get; set; }
            public string College { get; set; }
            public string SeniorHS { get; set; }
            public string JuniorHS { get; set; }
            public string Company1 { get; set; }
            public string CompanyDes1 { get; set; }
            public string Company2 { get; set; }
            public string CompanyDes2 { get; set; }
            public string Company3 { get; set; }
            public string CompanyDes3 { get; set; }
            public List<string> Skills { get; set; }

            public override string ToString()
            {
                return string.Format("\nName: {0} {1} {2} \nAddress: {3} {4} \nEmail: {5} \nPhone Number: {6} \n\nObjectives: {7} \n\nEducational Attainment \nCollege: {8} \nSenior High School: {9} \nJunior High School: {10} \n\nExperiences \nCompany: {11} \n- {12} \nCompany: {13} \n- {14} \nCompany: {15} \n- {16} \n\nSkills: {17}",
                        FirstName, MiddleInitital, Surname, Address, ZIP, Email, PhoneNumber, Objectives, College,
                        SeniorHS, JuniorHS, Company1, CompanyDes1, Company2, CompanyDes2, Company3, CompanyDes3, string.Join(" ", Skills.ToArray()));
            }
        }

        private void btnreadJSON_Click(object sender, EventArgs e)
        {
            Resume resume = new Resume()
            {
                FirstName = "LOUISA REIGHN",
                MiddleInitital = "A.",
                Surname = "SANTOS",
                Address = "Poblacion, San Ildefonso, Bulacan",
                ZIP = "3010",
                Email = "louisasantosxx@gmail.com",
                PhoneNumber = "09XXXXXXXXX",
                Objectives = " An excellent academic record, ability to understand and test software, working knowledge of Azure, and a strong understanding of core internet technologies. I seek to workas a System Engineer to further my knowledge in the IT domain and utilize my skills",
                College = "Polytechnic University of the Philippines",
                SeniorHS = "San Miguel National High School",
                JuniorHS = "Saint John School",
                Company1 = "SM Entertainment",
                CompanyDes1 = "SM Entertainment Co., Ltd. is a South Korean multinational entertainment company. It is on of South Korea's largest entertainment companies where it was established in 1995 by record executive and record producer Lee Soo-man",
                Company2 = "JYP Entertainment",
                CompanyDes2 = "JYP Entertainment Corporation is a South Korean multinational entertainment and record label conglomerate founded in 1997 by J. Y. Park.",
                Company3 = "YG Entertainment",
                CompanyDes3 = "YG Entertainment Inc. is a South Korean multinational entertainment agency established in 1996 by Yang Hyun-suk. The company operates as a record label, talent agency, music production company, event management and concert production company, and music publishing house.",
                Skills = new List<string>
                {
                    "\n\t" + "*" + "Active listening skills",
                    "\n\t" + "*" + "Communication skills",
                    "\n\t" + "*" + "Computer skills",
                    "\n\t" + "*" + "Management skills",
                    "\n\t" + "*" + "Leadership skill"
                }
            };
            string file_name = resume.Surname + "_" + resume.FirstName;
            string saveJSON = JsonConvert.SerializeObject(resume, Formatting.None);
            File.WriteAllText(@"C:\Users\Santos\Documents\json\" + file_name + ".json", saveJSON);
            MessageBox.Show("JSON file created." + "\n" + "Please save it as PDF.");
        }

        private void btnsavePDF_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog() { Filter = "json file|*.json", };
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string file = openFile.FileName;
                string json = File.ReadAllText(file);
                Resume resultResume = JsonConvert.DeserializeObject<Resume>(json);
                RTBoxResult.Text = resultResume.ToString();
            }
            else
            {
                MessageBox.Show("No file to open");
            }
        }

        private void btnsavePDF_Click_1(object sender, EventArgs e)
        {
            try
            {
                var file_image = @"C:\Users\Santos\Pictures\ID\received_196134434820796.jpeg";
                string rtbresult = RTBoxResult.Text;
                string[] cutter = new string[] { " " };
                string[] name_cut = rtbresult.Split(cutter, StringSplitOptions.None);
                string file_name = name_cut[4] + "_" + name_cut[1] + " " + name_cut[2];
                using (SaveFileDialog save = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true, FileName = file_name })
                {
                    if (RTBoxResult.Text == "")
                    {
                        MessageBox.Show("No file to save.");
                    }
                    else if (save.ShowDialog() == DialogResult.OK)
                    {
                        Document doc = new Document(PageSize.LETTER, 10f, 10f, 10f, 0f);
                        try
                        {
                            PdfWriter.GetInstance(doc, new FileStream(save.FileName, FileMode.Create));
                            doc.Open();
                            System.Drawing.Image pImage = System.Drawing.Image.FromFile(file_image);

                            iTextSharp.text.Image ItextImage = iTextSharp.text.Image.GetInstance(pImage, System.Drawing.Imaging.ImageFormat.Jpeg);
                            ItextImage.ScalePercent(15f);
                            ItextImage.SetAbsolutePosition(doc.PageSize.Width - 50f - 80f, doc.PageSize.Height - 30f - 100f);

                            doc.Add(ItextImage);

                            iTextSharp.text.Font pfont1 = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 20,
                                iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);

                            Paragraph pgraph1 = new Paragraph(name_cut[4] + ", " + name_cut[2] + " " + name_cut[1] + " " + name_cut[3], pfont1);
                            pgraph1.Alignment = Element.ALIGN_LEFT;
                            doc.Add(pgraph1);

                            pfont1 = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 14,
                                iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
                            Paragraph pgraph2 = new iTextSharp.text.Paragraph(RTBoxResult.Text, pfont1);
                            pgraph2.Alignment = Element.ALIGN_JUSTIFIED;
                            doc.Add(pgraph2);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            doc.Close();
                            MessageBox.Show("File Saved");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("No file to save.");
            }
        }
    }
}
