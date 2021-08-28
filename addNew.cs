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
        public addNew()
        {
            InitializeComponent();
        }

        private void addStudent(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString;

            SqlConnection con = new SqlConnection(connString);


        }
    }
}
