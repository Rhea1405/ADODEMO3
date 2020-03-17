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

   
    public partial class noofyears : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        public noofyears()
        {
            InitializeComponent();
        }

        private void noofyears_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;" +
             "User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-6FSVS29");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select empno,ename,hiredate,dbo.fn_date(@hd) years from EMPDATA where hiredate=@hd",con);
            adp.SelectCommand.Parameters.AddWithValue("@hd", DateTime.Parse(txthd.Text));
            DataSet ds = new DataSet();
            adp.Fill(ds, "e");
            dataGridView1.DataSource = ds.Tables["e"];
        }
    }
}
