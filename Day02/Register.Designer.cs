namespace Day02
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.lb_Username = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.lb_ConfirmPassword = new System.Windows.Forms.Label();
            this.lb_REGISTER = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_Register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Code = new System.Windows.Forms.TextBox();
            this.textBox_Gmail = new System.Windows.Forms.TextBox();
            this.button_SendCode = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Username
            // 
            this.lb_Username.AutoSize = true;
            this.lb_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_Username.Location = new System.Drawing.Point(25, 214);
            this.lb_Username.Name = "lb_Username";
            this.lb_Username.Size = new System.Drawing.Size(108, 25);
            this.lb_Username.TabIndex = 0;
            this.lb_Username.Text = "Username:";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.BackColor = System.Drawing.Color.LightGray;
            this.lb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_Password.Location = new System.Drawing.Point(25, 280);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(104, 25);
            this.lb_Password.TabIndex = 1;
            this.lb_Password.Text = "Password:";
            // 
            // lb_ConfirmPassword
            // 
            this.lb_ConfirmPassword.AutoSize = true;
            this.lb_ConfirmPassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lb_ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lb_ConfirmPassword.Location = new System.Drawing.Point(26, 345);
            this.lb_ConfirmPassword.Name = "lb_ConfirmPassword";
            this.lb_ConfirmPassword.Size = new System.Drawing.Size(167, 24);
            this.lb_ConfirmPassword.TabIndex = 2;
            this.lb_ConfirmPassword.Text = "Confirm Password:";
            // 
            // lb_REGISTER
            // 
            this.lb_REGISTER.AutoSize = true;
            this.lb_REGISTER.BackColor = System.Drawing.Color.Red;
            this.lb_REGISTER.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lb_REGISTER.Location = new System.Drawing.Point(170, 18);
            this.lb_REGISTER.Name = "lb_REGISTER";
            this.lb_REGISTER.Size = new System.Drawing.Size(168, 36);
            this.lb_REGISTER.TabIndex = 3;
            this.lb_REGISTER.Text = "REGISTER";
            // 
            // tb_Username
            // 
            this.tb_Username.Location = new System.Drawing.Point(233, 214);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(259, 22);
            this.tb_Username.TabIndex = 4;
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(233, 280);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(259, 22);
            this.tb_Password.TabIndex = 5;
            // 
            // tb_ConfirmPassword
            // 
            this.tb_ConfirmPassword.Location = new System.Drawing.Point(233, 347);
            this.tb_ConfirmPassword.Name = "tb_ConfirmPassword";
            this.tb_ConfirmPassword.Size = new System.Drawing.Size(259, 22);
            this.tb_ConfirmPassword.TabIndex = 6;
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Location = new System.Drawing.Point(325, 397);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(106, 48);
            this.bt_Cancel.TabIndex = 7;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // bt_Register
            // 
            this.bt_Register.BackColor = System.Drawing.Color.Lime;
            this.bt_Register.Location = new System.Drawing.Point(88, 397);
            this.bt_Register.Name = "bt_Register";
            this.bt_Register.Size = new System.Drawing.Size(109, 48);
            this.bt_Register.TabIndex = 8;
            this.bt_Register.Text = "Register";
            this.bt_Register.UseVisualStyleBackColor = false;
            this.bt_Register.Click += new System.EventHandler(this.bt_Register_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(29, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gmail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(29, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Code:";
            // 
            // textBox_Code
            // 
            this.textBox_Code.Location = new System.Drawing.Point(147, 145);
            this.textBox_Code.Name = "textBox_Code";
            this.textBox_Code.Size = new System.Drawing.Size(259, 22);
            this.textBox_Code.TabIndex = 11;
            // 
            // textBox_Gmail
            // 
            this.textBox_Gmail.Location = new System.Drawing.Point(147, 77);
            this.textBox_Gmail.Name = "textBox_Gmail";
            this.textBox_Gmail.Size = new System.Drawing.Size(259, 22);
            this.textBox_Gmail.TabIndex = 12;
            // 
            // button_SendCode
            // 
            this.button_SendCode.BackColor = System.Drawing.Color.Lime;
            this.button_SendCode.Location = new System.Drawing.Point(425, 73);
            this.button_SendCode.Name = "button_SendCode";
            this.button_SendCode.Size = new System.Drawing.Size(101, 30);
            this.button_SendCode.TabIndex = 13;
            this.button_SendCode.Text = "Send Code";
            this.button_SendCode.UseVisualStyleBackColor = false;
            this.button_SendCode.Click += new System.EventHandler(this.button_SendCode_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(383, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 42);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 478);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_SendCode);
            this.Controls.Add(this.textBox_Gmail);
            this.Controls.Add(this.textBox_Code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Register);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.tb_ConfirmPassword);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.lb_REGISTER);
            this.Controls.Add(this.lb_ConfirmPassword);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_Username);
            this.Name = "Register";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.Label lb_ConfirmPassword;
        private System.Windows.Forms.Label lb_REGISTER;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_ConfirmPassword;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_Register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Code;
        private System.Windows.Forms.TextBox textBox_Gmail;
        private System.Windows.Forms.Button button_SendCode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}