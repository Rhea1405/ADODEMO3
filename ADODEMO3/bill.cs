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
    public partial class bill : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;

        DataSet ds = null;
        public bill()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_index = e.RowIndex;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (row_index != i)
                {
                    dataGridView1.Rows[i].Cells["selection"].Value = false;
                }
            }
        }

        private void bill_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;

            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;" +
            "User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-6FSVS29");




            adp = new SqlDataAdapter("select * from productdetails", con);
            ds = new DataSet();
            adp.Fill(ds, "e");
            dataGridView1.DataSource = ds.Tables["e"];

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;

           
            adp = new SqlDataAdapter("select * from productdetails", con);
            ds = new DataSet();
            adp.Fill(ds);
          
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[0] != null)
                {
                    if ((bool)(dataGridView1.Rows[i].Cells[0] as DataGridViewCheckBoxCell).Value == true)
                    {
                        productid.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        desc.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        price.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    }
                }

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void desc_Click(object sender, EventArgs e)
        {

        }

        private void price_Click(object sender, EventArgs e)
        {

        }
    }

}

    


