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
    public partial class Form3 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet ds = null;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                adp = new SqlDataAdapter("cursorex", con);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@dno", int.Parse(txtdept.Text));
                SqlParameter s = new SqlParameter("@status", SqlDbType.NVarChar, 100);
                s.Direction = ParameterDirection.Output;
                adp.SelectCommand.Parameters.Add(s);
                ds = new DataSet();
                adp.Fill(ds);
                MessageBox.Show(s.Value.ToString());

            }
            catch(FormatException f)
            {
                MessageBox.Show("INVALID");
            }



        }

        private void Form3_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;" +
              "User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-6FSVS29");


        }
    }
}
