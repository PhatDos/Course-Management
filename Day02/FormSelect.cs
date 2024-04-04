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
    public partial class FormSelect : Form
    {
        public FormSelect()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addStdF = new AddStudentForm();
            addStdF.Show(this);
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentListForm StdList = new StudentListForm();
            StdList.Show(this);
        }

        private void staticsticToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Statisctic statisctic = new Statisctic();
            statisctic.Show(this);
        }

        private void manageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudent MNS = new ManageStudent();
            MNS.Show(this);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintForm PrintForm = new PrintForm();
            PrintForm.Show(this);
        }

        private void addCousesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseForm a = new AddCourseForm();
            a.Show(this);
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCourse removeCourse = new RemoveCourse();
            removeCourse.Show(this);
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm EditForm = new EditForm();
            EditForm.Show(this);
        }
    }
}
