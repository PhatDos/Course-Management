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

namespace Day02
{
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        private void StudentListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDBDataSet4.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter4.Fill(this.qLSVDBDataSet4.std);
            // TODO: This line of code loads data into the 'qLSVDBDataSet3.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter3.Fill(this.qLSVDBDataSet3.std);
            // TODO: This line of code loads data into the 'qLSVDBDataSet2.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter2.Fill(this.qLSVDBDataSet2.std);
            // TODO: This line of code loads data into the 'qLSVDBDataSet1.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter1.Fill(this.qLSVDBDataSet1.std);
            // TODO: This line of code loads data into the 'qLSVDBDataSet.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter.Fill(this.qLSVDBDataSet.std);                   //q -> Q
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            DataGridView1.ReadOnly = true;
            //
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView1.RowTemplate.Height = 80;
            DataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)DataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView1.AllowUserToAddRows = false;
        }
        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            DataGridView1.ReadOnly = true;
            //
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView1.RowTemplate.Height = 80;
            DataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)DataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView1.AllowUserToAddRows = false;
        }

        public void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm UDStdF = new UpdateDeleteStudentForm();
            // thu tu columns: ID - FN - LN - BD - GD - PHONE - ADR - PIC
            UDStdF.TextStudentID.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            UDStdF.TextBoxFname.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            UDStdF.TextBoxLname.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            UDStdF.DateTimePicker1.Value = (DateTime)DataGridView1.CurrentRow.Cells[3].Value;

            //gender
            if (DataGridView1.CurrentRow.Cells[4].Value.ToString() == "Female")
            {
                UDStdF.RadioButtonFemale.Checked = true;
            }
            else 
            { 
                UDStdF.RadioButtonMale.Checked = true; 
            }
            UDStdF.TextBoxPhone.Text = DataGridView1.CurrentRow.Cells[5].Value.ToString();
            UDStdF.TextBoxAddress.Text = DataGridView1.CurrentRow.Cells[6].Value.ToString();

            //pic
            byte[] pic;
            pic = (byte[])DataGridView1.CurrentRow.Cells[7].Value;  
            MemoryStream picture = new MemoryStream(pic);
            UDStdF.PictureBoxStudentImage.Image = Image.FromStream(picture);

            UDStdF.Show();
        }
    }
}
