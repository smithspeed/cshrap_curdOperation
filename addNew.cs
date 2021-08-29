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
                this.Text = "Update Student";

                this.addButton.Text = "Update Student";

                this.getStudentInfo();
            }
            else
            {
                this.Text = "Add Student";

                this.addButton.Text = "Add Student";
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
            //Console.WriteLine("student id :" + studId);

            string connString = ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString;

            SqlConnection con = new SqlConnection(connString);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_GetStudentInfo";
            cmd.Parameters.AddWithValue("@studId", studId);
            cmd.Connection = con;

            try
            {
                con.Open();

                SqlDataReader sda = cmd.ExecuteReader();

                sda.Read();

                nameTextBox.Text = sda["name"].ToString();
                mobileTextBox.Text = sda["mobile"].ToString();
                emailIdTextBox.Text = sda["emailId"].ToString();
                genderComboBox.SelectedItem = sda["gender"].ToString();
                Console.WriteLine("staus : " + sda["status"].GetType());
                statusComboBox.SelectedItem = sda["status"].ToString() == "1" ? "Active" : "Inactive";

                this.Show();
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
    }
}
