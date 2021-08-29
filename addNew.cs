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
    public partial class addNew : Form
    {
        private readonly Main main1;

        private int studId;

        public addNew(Main main)
        {
            InitializeComponent();

            main1 = main;

            studId = main1.studentId;

            if(studId > 0)
            {
                this.getStudentInfo();
            }
        }

        private void addStudent(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString;

            SqlConnection con = new SqlConnection(connString);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_insertStudentInfo";

            cmd.Parameters.AddWithValue("@name", nameTextBox.Text);
            cmd.Parameters.AddWithValue("@mobile", mobileTextBox.Text);
            cmd.Parameters.AddWithValue("@emailId", emailIdTextBox.Text);
            cmd.Parameters.AddWithValue("@gender", genderComboBox.SelectedItem);
            
            int status = (string)statusComboBox.SelectedItem == "Active" ? 1 : 0;

            cmd.Parameters.AddWithValue("@status", status);

            cmd.Connection = con;

            try
            {
                con.Open();

                cmd.ExecuteNonQuery();

                main1.showAllData();

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }




        }

        public void getStudentInfo()
        {
            int studId =  main1.studentId;

            Console.WriteLine("student id :" + studId);

            this.Show();
        }
    }
}
