namespace Day02
{
    partial class AddCourseForm
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
            this.button_AddCourse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Lable = new System.Windows.Forms.TextBox();
            this.textBox_Period = new System.Windows.Forms.TextBox();
            this.textBox_CourseID = new System.Windows.Forms.TextBox();
            this.richTextBox_Description = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_AddCourse
            // 
            this.button_AddCourse.BackColor = System.Drawing.Color.Violet;
            this.button_AddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_AddCourse.Location = new System.Drawing.Point(145, 401);
            this.button_AddCourse.Name = "button_AddCourse";
            this.button_AddCourse.Size = new System.Drawing.Size(226, 66);
            this.button_AddCourse.TabIndex = 7;
            this.button_AddCourse.Text = "Add Course";
            this.button_AddCourse.UseVisualStyleBackColor = false;
            this.button_AddCourse.Click += new System.EventHandler(this.button_AddCourse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(34, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Course ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(34, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Period:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(34, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lable:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(152, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 39);
            this.label4.TabIndex = 11;
            this.label4.Text = "ADD COURSE";
            // 
            // textBox_Lable
            // 
            this.textBox_Lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_Lable.Location = new System.Drawing.Point(218, 155);
            this.textBox_Lable.Name = "textBox_Lable";
            this.textBox_Lable.Size = new System.Drawing.Size(261, 26);
            this.textBox_Lable.TabIndex = 12;
            // 
            // textBox_Period
            // 
            this.textBox_Period.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_Period.Location = new System.Drawing.Point(218, 212);
            this.textBox_Period.Name = "textBox_Period";
            this.textBox_Period.Size = new System.Drawing.Size(261, 26);
            this.textBox_Period.TabIndex = 13;
            // 
            // textBox_CourseID
            // 
            this.textBox_CourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_CourseID.Location = new System.Drawing.Point(218, 102);
            this.textBox_CourseID.Name = "textBox_CourseID";
            this.textBox_CourseID.Size = new System.Drawing.Size(261, 26);
            this.textBox_CourseID.TabIndex = 17;
            // 
            // richTextBox_Description
            // 
            this.richTextBox_Description.Location = new System.Drawing.Point(218, 266);
            this.richTextBox_Description.Name = "richTextBox_Description";
            this.richTextBox_Description.Size = new System.Drawing.Size(261, 108);
            this.richTextBox_Description.TabIndex = 18;
            this.richTextBox_Description.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(34, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Description:";
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(515, 486);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox_Description);
            this.Controls.Add(this.textBox_CourseID);
            this.Controls.Add(this.textBox_Period);
            this.Controls.Add(this.textBox_Lable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_AddCourse);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddCourseForm";
            this.Text = "Add Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_AddCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox_Lable;
        public System.Windows.Forms.TextBox textBox_Period;
        public System.Windows.Forms.TextBox textBox_CourseID;
        private System.Windows.Forms.RichTextBox richTextBox_Description;
        private System.Windows.Forms.Label label5;
    }
}