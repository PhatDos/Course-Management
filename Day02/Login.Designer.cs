namespace Day02
{
    partial class Login
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
            this.lb_LOGIN = new System.Windows.Forms.Label();
            this.lb_Username = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.bt_Login = new System.Windows.Forms.Button();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_Register = new System.Windows.Forms.Button();
            this.button_ForgetPassword = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_LOGIN
            // 
            this.lb_LOGIN.AutoSize = true;
            this.lb_LOGIN.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lb_LOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lb_LOGIN.Location = new System.Drawing.Point(185, 48);
            this.lb_LOGIN.Name = "lb_LOGIN";
            this.lb_LOGIN.Size = new System.Drawing.Size(89, 29);
            this.lb_LOGIN.TabIndex = 0;
            this.lb_LOGIN.Text = "LOGIN";
            // 
            // lb_Username
            // 
            this.lb_Username.AutoSize = true;
            this.lb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_Username.Location = new System.Drawing.Point(25, 114);
            this.lb_Username.Name = "lb_Username";
            this.lb_Username.Size = new System.Drawing.Size(96, 20);
            this.lb_Username.TabIndex = 1;
            this.lb_Username.Text = "Username: ";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_Password.Location = new System.Drawing.Point(25, 174);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(88, 20);
            this.lb_Password.TabIndex = 2;
            this.lb_Password.Text = "Password:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(44, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 80);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBoxUsername.Location = new System.Drawing.Point(148, 112);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(192, 26);
            this.TextBoxUsername.TabIndex = 4;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBoxPassword.Location = new System.Drawing.Point(148, 171);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(192, 26);
            this.TextBoxPassword.TabIndex = 5;
            this.TextBoxPassword.UseSystemPasswordChar = true;
            // 
            // bt_Login
            // 
            this.bt_Login.BackColor = System.Drawing.Color.Red;
            this.bt_Login.Location = new System.Drawing.Point(21, 276);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(100, 38);
            this.bt_Login.TabIndex = 6;
            this.bt_Login.Text = "Login";
            this.bt_Login.UseVisualStyleBackColor = false;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Cancel.Location = new System.Drawing.Point(139, 330);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(97, 33);
            this.bt_Cancel.TabIndex = 7;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.UseVisualStyleBackColor = false;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // bt_Register
            // 
            this.bt_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_Register.Location = new System.Drawing.Point(139, 276);
            this.bt_Register.Name = "bt_Register";
            this.bt_Register.Size = new System.Drawing.Size(97, 42);
            this.bt_Register.TabIndex = 8;
            this.bt_Register.Text = "Register";
            this.bt_Register.UseVisualStyleBackColor = false;
            this.bt_Register.Click += new System.EventHandler(this.bt_Register_Click);
            // 
            // button_ForgetPassword
            // 
            this.button_ForgetPassword.BackColor = System.Drawing.Color.Lime;
            this.button_ForgetPassword.Location = new System.Drawing.Point(262, 276);
            this.button_ForgetPassword.Name = "button_ForgetPassword";
            this.button_ForgetPassword.Size = new System.Drawing.Size(97, 42);
            this.button_ForgetPassword.TabIndex = 9;
            this.button_ForgetPassword.Text = "Forget password";
            this.button_ForgetPassword.UseVisualStyleBackColor = false;
            this.button_ForgetPassword.Click += new System.EventHandler(this.button_ForgetPassword_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButton1.Location = new System.Drawing.Point(161, 206);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(148, 24);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Show password";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(371, 375);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button_ForgetPassword);
            this.Controls.Add(this.bt_Register);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_Login);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_Username);
            this.Controls.Add(this.lb_LOGIN);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_LOGIN;
        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_Register;
        private System.Windows.Forms.Button button_ForgetPassword;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}