namespace ADODEMO3
{
    partial class orderproduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtorderid = new System.Windows.Forms.TextBox();
            this.txtorderdesc = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.dtporderdate = new System.Windows.Forms.DateTimePicker();
            this.cbbcustomerid = new System.Windows.Forms.ComboBox();
            this.cbbsalesmanid = new System.Windows.Forms.ComboBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btninsert = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_add = new System.Windows.Forms.Button();
            this.Productid = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productdesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "order id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "order desc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "order date";
            // 
            // discount
            // 
            this.discount.AutoSize = true;
            this.discount.Location = new System.Drawing.Point(444, 42);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(47, 13);
            this.discount.TabIndex = 3;
            this.discount.Text = "discount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "customer id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "salesman id";
            // 
            // txtorderid
            // 
            this.txtorderid.Enabled = false;
            this.txtorderid.Location = new System.Drawing.Point(142, 31);
            this.txtorderid.Name = "txtorderid";
            this.txtorderid.Size = new System.Drawing.Size(200, 20);
            this.txtorderid.TabIndex = 6;
            // 
            // txtorderdesc
            // 
            this.txtorderdesc.Location = new System.Drawing.Point(142, 104);
            this.txtorderdesc.Name = "txtorderdesc";
            this.txtorderdesc.Size = new System.Drawing.Size(200, 20);
            this.txtorderdesc.TabIndex = 7;
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(518, 31);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(121, 20);
            this.txtdiscount.TabIndex = 8;
            // 
            // dtporderdate
            // 
            this.dtporderdate.Location = new System.Drawing.Point(142, 158);
            this.dtporderdate.Name = "dtporderdate";
            this.dtporderdate.Size = new System.Drawing.Size(200, 20);
            this.dtporderdate.TabIndex = 9;
            // 
            // cbbcustomerid
            // 
            this.cbbcustomerid.FormattingEnabled = true;
            this.cbbcustomerid.Location = new System.Drawing.Point(518, 104);
            this.cbbcustomerid.Name = "cbbcustomerid";
            this.cbbcustomerid.Size = new System.Drawing.Size(121, 21);
            this.cbbcustomerid.TabIndex = 10;
            // 
            // cbbsalesmanid
            // 
            this.cbbsalesmanid.FormattingEnabled = true;
            this.cbbsalesmanid.Location = new System.Drawing.Point(518, 162);
            this.cbbsalesmanid.Name = "cbbsalesmanid";
            this.cbbsalesmanid.Size = new System.Drawing.Size(121, 21);
            this.cbbsalesmanid.TabIndex = 11;
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Productid,
            this.productdesc,
            this.qty,
            this.unitprice,
            this.totalcost});
            this.dgv1.Location = new System.Drawing.Point(116, 231);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(540, 150);
            this.dgv1.TabIndex = 12;
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellClick);
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            this.dgv1.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellLeave);
            this.dgv1.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_RowLeave);
            this.dgv1.SelectionChanged += new System.EventHandler(this.dgv1_SelectionChanged);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(359, 409);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 13;
            this.btninsert.Text = "insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btninsert);
            this.panel1.Controls.Add(this.dgv1);
            this.panel1.Controls.Add(this.cbbsalesmanid);
            this.panel1.Controls.Add(this.cbbcustomerid);
            this.panel1.Controls.Add(this.dtporderdate);
            this.panel1.Controls.Add(this.txtdiscount);
            this.panel1.Controls.Add(this.txtorderdesc);
            this.panel1.Controls.Add(this.txtorderid);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.discount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(159, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 442);
            this.panel1.TabIndex = 14;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(28, 92);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(81, 43);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "Add Bill";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Productid
            // 
            this.Productid.HeaderText = "Product Id";
            this.Productid.Name = "Productid";
            this.Productid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Productid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // productdesc
            // 
            this.productdesc.HeaderText = "Product Desc";
            this.productdesc.Name = "productdesc";
            // 
            // qty
            // 
            this.qty.HeaderText = "Quantity";
            this.qty.Name = "qty";
            // 
            // unitprice
            // 
            this.unitprice.HeaderText = "Unit Price";
            this.unitprice.Name = "unitprice";
            // 
            // totalcost
            // 
            this.totalcost.HeaderText = "Total Cost";
            this.totalcost.Name = "totalcost";
            // 
            // orderproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 472);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.panel1);
            this.Name = "orderproduct";
            this.Text = "orderproduct";
            this.Load += new System.EventHandler(this.orderproduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label discount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtorderid;
        private System.Windows.Forms.TextBox txtorderdesc;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.DateTimePicker dtporderdate;
        private System.Windows.Forms.ComboBox cbbcustomerid;
        private System.Windows.Forms.ComboBox cbbsalesmanid;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridViewComboBoxColumn Productid;
        private System.Windows.Forms.DataGridViewTextBoxColumn productdesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalcost;
    }
}