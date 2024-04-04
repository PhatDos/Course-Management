using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Day02
{
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }
        private void label5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Veriffy_Click(object sender, EventArgs e)
        {
            string password = textBox_NewPass.Text;
            string password1 = textBox_ConfirmPass.Text;

            if (password.Length != password1.Length)
            {
                MessageBox.Show("Two passwords are NOT the same!", "Error");
                return;
            }
            if (password.Length < 8)
            {
                MessageBox.Show("Email, Password and Username must have at least 8 letters!", "Error");
                return;
            }
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] != password1[i])
                {
                    MessageBox.Show("Two passwords are NOT the same!", "Error");
                    return;
                }
            }

            if (String.Compare(textBox_UserName.Text, ForgetPass.UserName1, true) != 0 || String.Compare(textBox_Email.Text, ForgetPass.Email1, true) != 0)
            {
                MessageBox.Show("Username or email have been changed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Add

            MY_DB mydb = new MY_DB();

            SqlCommand command = new SqlCommand("UPDATE login SET password = @password " +
                "WHERE username = @username", mydb.getConnection());
            command.Parameters.Add("@username", SqlDbType.NChar).Value = ForgetPass.UserName1;
            command.Parameters.Add("@password", SqlDbType.NChar).Value = password;

            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
            }
            else
            {
                mydb.closeConnection();
            }
            MessageBox.Show("Change password successfully", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {
            textBox_UserName.Text = ForgetPass.UserName1;
            textBox_Email.Text = ForgetPass.Email1;
        }

        private void textBox_Email_TextChanged(object sender, EventArgs e)
        {
            errorProvider1 = new ErrorProvider();
            errorProvider1.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;

            errorProvider1.SetError(textBox_Email, "This email can not change");
            errorProvider1.SetError(textBox_UserName, "This Username can not change");

            this.Controls.Add(textBox_Email);
            this.Controls.Add(textBox_UserName);
        }
    }
}
