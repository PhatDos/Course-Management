namespace Day02
{
    partial class EditForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox_Description = new System.Windows.Forms.RichTextBox();
            this.textBox_Lable = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Edit = new System.Windows.Forms.Button();
            this.comboBox_Course = new System.Windows.Forms.ComboBox();
            this.numericUpDown_Period = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Period)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(32, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Description:";
            // 
            // richTextBox_Description
            // 
            this.richTextBox_Description.Location = new System.Drawing.Point(204, 268);
            this.richTextBox_Description.Name = "richTextBox_Description";
            this.richTextBox_Description.Size = new System.Drawing.Size(261, 108);
            this.richTextBox_Description.TabIndex = 28;
            this.richTextBox_Description.Text = "";
            // 
            // textBox_Lable
            // 
            this.textBox_Lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_Lable.Location = new System.Drawing.Point(207, 156);
            this.textBox_Lable.Name = "textBox_Lable";
            this.textBox_Lable.Size = new System.Drawing.Size(261, 26);
            this.textBox_Lable.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(161, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 39);
            this.label4.TabIndex = 24;
            this.label4.Text = "EDIT FORM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(32, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Lable:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(32, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Period:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(32, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Course:";
            // 
            // button_Edit
            // 
            this.button_Edit.BackColor = System.Drawing.Color.Violet;
            this.button_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button_Edit.Location = new System.Drawing.Point(168, 404);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(185, 66);
            this.button_Edit.TabIndex = 20;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = false;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // comboBox_Course
            // 
            this.comboBox_Course.FormattingEnabled = true;
            this.comboBox_Course.Location = new System.Drawing.Point(207, 99);
            this.comboBox_Course.Name = "comboBox_Course";
            this.comboBox_Course.Size = new System.Drawing.Size(261, 30);
            this.comboBox_Course.TabIndex = 30;
            this.comboBox_Course.SelectedIndexChanged += new System.EventHandler(this.comboBox_Course_SelectedIndexChanged);
            // 
            // numericUpDown_Period
            // 
            this.numericUpDown_Period.Location = new System.Drawing.Point(204, 212);
            this.numericUpDown_Period.Name = "numericUpDown_Period";
            this.numericUpDown_Period.Size = new System.Drawing.Size(120, 28);
            this.numericUpDown_Period.TabIndex = 31;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(511, 494);
            this.Controls.Add(this.numericUpDown_Period);
            this.Controls.Add(this.comboBox_Course);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox_Description);
            this.Controls.Add(this.textBox_Lable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Edit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditForm";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Period)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox_Description;
        public System.Windows.Forms.TextBox textBox_Lable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.ComboBox comboBox_Course;
        private System.Windows.Forms.NumericUpDown numericUpDown_Period;
    }
}