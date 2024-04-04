using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Day02
{
    public partial class ForgetPass : Form
    {
        public ForgetPass()
        {
            InitializeComponent();
        }

        string randomCode, to;
        public static string UserName1, Email1;

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool UsernameExist(string username, string email)
        {
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
                        string testEmail = table.Rows[i]["email"].ToString();    
                        for (int j = 0; j < email.Length; j++)
                        {
                            if (email[j] != testEmail[j])                     //check email
                            {
                                MessageBox.Show("The Email does not belong to the Username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                        return true;
                    }
                }
            }
            MessageBox.Show("The username does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        private void button_SendCode_Click(object sender, EventArgs e)
        {
            textBox_Email.Text = Register.AutoEmail(textBox_Email.Text);

            if (textBox_Email.Text.Trim() == "" || textBox_Username.Text.Trim() == "")
            {
                MessageBox.Show("Email and username can not be blanked", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (UsernameExist(textBox_Username.Text.ToString(), textBox_Email.Text.ToString()) == false) 
            {
                return;
            }                                         //check username exist or not

            string from, pass, body;
            Random rand = new Random();
            randomCode = rand.Next(999999).ToString();
            //randomCode
            MailMessage message = new MailMessage();
            to = textBox_Email.Text.Trim();
            from = "recthongminh1@gmail.com";
            pass = "fute tvvw zahz osln";
            body = "Code: " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = body;
            message.Subject = "Code for reseting password";
            
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("Code sent successfully");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Veriffy_Click(object sender, EventArgs e)
        {
            if (textBox_Code.Text.Trim() == "") 
            {
                MessageBox.Show("Enter your code");
                return;
            }
            if (randomCode == textBox_Code.Text.ToString())
            {
                UserName1 = textBox_Username.Text;
                Email1 = textBox_Email.Text;
                ResetPassword resetPassword = new ResetPassword();
                resetPassword.Show();                               //new form
            }
            else
            {
                MessageBox.Show("Wrong code!");
            }
        }
    }
}
