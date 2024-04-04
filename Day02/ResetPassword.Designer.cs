namespace Day02
{
    partial class ResetPassword
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
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_NewPass = new System.Windows.Forms.TextBox();
            this.textBox_ConfirmPass = new System.Windows.Forms.TextBox();
            this.button_Veriffy = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(100, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "RESET PASSWORD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(33, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "New password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(33, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Confirm password:";
            // 
            // textBox_NewPass
            // 
            this.textBox_NewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_NewPass.Location = new System.Drawing.Point(230, 196);
            this.textBox_NewPass.Name = "textBox_NewPass";
            this.textBox_NewPass.Size = new System.Drawing.Size(261, 26);
            this.textBox_NewPass.TabIndex = 11;
            // 
            // textBox_ConfirmPass
            // 
            this.textBox_ConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_ConfirmPass.Location = new System.Drawing.Point(230, 254);
            this.textBox_ConfirmPass.Name = "textBox_ConfirmPass";
            this.textBox_ConfirmPass.Size = new System.Drawing.Size(261, 26);
            this.textBox_ConfirmPass.TabIndex = 12;
            // 
            // button_Veriffy
            // 
            this.button_Veriffy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_Veriffy.Location = new System.Drawing.Point(182, 309);
            this.button_Veriffy.Name = "button_Veriffy";
            this.button_Veriffy.Size = new System.Drawing.Size(191, 42);
            this.button_Veriffy.TabIndex = 13;
            this.button_Veriffy.Text = "Reset password";
            this.button_Veriffy.UseVisualStyleBackColor = true;
            this.button_Veriffy.Click += new System.EventHandler(this.button_Veriffy_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Back";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_UserName.Location = new System.Drawing.Point(230, 141);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(261, 26);
            this.textBox_UserName.TabIndex = 15;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox_Email.Location = new System.Drawing.Point(230, 87);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(261, 26);
            this.textBox_Email.TabIndex = 16;
            this.textBox_Email.TextChanged += new System.EventHandler(this.textBox_Email_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(33, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Username:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(33, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Email:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 378);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_Veriffy);
            this.Controls.Add(this.textBox_ConfirmPass);
            this.Controls.Add(this.textBox_NewPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "ResetPassword";
            this.Text = "Reset Password";
            this.Load += new System.EventHandler(this.ResetPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_NewPass;
        private System.Windows.Forms.TextBox textBox_ConfirmPass;
        private System.Windows.Forms.Button button_Veriffy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}