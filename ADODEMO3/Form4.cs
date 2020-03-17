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
    public partial class Form4 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;" +
              "User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-6FSVS29");

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("cursorex1", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@dno", int.Parse(textdeptno.Text));
           
            ds = new DataSet();
            adp.Fill(ds,"deptdata");
           
            dgv1.DataSource = ds.Tables["deptdata"];

        }
    }
}
