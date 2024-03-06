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
using Flags.Model;
using Newtonsoft.Json;


namespace Flags
{
    public partial class Form1 : Form
    {
        string defaultPath = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\FlagsData\\";
        int imgSize = 90;
        CountryModel countryModel;
        private int mode = 0;
        public Form1()
        {
            InitializeComponent();
            InitData();
            if (countryModel != null)
                LoadDG(countryModel.Country);
        }

        /// <summary>
        /// Loads data from a json file
        /// </summary>
        private void InitData()
        {
            string dataLink = defaultPath + "Data.json";
            try
            {
                var json = File.ReadAllText(dataLink);
                countryModel = JsonConvert.DeserializeObject<CountryModel>(json);
            }
            catch { 
                File.Create(dataLink);
                countryModel = new CountryModel();
            }
                
        }
        /// <summary>
        /// Loads information about countries into a table
        /// </summary>
        /// <param name="Cn"></param>
        private void LoadDG(List<Country> Cn)
        {
            dataGridView1.Rows.Clear();
            Bitmap img;
            int i = 0;
            if (Cn != null)
                foreach (var item in Cn)
                {
                    string pt = (string)(defaultPath + item.CountryId + ".jpg");
                    try
                    {
                        using (var fs = File.OpenRead(pt))
                            img = new Bitmap(fs);
                    }
                    catch
                    {
                        img = new Bitmap(500, 500);
                    }

                    if (mode == 1)
                        this.dataGridView1.Rows.Add(new Bitmap(img, imgSize + 30, imgSize), "???", item.CountryId);
                    else
                        this.dataGridView1.Rows.Add(new Bitmap(img, imgSize + 30, imgSize), item.CountryName, item.CountryId);
                    this.dataGridView1.Rows[i].Height = imgSize;
                    if (item.Description != null)
                        this.dataGridView1.Rows[i].Cells[1].ToolTipText = item.Description;
                    i++;
                }
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && mode == 0)
            {
                FlagEditor flagEditor = new FlagEditor(countryModel.SearchCountryByIndex((int)dataGridView1.Rows[e.RowIndex].Cells[2].Value));
                flagEditor.ShowDialog();
                flagEditor.Dispose();
                InitData();
                SetFilter();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            SetFilter();
        }
        /// <summary>
        /// Sends to draw countries after using the filter
        /// </summary>
        private void SetFilter()
        {
            if (countryModel != null)
            {
                List<string> colors = new List<string>();
                for (int i = 0; i < ColorsCheckBox.Items.Count; i++)
                {
                    if (ColorsCheckBox.GetItemChecked(i))
                    {
                        colors.Add(ColorsCheckBox.Items[i].ToString());
                    }
                }
                LoadDG(countryModel.Filter(CountryNameTextBox.Text, colors, PatternTextBox.Text, LineDirectionComboBox.Text, FigureTextBox.Text));
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            FlagEditor flagEditor = new FlagEditor();
            flagEditor.ShowDialog();
            flagEditor.Dispose();
            InitData();
            if (mode == 0)
                SetFilter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ColorsCheckBox.Items.Count; i++)
            {
                ColorsCheckBox.SetItemChecked(i, false);

            }
            CountryNameTextBox.Text = "";
            PatternTextBox.Text = "";
            FigureTextBox.Text = "";
            LineDirectionComboBox.SelectedIndex = 0;
            SetFilter();

        }

        private Country currentGameCountry;
        private int rightlyCount = 0;
        private int faultCount = 0;
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                if (countryModel != null)
                {
                    mode = 0;
                    SetFilter();
                }

            }
            else if (tabControl1.SelectedIndex == 1)
            {
                if (countryModel != null && countryModel.Country.Count() > 0)
                {
                    mode = 1;
                    TrainingInit();
                }
                
            }
        }
        /// <summary>
        /// Initializes the training mode
        /// </summary>
        private void TrainingInit()
        {
            rightlyCount = 0;
            faultCount = 0;
            TraningTextBox.Text = "";
            TraningResiltLabel.Text = "";
            TraningRightLabel.Text = "Rightly: " + rightlyCount;
            TraningFaultLabel.Text = "Fault: " + faultCount;
            TraningNextCountry();
        }
        /// <summary>
        /// Gets a random country and sends it to draw it.
        /// </summary>
        private void TraningNextCountry()
        {
            currentGameCountry = countryModel.GetRandomCountry();
            LoadDG(new List<Country> { currentGameCountry });
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (mode == 1)
            {
                if (TraningTextBox.Text == currentGameCountry.CountryName)
                {
                    TraningResiltLabel.Text = "Right!";
                    TraningResiltLabel.ForeColor = Color.Green;
                    rightlyCount++;
                    TraningRightLabel.Text = "Rightly: " + rightlyCount;
                }
                else
                {
                    TraningResiltLabel.Text = "Wrong!";
                    TraningResiltLabel.ForeColor = Color.Red;
                    faultCount++;
                    TraningFaultLabel.Text = "Fault: " + faultCount;
                }
                TraningTextBox.Text = "";
                TraningNextCountry();
            }
        }
    }
}
