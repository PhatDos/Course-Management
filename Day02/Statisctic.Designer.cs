namespace Day02
{
    partial class Statisctic
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
            this.panelMale = new System.Windows.Forms.Panel();
            this.label_Male = new System.Windows.Forms.Label();
            this.panelFemale = new System.Windows.Forms.Panel();
            this.label_Female = new System.Windows.Forms.Label();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.label_Total = new System.Windows.Forms.Label();
            this.panelMale.SuspendLayout();
            this.panelFemale.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMale
            // 
            this.panelMale.BackColor = System.Drawing.Color.Lime;
            this.panelMale.Controls.Add(this.label_Male);
            this.panelMale.Location = new System.Drawing.Point(6, 5);
            this.panelMale.Name = "panelMale";
            this.panelMale.Size = new System.Drawing.Size(375, 180);
            this.panelMale.TabIndex = 0;
            // 
            // label_Male
            // 
            this.label_Male.AutoSize = true;
            this.label_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label_Male.Location = new System.Drawing.Point(31, 62);
            this.label_Male.Name = "label_Male";
            this.label_Male.Size = new System.Drawing.Size(79, 36);
            this.label_Male.TabIndex = 0;
            this.label_Male.Text = "Male";
            // 
            // panelFemale
            // 
            this.panelFemale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelFemale.Controls.Add(this.label_Female);
            this.panelFemale.Location = new System.Drawing.Point(5, 190);
            this.panelFemale.Name = "panelFemale";
            this.panelFemale.Size = new System.Drawing.Size(375, 180);
            this.panelFemale.TabIndex = 1;
            // 
            // label_Female
            // 
            this.label_Female.AutoSize = true;
            this.label_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label_Female.Location = new System.Drawing.Point(32, 75);
            this.label_Female.Name = "label_Female";
            this.label_Female.Size = new System.Drawing.Size(79, 36);
            this.label_Female.TabIndex = 1;
            this.label_Female.Text = "Male";
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelTotal.Controls.Add(this.label_Total);
            this.panelTotal.Location = new System.Drawing.Point(4, 375);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(750, 180);
            this.panelTotal.TabIndex = 1;
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label_Total.Location = new System.Drawing.Point(226, 80);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(79, 36);
            this.label_Total.TabIndex = 2;
            this.label_Total.Text = "Male";
            // 
            // Statisctic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 573);
            this.Controls.Add(this.panelFemale);
            this.Controls.Add(this.panelTotal);
            this.Controls.Add(this.panelMale);
            this.Name = "Statisctic";
            this.Text = "Statistic Form";
            this.Load += new System.EventHandler(this.Statisctic_Load);
            this.panelMale.ResumeLayout(false);
            this.panelMale.PerformLayout();
            this.panelFemale.ResumeLayout(false);
            this.panelFemale.PerformLayout();
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMale;
        private System.Windows.Forms.Panel panelFemale;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label label_Male;
        private System.Windows.Forms.Label label_Female;
        private System.Windows.Forms.Label label_Total;
    }
}