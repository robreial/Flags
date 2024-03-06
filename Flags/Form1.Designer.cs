namespace Flags
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Flag = new System.Windows.Forms.DataGridViewImageColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatternTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ColorsCheckBox = new System.Windows.Forms.CheckedListBox();
            this.CountryNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.FigureTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LineDirectionComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.TabPage();
            this.TraningFaultLabel = new System.Windows.Forms.Label();
            this.TraningRightLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TraningTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.TraningResiltLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Flag,
            this.Country,
            this.index});
            this.dataGridView1.Location = new System.Drawing.Point(170, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(244, 337);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Flag
            // 
            this.Flag.HeaderText = "Flag";
            this.Flag.MinimumWidth = 138;
            this.Flag.Name = "Flag";
            this.Flag.ReadOnly = true;
            this.Flag.Width = 138;
            // 
            // Country
            // 
            this.Country.HeaderText = "Country";
            this.Country.MinimumWidth = 85;
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            this.Country.Width = 85;
            // 
            // index
            // 
            this.index.HeaderText = "index";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Visible = false;
            // 
            // PatternTextBox
            // 
            this.PatternTextBox.Location = new System.Drawing.Point(4, 173);
            this.PatternTextBox.Name = "PatternTextBox";
            this.PatternTextBox.Size = new System.Drawing.Size(114, 20);
            this.PatternTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pattern:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Colors:";
            // 
            // ColorsCheckBox
            // 
            this.ColorsCheckBox.FormattingEnabled = true;
            this.ColorsCheckBox.Items.AddRange(new object[] {
            "white",
            "blue",
            "red",
            "yellow",
            "orange",
            "green",
            "black",
            "purple"});
            this.ColorsCheckBox.Location = new System.Drawing.Point(4, 71);
            this.ColorsCheckBox.Name = "ColorsCheckBox";
            this.ColorsCheckBox.Size = new System.Drawing.Size(114, 79);
            this.ColorsCheckBox.TabIndex = 5;
            // 
            // CountryNameTextBox
            // 
            this.CountryNameTextBox.Location = new System.Drawing.Point(4, 22);
            this.CountryNameTextBox.Name = "CountryNameTextBox";
            this.CountryNameTextBox.Size = new System.Drawing.Size(114, 20);
            this.CountryNameTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Country Name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.FigureTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.LineDirectionComboBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.PatternTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ColorsCheckBox);
            this.panel1.Controls.Add(this.CountryNameTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 347);
            this.panel1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(74, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 40);
            this.button3.TabIndex = 14;
            this.button3.Text = "Ok";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 41);
            this.button2.TabIndex = 13;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FigureTextBox
            // 
            this.FigureTextBox.Location = new System.Drawing.Point(4, 267);
            this.FigureTextBox.Name = "FigureTextBox";
            this.FigureTextBox.Size = new System.Drawing.Size(114, 20);
            this.FigureTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Figure:";
            // 
            // LineDirectionComboBox
            // 
            this.LineDirectionComboBox.FormattingEnabled = true;
            this.LineDirectionComboBox.Items.AddRange(new object[] {
            "",
            "Horizontal",
            "Vertical",
            "Oblique",
            "Wavy"});
            this.LineDirectionComboBox.Location = new System.Drawing.Point(4, 217);
            this.LineDirectionComboBox.Name = "LineDirectionComboBox";
            this.LineDirectionComboBox.Size = new System.Drawing.Size(114, 21);
            this.LineDirectionComboBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Line direction:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.panel2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(168, 379);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(160, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Filters";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TraningResiltLabel);
            this.panel2.Controls.Add(this.TraningFaultLabel);
            this.panel2.Controls.Add(this.TraningRightLabel);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.TraningTextBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(4, 22);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(160, 353);
            this.panel2.TabIndex = 2;
            this.panel2.Text = "Training";
            this.panel2.UseVisualStyleBackColor = true;
            // 
            // TraningFaultLabel
            // 
            this.TraningFaultLabel.AutoSize = true;
            this.TraningFaultLabel.Location = new System.Drawing.Point(9, 56);
            this.TraningFaultLabel.Name = "TraningFaultLabel";
            this.TraningFaultLabel.Size = new System.Drawing.Size(36, 13);
            this.TraningFaultLabel.TabIndex = 4;
            this.TraningFaultLabel.Text = "Fault: ";
            // 
            // TraningRightLabel
            // 
            this.TraningRightLabel.AutoSize = true;
            this.TraningRightLabel.Location = new System.Drawing.Point(9, 34);
            this.TraningRightLabel.Name = "TraningRightLabel";
            this.TraningRightLabel.Size = new System.Drawing.Size(42, 13);
            this.TraningRightLabel.TabIndex = 3;
            this.TraningRightLabel.Text = "Rightly:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TraningTextBox
            // 
            this.TraningTextBox.Location = new System.Drawing.Point(11, 72);
            this.TraningTextBox.Name = "TraningTextBox";
            this.TraningTextBox.Size = new System.Drawing.Size(102, 20);
            this.TraningTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name of the country?";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(170, 352);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(244, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add country";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // TraningResiltLabel
            // 
            this.TraningResiltLabel.AutoSize = true;
            this.TraningResiltLabel.Location = new System.Drawing.Point(56, 104);
            this.TraningResiltLabel.Name = "TraningResiltLabel";
            this.TraningResiltLabel.Size = new System.Drawing.Size(0, 13);
            this.TraningResiltLabel.TabIndex = 5;
            this.TraningResiltLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 379);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(434, 418);
            this.MinimumSize = new System.Drawing.Size(434, 418);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flags of the countries";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox PatternTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox ColorsCheckBox;
        private System.Windows.Forms.TextBox CountryNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox FigureTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox LineDirectionComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridViewImageColumn Flag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.TabPage panel2;
        private System.Windows.Forms.Label TraningFaultLabel;
        private System.Windows.Forms.Label TraningRightLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TraningTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TraningResiltLabel;
    }
}

