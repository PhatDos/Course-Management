using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day02
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            int id = Convert.ToInt32(txtStudentID.Text);
            string fname = TextBoxFname.Text;
            string lname = TextBoxLname.Text;
            DateTime bdate = DateTimePicker1.Value;
            bdate = bdate.Date;                                //bo gio sinh
            string phone = TextBoxPhone.Text;
            string adrs = TextBoxAddress.Text;
            string gender = "Male";

            for (int i = 0; i < fname.Length; i++)
            {
                if (fname[i] >= '0' && fname[i] <= '9')
                {
                    MessageBox.Show("Name can not contain numbers!", "Error");            //check first name
                    return;
                }
            }

            for (int i = 0; i < lname.Length; i++)
            {
                if (lname[i] >= '0' && lname[i] <= '9')
                {
                    MessageBox.Show("Name can not contain numbers!", "Error");            //check last name
                    return;
                }
            }

            for (int i = 0; i < phone.Length; i++)
            {
                if (!(phone[i] >= '0' && phone[i] <= '9'))
                {
                    MessageBox.Show("Phone can not contain letters!", "Error");            //check phone
                    return;
                }
            }

            if (RadioButtonFemale.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();
            int born_year = DateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;

            if (this_year - born_year > 100 || this_year - born_year < 15)
            {
                MessageBox.Show("Student age must be between 15 and 100", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
                if (student.insertStudent(id, fname, lname, bdate, gender, phone, adrs, pic))
                {
                    MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
                else
                {
                    MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        bool verify()
        {
            if (TextBoxFname.Text.Trim() == "" || TextBoxLname.Text.Trim() == ""
                || TextBoxAddress.Text.Trim() == "" || TextBoxPhone.Text.Trim() == ""
                || PictureBoxStudentImage.Image == null)
                return false;
            return true;
        }
        private void ButtonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*png;*gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                PictureBoxStudentImage.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
