using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Day02
{
    public partial class Register : Form
    {
        MY_DB MY_DB = new MY_DB();
        int time = 60;
        string randomCode;
        public static string to;

        public Register()
        {
            InitializeComponent();
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_Register_Click(object sender, EventArgs e)
        {
            string username = tb_Username.Text;
            string password = tb_Password.Text;
            string password1 = tb_ConfirmPassword.Text;
            string email = textBox_Gmail.Text;

            if (password.Length != password1.Length)
            {
                MessageBox.Show("Two passwords are NOT the same!", "Error");
                return;
            }
            if (password.Length < 8 || username.Length < 8 || email.Length < 8)
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
                }                                                              //CHECK
            }
            //Get username and email to check already existed
            MY_DB mydb = new MY_DB();
            SqlCommand command1 = new SqlCommand("Select * FROM login", mydb.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command1);
            DataTable table = new DataTable();
            adapter.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (username.Length == table.Rows[i]["username"].ToString().Length)
                {
                    bool flag = true;
                    string test = table.Rows[i]["username"].ToString();

                    for (int j = 0; j < username.Length; j++)
                    {
                        if (username[j] != test[j])
                        {
                            flag = false;                                //username
                            break;
                        }
                    }
                    if (flag == true)
                    {
                        MessageBox.Show("The username is already existed!", "Error");
                        return;
                    }
                }
            }

            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (email.Length == table.Rows[i]["email"].ToString().Length)
                {
                    bool flag = true;
                    string test = table.Rows[i]["email"].ToString();

                    for (int j = 0; j < email.Length; j++)
                    {
                        if (email[j] != test[j])
                        {
                            flag = false;                                //email
                            break;
                        }
                    }
                    if (flag == true)
                    {
                        MessageBox.Show("The email is already existed!", "Error");
                        return;
                    }
                }
            }

            //ADD

            SqlCommand command = new SqlCommand("INSERT INTO login (username, password, email)" +
               " VALUES (@username, @password, @email)", mydb.getConnection());
            command.Parameters.Add("@username", SqlDbType.NChar).Value = username;
            command.Parameters.Add("@password", SqlDbType.NChar).Value = password;
            command.Parameters.Add("@email", SqlDbType.NChar).Value = email;

            if (CheckCode() == false)
            {
                return;
            }

            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
            }
            else
            {
                mydb.closeConnection();
            }
            MessageBox.Show("Register successed", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
        }

        private void button_SendCode_Click(object sender, EventArgs e)
        {
            if (textBox_Gmail.Text.Trim() == "")
            {
                MessageBox.Show("Enter your email first", "Add account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            textBox_Gmail.Text = AutoEmail(textBox_Gmail.Text);     //set @gmail.com

            string from, pass, messageBody;
            Random random = new Random();
            randomCode = random.Next(99999).ToString();
            MailMessage mailMessage = new MailMessage();
            to = textBox_Gmail.Text.Trim();
            from = "recthongminh1@gmail.com";              //email cua minh
            pass = "fute tvvw zahz osln";                  //pass email
            messageBody = "Code: " + randomCode;
            mailMessage.To.Add(to);
            mailMessage.From = new MailAddress(from);
            mailMessage.Body = messageBody;
            mailMessage.Subject = "Creation account code";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(mailMessage);
                MessageBox.Show("Code sent successfully", "Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //timerSendCode.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool CheckCode()
        {
            if(textBox_Code.Text.Trim() == "")
            {
                MessageBox.Show("Enter code", "Forget password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (randomCode == textBox_Code.Text.ToString())
            {
                to = textBox_Gmail.Text;     //Texts
                return true;
            }
            else
            {
                MessageBox.Show("Wrong code");
                return false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time >= 0)
            {
                button_SendCode.Enabled = false;
                //labelNotice.Text
                time--; 
            }
            else
            {
                //labelNotice.Text = "";
                time = 600;
                button_SendCode.Enabled = true;
                timer1.Enabled = false;
            }
        }

        public static string AutoEmail(string email)
        {
            for (int i = 0; i < email.Length; i++)
            {
                if (email[i] == '@')
                    return email;
            }
            return email + "@gmail.com";
        }
    }
}
