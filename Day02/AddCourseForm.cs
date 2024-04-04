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
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }

        private void button_AddCourse_Click(object sender, EventArgs e)
        {
            COURSE course = new COURSE();
            if (textBox_CourseID.Text.Trim() == "" || textBox_Lable.Text.Trim() == "" || textBox_Period.Text.Trim()  == "")
            {
                MessageBox.Show("The textbox is blanked", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = Convert.ToInt32(textBox_CourseID.Text);
            string lable = textBox_Lable.Text;
            int period = Convert.ToInt32(textBox_Period.Text);
            string description = richTextBox_Description.Text;

            if (course.CheckCourseName(lable, id))
            {
                MessageBox.Show("Course ID or lable have been existed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            course.insertCourse(id, lable, period, description);
        }
    }
}
