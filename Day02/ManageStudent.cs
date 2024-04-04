using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day02
{
    public partial class ManageStudent : Form
    {
        public ManageStudent()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        public void fillGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
            label_Total.Text = "Total student: " + dataGridView1.Rows.Count + " students";
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm UDStdF = new UpdateDeleteStudentForm();
            // thu tu columns: ID - FN - LN - BD - GD - PHONE - ADR - PIC
            TextBoxStudentID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TextBoxFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TextBoxLname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            DateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;

            //gender
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Female")
            {
                RadioButtonFemale.Checked = true;
            }
            else
            {
                RadioButtonMale.Checked = true;
            }
            TextBoxPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            TextBoxAddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            //pic
            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            PictureBoxStudentImage.Image = Image.FromStream(picture);
        }

        private void ManageStudent_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * FROM std");
            fillGrid(sqlCommand);
        }

        private void bt_Find_Click(object sender, EventArgs e)
        {
            if (textBox_Find.Text.Trim() == "")
            {
                return;
            }
            SqlCommand sqlCommand2 = new SqlCommand("Select * FROM std Where CONCAT(fname,lname,address) LIKE '%" + textBox_Find.Text + "%'");
            fillGrid(sqlCommand2);
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

        private void button_DownloadPic_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("student_" + TextBoxStudentID.Text);
            if (PictureBoxStudentImage.Image == null)
            {
                MessageBox.Show("There's no image in Picturebox");
                //return;
            }
            else if (svf.ShowDialog() == DialogResult.OK)
            {
                PictureBoxStudentImage.Image.Save(svf.FileName + "." + ImageFormat.Jpeg.ToString());
            }
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            TextBoxStudentID.Text = "";
            TextBoxFname.Text = "";
            TextBoxLname.Text = string.Empty;
            TextBoxAddress.Text = string.Empty;
            TextBoxPhone.Text = string.Empty;
            PictureBoxStudentImage.Image = null;
            RadioButtonFemale.Checked = false;
            RadioButtonMale.Checked = false;
            DateTimePicker1.Value = DateTime.Now;
        }

        private void button1_Add_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
            int id = Convert.ToInt32(TextBoxStudentID.Text);
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

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();

            //DELETE
            int ID = Convert.ToInt32(TextBoxStudentID.Text);

            if (!student.DeleteStudent(ID))
            {
                MessageBox.Show("Error", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //ADD
            int id = Convert.ToInt32(TextBoxStudentID.Text);
            string fname = TextBoxFname.Text;
            string lname = TextBoxLname.Text;
            DateTime bdate = DateTimePicker1.Value;
            string phone = TextBoxPhone.Text;
            string adrs = TextBoxAddress.Text;
            string gender = "Male";

            if (RadioButtonFemale.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic = new MemoryStream();
            int born_year = DateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;

            if (this_year - born_year > 100 || this_year - born_year < 10)
            {
                MessageBox.Show("Student age must be between 10 and 100", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                PictureBoxStudentImage.Image.Save(pic, PictureBoxStudentImage.Image.RawFormat);
                if (student.insertStudent(id, fname, lname, bdate, gender, phone, adrs, pic))
                {
                    MessageBox.Show("New Student Changed", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete student" + TextBoxStudentID.Text + "?", "Delete student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int ID = Convert.ToInt32(TextBoxStudentID.Text);

            if (student.DeleteStudent(ID))
            {
                MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Error", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * FROM std");
            fillGrid(sqlCommand);
        }
    }
}
