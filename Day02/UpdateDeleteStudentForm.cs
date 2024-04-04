using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;
using System.Drawing.Imaging;

namespace Day02
{
    public partial class UpdateDeleteStudentForm : Form
    {
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();

        private void bt_Find_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TextStudentID.Text);
            SqlCommand command = new SqlCommand("SELECT * FROM std WHERE id = " + id);
            DataTable table = student.getStudents(command);

            if (table.Rows.Count > 0 )
            {
                TextBoxFname.Text = table.Rows[0]["fname"].ToString();
                TextBoxLname.Text = table.Rows[0]["lname"].ToString();
                DateTimePicker1.Value = (DateTime)table.Rows[0]["bdate"];

                if (table.Rows[0]["gender"].ToString() == "Female")
                {
                    RadioButtonFemale.Checked = true;
                }
                else
                {
                    RadioButtonMale.Checked = true;
                }

                TextBoxPhone.Text = table.Rows[0]["phone"].ToString();
                TextBoxAddress.Text = table.Rows[0]["address"].ToString();

                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                PictureBoxStudentImage.Image = Image.FromStream(picture);
            }

            else
            {
                MessageBox.Show("NOT FOUND", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(TextStudentID.Text);

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

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();

            //DELETE
            int ID = Convert.ToInt32(TextStudentID.Text);

            if (!student.DeleteStudent(ID))
            {
                MessageBox.Show("Error", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //ADD
            int id = Convert.ToInt32(TextStudentID.Text);
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
        bool verify()
        {
            if (TextBoxFname.Text.Trim() == "" || TextBoxLname.Text.Trim() == ""
                || TextBoxAddress.Text.Trim() == "" || TextBoxPhone.Text.Trim() == ""
                || PictureBoxStudentImage.Image == null)
                return false;
            return true;
        }

        private void button_DownloadPic_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("student_" + TextStudentID.Text);
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
