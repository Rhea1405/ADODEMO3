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
    public partial class func1 : Form
    {

        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        public func1()
        {
            InitializeComponent();
        }

        private void func1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;" +
              "User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-6FSVS29");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select empno,hiredate,dbo.fn_date(@eno) years from emploc", con);
           // adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@eno", int.Parse(txtdeptno.Text));
            DataSet ds = new DataSet();
            adp.Fill(ds, "e");
            dataGridView1.DataSource = ds.Tables["e"];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
