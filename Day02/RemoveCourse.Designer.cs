namespace Day02
{
    partial class RemoveCourse
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_CourseID = new System.Windows.Forms.TextBox();
            this.button_RemoveCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lime;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(92, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 39);
            this.label4.TabIndex = 12;
            this.label4.Text = "DELETE COURSE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(27, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Input Course ID:";
            // 
            // textBox_CourseID
            // 
            this.textBox_CourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_CourseID.Location = new System.Drawing.Point(202, 99);
            this.textBox_CourseID.Name = "textBox_CourseID";
            this.textBox_CourseID.Size = new System.Drawing.Size(246, 26);
            this.textBox_CourseID.TabIndex = 18;
            // 
            // button_RemoveCourse
            // 
            this.button_RemoveCourse.BackColor = System.Drawing.Color.MediumPurple;
            this.button_RemoveCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_RemoveCourse.Location = new System.Drawing.Point(151, 150);
            this.button_RemoveCourse.Name = "button_RemoveCourse";
            this.button_RemoveCourse.Size = new System.Drawing.Size(178, 55);
            this.button_RemoveCourse.TabIndex = 19;
            this.button_RemoveCourse.Text = "DELETE";
            this.button_RemoveCourse.UseVisualStyleBackColor = false;
            this.button_RemoveCourse.Click += new System.EventHandler(this.button_RemoveCourse_Click);
            // 
            // RemoveCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(477, 217);
            this.Controls.Add(this.button_RemoveCourse);
            this.Controls.Add(this.textBox_CourseID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RemoveCourse";
            this.Text = "Delete Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox_CourseID;
        private System.Windows.Forms.Button button_RemoveCourse;
    }
}