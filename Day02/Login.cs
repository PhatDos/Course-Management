using Microsoft.Win32;
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

namespace Day02
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:/Users/TANPHAT/source/repos/4-WINDOWN/QLSV/QLSV/images/user.png");
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM login WHERE username = @User AND password = @Pass", db.getConnection());

            command.Parameters.Add("@User", SqlDbType.VarChar).Value = TextBoxUsername.Text;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = TextBoxPassword.Text;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                FormSelect frm = new FormSelect();
                frm.Show(this);
            }
            else
            {
                MessageBox.Show("Wrong Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show(this);
        }

        private void button_ForgetPassword_Click(object sender, EventArgs e)
        {
            ForgetPass forgetPass = new ForgetPass();
            forgetPass.Show(this);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                TextBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TextBoxPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
