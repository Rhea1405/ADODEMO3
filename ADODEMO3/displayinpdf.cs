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
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace ADODEMO3
{
    public partial class displayinpdf : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;

        DataSet ds = null;
        public displayinpdf()
        {
            InitializeComponent();
        }

        private void displayinpdf_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;" +
          "User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-6FSVS29");




            adp = new SqlDataAdapter("select * from empdata", con);
            ds = new DataSet();
            adp.Fill(ds, "e");
            dgvemp.DataSource = ds.Tables["e"];

        }

        private void dgvemp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //    int row_index = e.RowIndex;
            //    for (int i = 0; i < dgvemp.Rows.Count; i++)
            //    {
            //        if (row_index != i)
            //        {
            //            dgvemp.Rows[i].Cells["selection"].Value = false;
            //        }
            //    }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //adp = new SqlDataAdapter("select * from empdata", con);
            //DataSet ds = new DataSet();
            //adp.Fill(ds, "a");

            DataTable dt = new DataTable();
            dt.Columns.Add("empno", typeof(Int32));
            dt.Columns.Add("ename", typeof(string));
            dt.Columns.Add("job", typeof(string));
            dt.Columns.Add("mgr", typeof(Int32));
            dt.Columns.Add("hiredate", typeof(DateTime));
            dt.Columns.Add("sal", typeof(Int32));
            dt.Columns.Add("comm", typeof(Int16));
            dt.Columns.Add("deptno", typeof(Int32));

            for (int i = 0; i < dgvemp.Rows.Count - 1; i++)
            {
                if (dgvemp.Rows[i].Cells[0].Value != null)
                {
                    bool check = (bool)dgvemp.Rows[i].Cells[0].Value;
                    if (check == true)
                    {
                        DataRow dr = dt.NewRow();
                        dr["empno"] = dgvemp.Rows[i].Cells[1].Value.ToString();
                        dr["ename"] = dgvemp.Rows[i].Cells[2].Value.ToString();
                        dr["job"] = dgvemp.Rows[i].Cells[3].Value.ToString();
                        dr["mgr"] = dgvemp.Rows[i].Cells[4].Value.ToString();
                        dr["hiredate"] = dgvemp.Rows[i].Cells[5].Value.ToString();
                        dr["sal"] = dgvemp.Rows[i].Cells[6].Value;
                        dr["comm"] = dgvemp.Rows[i].Cells[7].Value;
                        dr["deptno"] = dgvemp.Rows[i].Cells[8].Value;


                        dt.Rows.Add(dr);
                    }




                    dgvemp2.DataSource = dt;



                    PdfPTable p = new PdfPTable(dgvemp2.ColumnCount);



                  
                    
                    


                    foreach (DataGridViewColumn column in dgvemp2.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                       

                        cell.BackgroundColor = new iTextSharp.text.BaseColor(240,200,100);
                      
                        p.AddCell(cell);
                    }
                    dgvemp2.AllowUserToAddRows = false;
                    foreach (DataGridViewRow row in dgvemp2.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                           
                            p.AddCell(cell.Value.ToString());
                            //dgvemp2.AllowUserToAddRows = false;
                        }
                    }


                    string folderPath = @"C:\Users\Admin\Desktop\SQL-SERVER";
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }


                    Document d = new Document();
                    PdfWriter.GetInstance(d, new FileStream("d:\\PD1.pdf", FileMode.Create));
                    d.Open();
                    d.Add(p);
                    d.Close();
                }
            }

            //method2
            //        public static void pdfconversion(DataTable dt)
            //            {
            //                Document d = new Document();
            //               PdfWriter.GetInstance(d, new FileStream("d:\\PDF4.pdf", FileMode.Create));
            //               d.Open();

            //    PdfPTable p = new PdfPTable(dt.Columns.Count);



            //    for (int i=0;i<dt.Rows.Count;i++)
            //        {
            //        for(int j=0;j<dt.Columns.Count;j++)
            //        {
            //            p.AddCell(dt.Rows[i][j].ToString());
            //        }

            //    }
            //    d.Add(p);
            //    d.Close();


            //}







        }
    }
}

            


        

    

    



