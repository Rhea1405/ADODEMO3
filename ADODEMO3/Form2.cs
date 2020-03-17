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
    public partial class Form2 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;" +
                "User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-6FSVS29");



        }

        private void empnotxt_Leave(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_extract", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@Eno", int.Parse(empnotxt.Text));
            SqlParameter s = new SqlParameter("@status", SqlDbType.NVarChar, 100);
            s.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(s);
            ds = new DataSet();
            adp.Fill(ds, "E");
           
            DataRow r = null;
            if (s.Value.ToString().Length==0)
            {
                r = ds.Tables["E"].Rows[0];
                enametxt.Text = r[1].ToString();
                jobtxt.Text = r[2].ToString();
                mgrtxt.Text = r[3].ToString();
                dtphiredate.Text = r[4].ToString();
                saltxt.Text = r[5].ToString();
                commtxt.Text = r[6].ToString();
                cbbdeptno.Text = r[7].ToString();
                
            }
            
            else
            {
                clear();
                MessageBox.Show("no record found");
                
                
            }
            
            
        }
        private void clear()
        {
            empnotxt.Text = "";
            enametxt.Text = "";
            saltxt.Text = "";
            jobtxt.Text = "";
            commtxt.Text = "";
            mgrtxt.Text = "";
            cbbdeptno.Text = "";



        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_updatesal", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@eno", int.Parse(empnotxt.Text));
            adp.SelectCommand.Parameters.AddWithValue("@newjob", jobtxt.Text);
            adp.SelectCommand.Parameters.AddWithValue("@incpercentage", textinc.Text);
            SqlParameter s = new SqlParameter("@status", SqlDbType.NVarChar, 100);
            s.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(s);
            ds = new DataSet();
            adp.Fill(ds);
            MessageBox.Show(s.Value.ToString());
            clear();

        }
    }
}
