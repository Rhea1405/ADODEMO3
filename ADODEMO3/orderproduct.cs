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
    public partial class orderproduct : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;

        DataSet ds = null;
        public orderproduct()
        {
            InitializeComponent();
        }

        private void orderproduct_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;" +
             "User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-6FSVS29");

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select count(*) from orderdetails", con);
            ds = new DataSet();
            adp.Fill(ds, "e");
            txtorderid.Text = (int.Parse(ds.Tables["e"].Rows[0][0].ToString()) + 1).ToString();

            adp = new SqlDataAdapter("select salesmanid,salesmanname from salesmandetails", con);
            adp.Fill(ds, "s");
            cbbsalesmanid.DataSource = ds.Tables["s"];
            cbbsalesmanid.DisplayMember = "salesmanname";
            cbbsalesmanid.ValueMember = "salesmanid";

            adp = new SqlDataAdapter("select customerid,customername from customerdetails", con);
            adp.Fill(ds, "c");
            cbbcustomerid.DataSource = ds.Tables["c"];
            cbbcustomerid.DisplayMember = "customername";
            cbbcustomerid.ValueMember = "customerid";



            panel1.Visible = true;
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_orderproducts", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@oid", txtorderid.Text);
            adp.SelectCommand.Parameters.AddWithValue("@orderdesc", txtorderdesc.Text);
            adp.SelectCommand.Parameters.AddWithValue("@orderdate",DateTime.Parse(dtporderdate.Text));
            adp.SelectCommand.Parameters.AddWithValue("@dis",int.Parse(txtdiscount.Text));
            adp.SelectCommand.Parameters.AddWithValue("@customerid", cbbcustomerid.SelectedValue);
            adp.SelectCommand.Parameters.AddWithValue("@salesid", cbbsalesmanid.SelectedValue);


            DataTable mytable = new DataTable();
            mytable.Columns.Add("orderid", typeof(string));
            mytable.Columns.Add("productid", typeof(string));
            mytable.Columns.Add("qty", typeof(Int32));
            for (int i = 0; i < dgv1.Rows.Count - 1; i++)
            {
                mytable.Rows.Add(txtorderid.Text, dgv1.Rows[i].Cells[0].Value.ToString(), dgv1.Rows[i].Cells[2].Value.ToString());


            }
            SqlParameter p = new SqlParameter("@ord_pro", mytable);
            ds = new DataSet();
            p.SqlDbType = SqlDbType.Structured;
            adp.SelectCommand.Parameters.Add(p);
            adp.Fill(ds);

            MessageBox.Show("inserted");

            panel1.Visible = false;
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv1.CurrentCell.ColumnIndex.Equals(0))
            {
                adp = new SqlDataAdapter("select productid from productdetails", con);
                DataSet ds = new DataSet();
                adp.Fill(ds, "pid");
                foreach (DataGridViewRow row in dgv1.Rows)
                {
                    (row.Cells[0] as DataGridViewComboBoxCell).DataSource = ds.Tables["pid"];//converting txtbox cell to cbb cell
                    (row.Cells[0] as DataGridViewComboBoxCell).DisplayMember = "productid";
                }
                
            }
        }

        private void dgv1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            
            //if (!dgv1.CurrentCell.ColumnIndex.Equals(0))
            //  {
            //    adp = new SqlDataAdapter("select * from productdetails where productid=@pno", con);
            //     adp.SelectCommand.Parameters.AddWithValue("@pno", dgv1.CurrentRow.Cells[0].Value);
            //        ds = new DataSet();
            //        adp.Fill(ds, "p");
            //        dgv1.CurrentRow.Cells[1].Value = ds.Tables["p"].Rows[0][1];
            //        dgv1.CurrentRow.Cells[3].Value = ds.Tables["p"].Rows[0][2];
            //    }
        }

            private void dgv1_SelectionChanged(object sender, EventArgs e)
            {
                if (dgv1.CurrentRow.Cells[0].Value != null)
                {
                    if (!dgv1.CurrentCell.ColumnIndex.Equals(0))
                    {
                        adp = new SqlDataAdapter("select * from productdetails where productid=@pno", con);
                        adp.SelectCommand.Parameters.AddWithValue("@pno", dgv1.CurrentRow.Cells[0].Value);
                        ds = new DataSet();
                        adp.Fill(ds, "p");
                        dgv1.CurrentRow.Cells[1].Value = ds.Tables["p"].Rows[0][1];
                        dgv1.CurrentRow.Cells[3].Value = ds.Tables["p"].Rows[0][2];
                    }
                }
            }

            private void dgv1_RowLeave(object sender, DataGridViewCellEventArgs e)
            {
            if (dgv1.CurrentRow.Cells[2].Value != null)
            {


                int q = int.Parse(dgv1.CurrentRow.Cells[2].Value.ToString());
                int p = int.Parse(dgv1.CurrentRow.Cells[3].Value.ToString());
                dgv1.CurrentRow.Cells[4].Value = q * p;

            }
        }
        }
    }
