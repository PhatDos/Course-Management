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
    public partial class Statisctic : Form
    {
        public Statisctic()
        {
            InitializeComponent();
        }

        Color TotalColor, MaleColor, FemaleColor;
        private void Statisctic_Load(object sender, EventArgs e)
        {
            TotalColor = panelTotal.BackColor;
            MaleColor = panelMale.BackColor;
            FemaleColor = panelFemale.BackColor;
            //get Student information
            STUDENT stu = new STUDENT();
            int total = Convert.ToInt32(stu.GetTotal());
            int male = Convert.ToInt32(stu.GetMale());
            int female = Convert.ToInt32(stu.GetFemale());

            double malePercent = (male * 100) / total;
            double femalePercent = (female * 100) / total;

            panelMale.Width = (int)(5.8 * malePercent);
            panelFemale.Width = (int)(5.8 * femalePercent);

            label_Total.Text = "Total: " + total.ToString() + " students";
            label_Male.Text = "Male: " + malePercent.ToString() + "%";
            label_Female.Text = "Female: " + femalePercent.ToString() + "%";
        }
    }
}
