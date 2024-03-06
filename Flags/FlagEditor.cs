using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flags.Model;
using Newtonsoft.Json;

namespace Flags
{
    public partial class FlagEditor : Form
    {
        private int x1;
        private int y1;
        private Bitmap pic;
        private Graphics g;
        private int deafultSize = 500;
        private Color penColor = Color.Black;
        private Country country;
        private string defaultPath = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\FlagsData\\";
        public FlagEditor(Country country = null)
        {
            InitializeComponent();
            this.country = country;
            InitData();
        }
        /// <summary>
        /// Loads data from country
        /// </summary>
        private void InitData()
        {
            x1 = y1 = 0;
            pic = new Bitmap(deafultSize, deafultSize);
            pictureBox1.Height = deafultSize;
            pictureBox1.Width = deafultSize;
            pictureBox1.Image = pic;
            g = Graphics.FromImage(pic);
            if (country != null)
            {
                try
                {
                    using (var fs = File.OpenRead(defaultPath + country.CountryId + ".jpg"))
                        pic = new Bitmap(fs);
                }
                catch
                {
                    pic = new Bitmap(500, 500);
                }

                pictureBox1.Image = pic;

                g = Graphics.FromImage(pic);
                this.CountryNameTextBox.Text = country.CountryName;
                for (int i = 0; i < ColorsCheckBox.Items.Count; i++)
                {
                    if (country.Colors.Contains(ColorsCheckBox.Items[i].ToString()))
                    {
                        this.ColorsCheckBox.SetItemChecked(i, true);
                    }
                }
                if (!(country.Pattern is null))
                {
                    this.PatternTextBox.Text = country.Pattern.ToString();
                }
                this.LineDirectionComboBox.SelectedIndex = this.LineDirectionComboBox.FindStringExact(country.LineDirection);
                if (!(country.Figure is null))
                {
                    this.FigureTextBox.Text = country.Figure.ToString();
                }
                if (!(country.Description is null))
                {
                    this.DescriptionTextBox.Text = country.Description.ToString();
                }

            }
            Pen p;
            p = new Pen(penColor);
            g.DrawLine(p, 0, 0, 0, 1);
            g.DrawLine(p, 0, 0, 1, 0);
        }

        private bool drawing = false;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Pen p;
            p = new Pen(penColor, penSize);
            p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            p.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            g = Graphics.FromImage(pic);
            if (drawing)
            {
                g.DrawLine(p, x1, y1, e.X, e.Y);
                pictureBox1.Image = pic;
            }
            x1 = e.X; y1 = e.Y;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "" && openFileDialog1.FileName != "openFileDialog1")
            {
                pic= new Bitmap(Image.FromFile(openFileDialog1.FileName));
                pictureBox1.Image=pic;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            button1.BackColor = colorDialog1.Color;
            penColor = colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CountryNameTextBox.Text != "")
            {

                CountryModel Cm = new CountryModel();
                string dataLink = defaultPath + "Data.json";

                var json = File.ReadAllText(dataLink);



                Cm = JsonConvert.DeserializeObject<CountryModel>(json);
                if (Cm == null)
                    Cm = new CountryModel();


                Country currentCountry;

                if (country != null)
                {
                    currentCountry = Cm.SearchCountryByIndex(country.CountryId);
                    currentCountry.CountryName = CountryNameTextBox.Text;
                    SetCountry(currentCountry);
                }
                else
                {
                    currentCountry = new Country();
                    currentCountry.CountryId = Cm.NewIndex();
                    SetCountry(currentCountry);
                    Cm.Country.Add(currentCountry);
                }

                var jsonOut = Newtonsoft.Json.JsonConvert.SerializeObject(Cm);
                File.WriteAllText(dataLink, jsonOut);
                string imgPath = defaultPath + currentCountry.CountryId + ".jpg";
                pictureBox1.Image.Save(imgPath);
                this.Close();
            }
            else
            { MessageBox.Show("Пожалуйста, введите название страны!"); }

        }
        /// <summary>
        /// Writes textbox data to the country
        /// </summary>
        /// <param name="currentCountry"></param>
        private void SetCountry(Country currentCountry)
        {
            currentCountry.CountryName = CountryNameTextBox.Text;
            List<string> colors = new List<string>();
            for (int i = 0; i < ColorsCheckBox.Items.Count; i++)
            {
                if (ColorsCheckBox.GetItemChecked(i))
                {
                    colors.Add(ColorsCheckBox.Items[i].ToString());
                }
            }
            currentCountry.Colors = colors;
            currentCountry.Pattern = PatternTextBox.Text;
            currentCountry.LineDirection = LineDirectionComboBox.Text;
            currentCountry.Figure = FigureTextBox.Text;
            if (DescriptionTextBox.Text != "")
                currentCountry.Description = DescriptionTextBox.Text;
        }

        private void deliteButtom_Click(object sender, EventArgs e)
        {
            CountryModel Cm = new CountryModel();
            string dataLink = defaultPath + "Data.json";
            var json = File.ReadAllText(dataLink);

            Cm = JsonConvert.DeserializeObject<CountryModel>(json);

            Country currentCountry;
            if (country != null)
            {
                Cm.DelByIndex(country.CountryId);
                var jsonOut = Newtonsoft.Json.JsonConvert.SerializeObject(Cm);
                File.WriteAllText(dataLink, jsonOut);
                string imgPath = defaultPath + country.CountryId + ".jpg";
                File.Delete(imgPath);
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
        private int penSize = 1;
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            penSize = trackBar1.Value;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pic = new Bitmap(deafultSize, deafultSize);
            pictureBox1.Height = deafultSize;
            pictureBox1.Width = deafultSize;
            pictureBox1.Image = pic;
        }
    }
}
