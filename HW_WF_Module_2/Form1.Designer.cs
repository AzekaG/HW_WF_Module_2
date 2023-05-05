namespace HW_WF_Module_2
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
            this.InfoLabel = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.comboBoxHumans = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurName = new System.Windows.Forms.TextBox();
            this.textBoxFatherName = new System.Windows.Forms.TextBox();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.comboBoxFamilyStatus = new System.Windows.Forms.ComboBox();
            this.textBoxOtherInfo = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurName = new System.Windows.Forms.Label();
            this.labelFatherName = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelFamilyStatus = new System.Windows.Forms.Label();
            this.labelOtherInfo = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.InfoLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.InfoLabel.Location = new System.Drawing.Point(156, 46);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(296, 170);
            this.InfoLabel.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(361, 527);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(91, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(361, 559);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(91, 23);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // comboBoxHumans
            // 
            this.comboBoxHumans.FormattingEnabled = true;
            this.comboBoxHumans.Location = new System.Drawing.Point(12, 46);
            this.comboBoxHumans.Name = "comboBoxHumans";
            this.comboBoxHumans.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHumans.TabIndex = 5;
            this.comboBoxHumans.SelectedIndexChanged += new System.EventHandler(this.comboBoxHumans_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(159, 275);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(293, 20);
            this.textBoxName.TabIndex = 6;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxSurName
            // 
            this.textBoxSurName.Location = new System.Drawing.Point(159, 301);
            this.textBoxSurName.Name = "textBoxSurName";
            this.textBoxSurName.Size = new System.Drawing.Size(293, 20);
            this.textBoxSurName.TabIndex = 7;
            this.textBoxSurName.TextChanged += new System.EventHandler(this.textBoxSurName_TextChanged);
            // 
            // textBoxFatherName
            // 
            this.textBoxFatherName.Location = new System.Drawing.Point(159, 327);
            this.textBoxFatherName.Name = "textBoxFatherName";
            this.textBoxFatherName.Size = new System.Drawing.Size(293, 20);
            this.textBoxFatherName.TabIndex = 8;
            this.textBoxFatherName.TextChanged += new System.EventHandler(this.textBoxFatherName_TextChanged);
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Location = new System.Drawing.Point(159, 353);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSex.TabIndex = 9;
            this.comboBoxSex.SelectedIndexChanged += new System.EventHandler(this.comboBoxSex_SelectedIndexChanged);
            // 
            // comboBoxFamilyStatus
            // 
            this.comboBoxFamilyStatus.FormattingEnabled = true;
            this.comboBoxFamilyStatus.Location = new System.Drawing.Point(159, 407);
            this.comboBoxFamilyStatus.Name = "comboBoxFamilyStatus";
            this.comboBoxFamilyStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFamilyStatus.TabIndex = 13;
            this.comboBoxFamilyStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxFamilyStatus_SelectedIndexChanged);
            // 
            // textBoxOtherInfo
            // 
            this.textBoxOtherInfo.Location = new System.Drawing.Point(159, 435);
            this.textBoxOtherInfo.Name = "textBoxOtherInfo";
            this.textBoxOtherInfo.Size = new System.Drawing.Size(100, 20);
            this.textBoxOtherInfo.TabIndex = 14;
            this.textBoxOtherInfo.TextChanged += new System.EventHandler(this.textBoxOtherInfo_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 275);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 15;
            this.labelName.Text = "Name";
            // 
            // labelSurName
            // 
            this.labelSurName.AutoSize = true;
            this.labelSurName.Location = new System.Drawing.Point(13, 301);
            this.labelSurName.Name = "labelSurName";
            this.labelSurName.Size = new System.Drawing.Size(51, 13);
            this.labelSurName.TabIndex = 16;
            this.labelSurName.Text = "SurName";
            // 
            // labelFatherName
            // 
            this.labelFatherName.AutoSize = true;
            this.labelFatherName.Location = new System.Drawing.Point(13, 330);
            this.labelFatherName.Name = "labelFatherName";
            this.labelFatherName.Size = new System.Drawing.Size(68, 13);
            this.labelFatherName.TabIndex = 17;
            this.labelFatherName.Text = "Father Name";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(13, 353);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(25, 13);
            this.labelSex.TabIndex = 18;
            this.labelSex.Text = "Sex";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(13, 386);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(94, 13);
            this.labelDate.TabIndex = 19;
            this.labelDate.Text = "Birthday (d,m,year)";
            // 
            // labelFamilyStatus
            // 
            this.labelFamilyStatus.AutoSize = true;
            this.labelFamilyStatus.Location = new System.Drawing.Point(13, 415);
            this.labelFamilyStatus.Name = "labelFamilyStatus";
            this.labelFamilyStatus.Size = new System.Drawing.Size(69, 13);
            this.labelFamilyStatus.TabIndex = 20;
            this.labelFamilyStatus.Text = "Family Status";
            // 
            // labelOtherInfo
            // 
            this.labelOtherInfo.AutoSize = true;
            this.labelOtherInfo.Location = new System.Drawing.Point(13, 442);
            this.labelOtherInfo.Name = "labelOtherInfo";
            this.labelOtherInfo.Size = new System.Drawing.Size(63, 13);
            this.labelOtherInfo.TabIndex = 21;
            this.labelOtherInfo.Text = "Other Info : ";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(16, 479);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(436, 23);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 381);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 23;
            this.dateTimePicker1.Value = new System.DateTime(2023, 4, 29, 4, 25, 33, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 527);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 527);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Enter a name to saving (path.xml)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 562);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Enter a name for downloading ( path.xml )";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(218, 562);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 681);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelOtherInfo);
            this.Controls.Add(this.labelFamilyStatus);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.labelFatherName);
            this.Controls.Add(this.labelSurName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxOtherInfo);
            this.Controls.Add(this.comboBoxFamilyStatus);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.textBoxFatherName);
            this.Controls.Add(this.textBoxSurName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.comboBoxHumans);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.InfoLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.ComboBox comboBoxHumans;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurName;
        private System.Windows.Forms.TextBox textBoxFatherName;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.ComboBox comboBoxFamilyStatus;
        private System.Windows.Forms.TextBox textBoxOtherInfo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurName;
        private System.Windows.Forms.Label labelFatherName;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelFamilyStatus;
        private System.Windows.Forms.Label labelOtherInfo;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}

