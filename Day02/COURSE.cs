using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day02
{
    internal class COURSE
    {
        MY_DB mydb = new MY_DB();

        public bool CheckCourseName(string courseName, int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM CourseTable WHERE lable = '" + courseName + "'" + " OR Id =" + id, mydb.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if ( table.Rows.Count > 0 )
            {
                return true;
            }
            return false;
        }

        public void DeleteCourse(int ID)
        {
            SqlCommand sql = new SqlCommand("DELETE FROM CourseTable WHERE Id = " + ID, mydb.getConnection());

            mydb.openConnection();

            if (sql.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                MessageBox.Show("Course deleted");
            }
            else
            {
                mydb.closeConnection();
                MessageBox.Show("Course delete failed");
            }
        }

        public DataTable getAllCourses()
        {
            DataTable table = new DataTable();
            SqlCommand sql = new SqlCommand("SELECT * FROM CourseTable", mydb.getConnection());
            SqlDataAdapter adapter1 = new SqlDataAdapter(sql);
            adapter1.Fill(table);
            return table;
        }
        public DataTable getCoursesByID(int ID)
        {
            SqlCommand sql = new SqlCommand("SELECT * FROM CourseTable WHERE Id =" + ID, mydb.getConnection());
            DataTable table = new DataTable();
            SqlDataAdapter adapter2 = new SqlDataAdapter(sql);
            adapter2.Fill(table);
            return table;
        }
        public void insertCourse(int id, string lable, int period, string description)
        {
            SqlCommand command = new SqlCommand("INSERT INTO CourseTable (Id, lable, period, description) " +
                "VALUES (@id, @lable, @period, @description)", mydb.getConnection());
            command.Parameters.Add("@id", SqlDbType.Int).Value = id; 
            command.Parameters.Add("@lable", SqlDbType.VarChar).Value = lable;
            command.Parameters.Add("@period", SqlDbType.Int).Value = period;
            command.Parameters.Add("@description", SqlDbType.VarChar).Value = description;

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Course add SUCCESSED");
                return;
            }
            else
            {
                MessageBox.Show("Course add FAILED");
                return;
            }
        }
        public int TotalCourse() 
        {
            DataTable table = new DataTable();
            SqlCommand sql = new SqlCommand("SELECT * FROM CourseTable", mydb.getConnection());
            SqlDataAdapter adapter1 = new SqlDataAdapter(sql);
            adapter1.Fill(table);
            return table.Rows.Count;
        }

        public bool updateCourse(int courseID, string lable, int period, string description) 
        {
            SqlCommand command = new SqlCommand("UPDATE CourseTable SET lable = @lable, period = @period, description = @description WHERE id = @courseID", mydb.getConnection());
            command .Parameters.Add("@courseID", SqlDbType.Int).Value = courseID;
            command.Parameters.Add("@lable", SqlDbType.NVarChar).Value = lable;
            command.Parameters.Add("@period", SqlDbType.Int).Value= period;
            command.Parameters.Add("@description", SqlDbType.NVarChar).Value = description;

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            return false;
        }

    }
}
