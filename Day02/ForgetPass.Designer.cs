namespace Day02
{
    partial class ForgetPass
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_Veriffy = new System.Windows.Forms.Button();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_Code = new System.Windows.Forms.Label();
            this.textBox_Code = new System.Windows.Forms.TextBox();
            this.button_SendCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Back";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_Veriffy
            // 
            this.button_Veriffy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_Veriffy.Location = new System.Drawing.Point(272, 314);
            this.button_Veriffy.Name = "button_Veriffy";
            this.button_Veriffy.Size = new System.Drawing.Size(95, 42);
            this.button_Veriffy.TabIndex = 2;
            this.button_Veriffy.Text = "Verify";
            this.button_Veriffy.UseVisualStyleBackColor = true;
            this.button_Veriffy.Click += new System.EventHandler(this.button_Veriffy_Click);
            // 
            // textBox_Username
            // 
            this.textBox_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_Username.Location = new System.Drawing.Point(182, 125);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(261, 26);
            this.textBox_Username.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(46, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(46, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(127, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(368, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "FORGET PASSWORD";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_Email.Location = new System.Drawing.Point(182, 193);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(261, 26);
            this.textBox_Email.TabIndex = 7;
            // 
            // label_Code
            // 
            this.label_Code.AutoSize = true;
            this.label_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_Code.Location = new System.Drawing.Point(46, 263);
            this.label_Code.Name = "label_Code";
            this.label_Code.Size = new System.Drawing.Size(71, 25);
            this.label_Code.TabIndex = 8;
            this.label_Code.Text = "Code: ";
            // 
            // textBox_Code
            // 
            this.textBox_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_Code.Location = new System.Drawing.Point(182, 262);
            this.textBox_Code.Name = "textBox_Code";
            this.textBox_Code.Size = new System.Drawing.Size(261, 26);
            this.textBox_Code.TabIndex = 9;
            // 
            // button_SendCode
            // 
            this.button_SendCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_SendCode.Location = new System.Drawing.Point(459, 190);
            this.button_SendCode.Name = "button_SendCode";
            this.button_SendCode.Size = new System.Drawing.Size(139, 33);
            this.button_SendCode.TabIndex = 10;
            this.button_SendCode.Text = "Send Code";
            this.button_SendCode.UseVisualStyleBackColor = true;
            this.button_SendCode.Click += new System.EventHandler(this.button_SendCode_Click);
            // 
            // ForgetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 380);
            this.Controls.Add(this.button_SendCode);
            this.Controls.Add(this.textBox_Code);
            this.Controls.Add(this.label_Code);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.button_Veriffy);
            this.Controls.Add(this.label1);
            this.Name = "ForgetPass";
            this.Text = "Forget Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Veriffy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Code;
        private System.Windows.Forms.TextBox textBox_Code;
        private System.Windows.Forms.Button button_SendCode;
        public System.Windows.Forms.TextBox textBox_Username;
        public System.Windows.Forms.TextBox textBox_Email;
    }
}