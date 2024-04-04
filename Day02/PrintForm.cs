using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Interop.Word;

namespace Day02
{
    public partial class PrintForm : Form
    {
        public PrintForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        private void PrintForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * from std");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            //dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].Width = 125;
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[5].Width = 140;
            dataGridView1.Columns[6].Width = 180;
            dataGridView1.Columns[7].Width = 110;
        }

        private void button_Check_Click(object sender, EventArgs e)
        {
            if (radioButton_Yes.Checked)
            {
                DateTime start = dateTimePicker1.Value;
                DateTime end = dateTimePicker2.Value;
                if (start > end)
                {
                    DateTime temp = start;
                    start = end;
                    end = temp;
                }

                SqlCommand command = new SqlCommand();

                if (radioButton_Male.Checked)
                {
                    command.CommandText = "SELECT * from std where bdate between @start and @end and gender = 'Male'";
                }
                else if (radioButton_Female.Checked)
                {
                    command.CommandText = "SELECT * from std where bdate between @start and @end and gender = 'Female'";
                }
                else
                {
                    command.CommandText = "SELECT * from std where bdate between @start and @end";
                }
                command.Parameters.Add("@start", SqlDbType.DateTime).Value = start;
                command.Parameters.Add("@end", SqlDbType.DateTime).Value = end;
                dataGridView1.DataSource = student.getStudents(command);
            }
            else
            {
                SqlCommand command = new SqlCommand();
                if (radioButton_All.Checked)
                {
                    command.CommandText = "SELECT * from std";
                }
                else if (radioButton_Female.Checked)
                {
                    command.CommandText = "SELECT * from std where gender = 'Female'";
                }
                else
                {
                    command.CommandText = "SELECT * from std where gender = 'Male'";
                }
                dataGridView1.DataSource = student.getStudents(command);
            }
        }

        private void button_SaveTextFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "DOCX files(*.docx)|*.docx";

            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                Export_Data_To_Word(dataGridView1, savefile.FileName);
                MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;

                Document oDoc = new Document();
                oDoc.Application.Visible = true;

                oDoc.PageSetup.Orientation = WdOrientation.wdOrientLandscape;

                //dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                Object oMissing = System.Reflection.Missing.Value;
                for (int r = 0; r <= RowCount - 1; r++)
                {
                    oTemp = "";
                    for (int c = 0; c < ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DGV.Rows[r].Cells[c].Value + "\t";
                    }
                    var oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara1.Range.Text = oTemp;
                    oPara1.Range.InsertParagraphAfter();
                    byte[] imgbyte = (byte[])dataGridView1.Rows[r].Cells[7].Value;
                    MemoryStream ms = new MemoryStream(imgbyte);
                    //Image sparePicture = Image.FromStream(ms);
                    Image finalPic = (Image)(new Bitmap(Image.FromStream(ms), new Size(50, 50)));
                    Clipboard.SetDataObject(finalPic);
                    var oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara2.Range.Paste();
                    oPara2.Range.InsertParagraphAfter();
                    //oTemp += "\n";
                }

                //save the file
                oDoc.SaveAs2(filename);
            }
        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            if (printDlg.ShowDialog() == DialogResult.OK)
                printDoc.Print();
        }

    }
}
