using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curdOperations
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();

            this.showAllData();
        }

        public void showAllData()
        {
            string strConnString = ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString;

            SqlConnection con = new SqlConnection(strConnString);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.CommandText = "sp_GetAllStudentInfo";

            cmd.Connection = con;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            try
            {
                con.Open();

                sda.Fill(dt);

                dataGridView.DataSource = dt;

                dataGridView.Columns[0].Visible = false;

                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                {
                    button.Name = "Edit";
                    button.HeaderText = "Edit";
                    button.Text = "Edit";
                    button.UseColumnTextForButtonValue = true; //dont forget this line
                    dataGridView.Columns.Add(button); 
                }

                DataGridViewButtonColumn delButton = new DataGridViewButtonColumn();
                {
                    delButton.Name = "Delete";
                    delButton.HeaderText = "Delete";
                    delButton.Text = "Delete";
                    delButton.UseColumnTextForButtonValue = true;
                    dataGridView.Columns.Add(delButton);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Console.WriteLine("this is edit :" + dataGridView.Columns[e.ColumnIndex].Name);

            //Deleting Row
            if (dataGridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                //Console.WriteLine("row index " + e.RowIndex);

                int deleteId = (Int32)dataGridView.Rows[e.RowIndex].Cells[2].Value;

                Console.WriteLine("deleting row Id :  " + deleteId);

                this.deleteStudentInfo(deleteId);

            }
        }

        private void deleteStudentInfo(int studentId)
        {
            if(studentId > 0)
            {
                string connString = ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString;

                SqlConnection con = new SqlConnection(connString);

                SqlCommand cmd = new SqlCommand();

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "sp_deleteStudent";

                cmd.Parameters.AddWithValue("@id", studentId);

                cmd.Connection = con;

                try
                {

                    con.Open();

                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                    con.Dispose();

                    this.showAllData();
                }

            }
        }

        private void addNewStudent(object sender, EventArgs e)
        {
            Form addNewStudent = new addNew();

            addNewStudent.Show();
        }
    }
}
