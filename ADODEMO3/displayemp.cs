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
    public partial class displayemp : Form
    {
        SqlDataAdapter adp = null;
        SqlConnection con = null;
        public displayemp()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void displayemp_Load(object sender, EventArgs e)
        {
            

        }
    }
}
