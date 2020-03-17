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
    public partial class Form1 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;" +
                "Initial Catalog=ADO_DB;Data Source=DESKTOP-6FSVS29");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_insertemp", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@eno", int.Parse(txtempno.Text));
            adp.SelectCommand.Parameters.AddWithValue("@ename", txtename.Text);
            adp.SelectCommand.Parameters.AddWithValue("@g", cbbgender.Text);
            adp.SelectCommand.Parameters.AddWithValue("@dob", DateTime.Parse(dtpdate.Text));
            adp.SelectCommand.Parameters.AddWithValue("@dno", int.Parse(txtdeptno.Text));

            SqlParameter s = new SqlParameter("@result", SqlDbType.NVarChar,200);
            s.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(s);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            MessageBox.Show(s.Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("update_emp", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            adp.SelectCommand.Parameters.AddWithValue("@empno", int.Parse(txtempno.Text));
            adp.SelectCommand.Parameters.AddWithValue("@dob", DateTime.Parse(dtpdate.Text));
            adp.SelectCommand.Parameters.AddWithValue("@ename", txtename.Text);
            adp.SelectCommand.Parameters.AddWithValue("@dno", int.Parse(txtdeptno.Text));

            SqlParameter s = new SqlParameter("@result", SqlDbType.NVarChar, 200);
            s.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(s);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            MessageBox.Show(s.Value.ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("deletep", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@empno", int.Parse(txtempno.Text));

            SqlParameter s = new SqlParameter("@result", SqlDbType.NVarChar, 200);
            s.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(s);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            MessageBox.Show(s.Value.ToString());

        }
    }
}
