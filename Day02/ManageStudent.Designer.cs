namespace Day02
{
    partial class ManageStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_DownloadPic = new System.Windows.Forms.Button();
            this.bt_Find = new System.Windows.Forms.Button();
            this.bt_Remove = new System.Windows.Forms.Button();
            this.bt_Edit = new System.Windows.Forms.Button();
            this.ButtonUploadImage = new System.Windows.Forms.Button();
            this.PictureBoxStudentImage = new System.Windows.Forms.PictureBox();
            this.TextBoxAddress = new System.Windows.Forms.RichTextBox();
            this.TextBoxPhone = new System.Windows.Forms.TextBox();
            this.RadioButtonFemale = new System.Windows.Forms.RadioButton();
            this.RadioButtonMale = new System.Windows.Forms.RadioButton();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TextBoxLname = new System.Windows.Forms.TextBox();
            this.TextBoxFname = new System.Windows.Forms.TextBox();
            this.TextBoxStudentID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1_Add = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_Total = new System.Windows.Forms.Label();
            this.textBox_Find = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStudentImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_DownloadPic
            // 
            this.button_DownloadPic.Location = new System.Drawing.Point(242, 611);
            this.button_DownloadPic.Name = "button_DownloadPic";
            this.button_DownloadPic.Size = new System.Drawing.Size(86, 34);
            this.button_DownloadPic.TabIndex = 46;
            this.button_DownloadPic.Text = "Download";
            this.button_DownloadPic.UseVisualStyleBackColor = true;
            this.button_DownloadPic.Click += new System.EventHandler(this.button_DownloadPic_Click);
            // 
            // bt_Find
            // 
            this.bt_Find.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_Find.Location = new System.Drawing.Point(1296, 27);
            this.bt_Find.Name = "bt_Find";
            this.bt_Find.Size = new System.Drawing.Size(113, 31);
            this.bt_Find.TabIndex = 45;
            this.bt_Find.Text = "Find";
            this.bt_Find.UseVisualStyleBackColor = false;
            this.bt_Find.Click += new System.EventHandler(this.bt_Find_Click);
            // 
            // bt_Remove
            // 
            this.bt_Remove.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_Remove.Location = new System.Drawing.Point(361, 673);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(125, 41);
            this.bt_Remove.TabIndex = 44;
            this.bt_Remove.Text = "Remove";
            this.bt_Remove.UseVisualStyleBackColor = false;
            this.bt_Remove.Click += new System.EventHandler(this.bt_Remove_Click);
            // 
            // bt_Edit
            // 
            this.bt_Edit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_Edit.Location = new System.Drawing.Point(191, 673);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Size = new System.Drawing.Size(125, 41);
            this.bt_Edit.TabIndex = 43;
            this.bt_Edit.Text = "Edit";
            this.bt_Edit.UseVisualStyleBackColor = false;
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            // 
            // ButtonUploadImage
            // 
            this.ButtonUploadImage.Location = new System.Drawing.Point(139, 611);
            this.ButtonUploadImage.Name = "ButtonUploadImage";
            this.ButtonUploadImage.Size = new System.Drawing.Size(86, 34);
            this.ButtonUploadImage.TabIndex = 42;
            this.ButtonUploadImage.Text = "Upload";
            this.ButtonUploadImage.UseVisualStyleBackColor = true;
            this.ButtonUploadImage.Click += new System.EventHandler(this.ButtonUploadImage_Click);
            // 
            // PictureBoxStudentImage
            // 
            this.PictureBoxStudentImage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PictureBoxStudentImage.Location = new System.Drawing.Point(127, 496);
            this.PictureBoxStudentImage.Name = "PictureBoxStudentImage";
            this.PictureBoxStudentImage.Size = new System.Drawing.Size(224, 109);
            this.PictureBoxStudentImage.TabIndex = 41;
            this.PictureBoxStudentImage.TabStop = false;
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Location = new System.Drawing.Point(127, 356);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(227, 97);
            this.TextBoxAddress.TabIndex = 40;
            this.TextBoxAddress.Text = "";
            // 
            // TextBoxPhone
            // 
            this.TextBoxPhone.Location = new System.Drawing.Point(127, 295);
            this.TextBoxPhone.Name = "TextBoxPhone";
            this.TextBoxPhone.Size = new System.Drawing.Size(224, 22);
            this.TextBoxPhone.TabIndex = 39;
            // 
            // RadioButtonFemale
            // 
            this.RadioButtonFemale.AutoSize = true;
            this.RadioButtonFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.2F);
            this.RadioButtonFemale.Location = new System.Drawing.Point(242, 241);
            this.RadioButtonFemale.Name = "RadioButtonFemale";
            this.RadioButtonFemale.Size = new System.Drawing.Size(95, 28);
            this.RadioButtonFemale.TabIndex = 38;
            this.RadioButtonFemale.TabStop = true;
            this.RadioButtonFemale.Text = "Female";
            this.RadioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // RadioButtonMale
            // 
            this.RadioButtonMale.AutoSize = true;
            this.RadioButtonMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.RadioButtonMale.Location = new System.Drawing.Point(127, 241);
            this.RadioButtonMale.Name = "RadioButtonMale";
            this.RadioButtonMale.Size = new System.Drawing.Size(72, 28);
            this.RadioButtonMale.TabIndex = 37;
            this.RadioButtonMale.TabStop = true;
            this.RadioButtonMale.Text = "Male";
            this.RadioButtonMale.UseVisualStyleBackColor = true;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Location = new System.Drawing.Point(127, 189);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(224, 22);
            this.DateTimePicker1.TabIndex = 36;
            // 
            // TextBoxLname
            // 
            this.TextBoxLname.Location = new System.Drawing.Point(127, 130);
            this.TextBoxLname.Name = "TextBoxLname";
            this.TextBoxLname.Size = new System.Drawing.Size(224, 22);
            this.TextBoxLname.TabIndex = 35;
            // 
            // TextBoxFname
            // 
            this.TextBoxFname.Location = new System.Drawing.Point(127, 78);
            this.TextBoxFname.Name = "TextBoxFname";
            this.TextBoxFname.Size = new System.Drawing.Size(224, 22);
            this.TextBoxFname.TabIndex = 34;
            // 
            // TextBoxStudentID
            // 
            this.TextBoxStudentID.Location = new System.Drawing.Point(127, 26);
            this.TextBoxStudentID.Name = "TextBoxStudentID";
            this.TextBoxStudentID.Size = new System.Drawing.Size(224, 22);
            this.TextBoxStudentID.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(28, 496);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Picture";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(28, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(28, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(28, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(28, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "BirthDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(28, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(28, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Student ID";
            // 
            // button1_Add
            // 
            this.button1_Add.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1_Add.Location = new System.Drawing.Point(31, 673);
            this.button1_Add.Name = "button1_Add";
            this.button1_Add.Size = new System.Drawing.Size(125, 41);
            this.button1_Add.TabIndex = 47;
            this.button1_Add.Text = "Add";
            this.button1_Add.UseVisualStyleBackColor = false;
            this.button1_Add.Click += new System.EventHandler(this.button1_Add_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_Reset.Location = new System.Drawing.Point(531, 673);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(125, 41);
            this.button_Reset.TabIndex = 48;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = false;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(389, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1112, 567);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.BackColor = System.Drawing.Color.Fuchsia;
            this.label_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label_Total.Location = new System.Drawing.Point(1122, 673);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(76, 29);
            this.label_Total.TabIndex = 50;
            this.label_Total.Text = "Total:";
            // 
            // textBox_Find
            // 
            this.textBox_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_Find.Location = new System.Drawing.Point(1055, 29);
            this.textBox_Find.Name = "textBox_Find";
            this.textBox_Find.Size = new System.Drawing.Size(224, 26);
            this.textBox_Find.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(878, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 25);
            this.label9.TabIndex = 52;
            this.label9.Text = "Input what to find";
            // 
            // button_Refresh
            // 
            this.button_Refresh.BackColor = System.Drawing.Color.Yellow;
            this.button_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_Refresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Refresh.Location = new System.Drawing.Point(869, 671);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(125, 41);
            this.button_Refresh.TabIndex = 53;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = false;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // ManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1531, 737);
            this.Controls.Add(this.button_Refresh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_Find);
            this.Controls.Add(this.label_Total);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button1_Add);
            this.Controls.Add(this.button_DownloadPic);
            this.Controls.Add(this.bt_Find);
            this.Controls.Add(this.bt_Remove);
            this.Controls.Add(this.bt_Edit);
            this.Controls.Add(this.ButtonUploadImage);
            this.Controls.Add(this.PictureBoxStudentImage);
            this.Controls.Add(this.TextBoxAddress);
            this.Controls.Add(this.TextBoxPhone);
            this.Controls.Add(this.RadioButtonFemale);
            this.Controls.Add(this.RadioButtonMale);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.TextBoxLname);
            this.Controls.Add(this.TextBoxFname);
            this.Controls.Add(this.TextBoxStudentID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageStudent";
            this.Text = "Manage Student Form";
            this.Load += new System.EventHandler(this.ManageStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStudentImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_DownloadPic;
        private System.Windows.Forms.Button bt_Find;
        private System.Windows.Forms.Button bt_Remove;
        private System.Windows.Forms.Button bt_Edit;
        private System.Windows.Forms.Button ButtonUploadImage;
        public System.Windows.Forms.PictureBox PictureBoxStudentImage;
        public System.Windows.Forms.RichTextBox TextBoxAddress;
        public System.Windows.Forms.TextBox TextBoxPhone;
        public System.Windows.Forms.RadioButton RadioButtonFemale;
        public System.Windows.Forms.RadioButton RadioButtonMale;
        public System.Windows.Forms.DateTimePicker DateTimePicker1;
        public System.Windows.Forms.TextBox TextBoxLname;
        public System.Windows.Forms.TextBox TextBoxFname;
        public System.Windows.Forms.TextBox TextBoxStudentID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1_Add;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_Total;
        public System.Windows.Forms.TextBox textBox_Find;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_Refresh;
    }
}