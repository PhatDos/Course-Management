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
    public partial class RemoveCourse : Form
    {
        public RemoveCourse()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();
        private void button_RemoveCourse_Click(object sender, EventArgs e)
        {
            if (textBox_CourseID.Text.Trim() == "")
            {
                return;
            }
            course.DeleteCourse(Convert.ToInt32(textBox_CourseID.Text));
        }
    }
}
