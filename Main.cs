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

                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                {
                    button.Name = "Action";
                    button.HeaderText = "Action";
                    button.Text = "Edit";
                    button.UseColumnTextForButtonValue = true; //dont forget this line
                    dataGridView.Columns.Add(button); 
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
    }
}
