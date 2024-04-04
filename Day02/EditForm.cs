using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day02
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();
        private void button_Edit_Click(object sender, EventArgs e)
        {
            string lable = textBox_Lable.Text;
            int period = (int)numericUpDown_Period.Value;
            string description = richTextBox_Description.Text;
            int id = (int) comboBox_Course.SelectedValue;

            if (!course.CheckCourseName(lable, id))
            {
                MessageBox.Show("This course already existed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (course.updateCourse(id, lable, period, description))
                {
                    MessageBox.Show("Course updated");
                }
                FillCombo(comboBox_Course.SelectedIndex);
            }
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            comboBox_Course.DataSource = course.getAllCourses();
            comboBox_Course.DisplayMember = "lable";
            comboBox_Course.ValueMember = "Id";

            comboBox_Course.SelectedItem = null;
        }

        public void FillCombo(int index)
        {
            comboBox_Course.DataSource = course.getAllCourses();
            comboBox_Course.DisplayMember = "lable";
            comboBox_Course.ValueMember= "Id";
            comboBox_Course.SelectedIndex = index;
        }

        private void comboBox_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(comboBox_Course.SelectedValue);
                DataTable table = new DataTable();
                table = course.getCoursesByID(id);
                textBox_Lable.Text = table.Rows[0][1].ToString();
                numericUpDown_Period.Value = Int32.Parse(table.Rows[0][2].ToString());
                richTextBox_Description.Text = table.Rows[0][3].ToString();
            }
            catch { }
        }
    }
}
