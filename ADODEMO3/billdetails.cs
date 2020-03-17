using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADODEMO3
{
    public partial class billdetails : Form4
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;

        DataSet ds = null;
        public billdetails()
        {
            InitializeComponent();
        }

        private void billdetails_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;" +
           "User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-6FSVS29");

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();

        }
    }
}
