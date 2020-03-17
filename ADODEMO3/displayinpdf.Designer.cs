namespace ADODEMO3
{
    partial class displayinpdf
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
            this.dgvemp = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.selection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvemp2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvemp2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvemp
            // 
            this.dgvemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvemp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selection});
            this.dgvemp.Location = new System.Drawing.Point(151, 50);
            this.dgvemp.Name = "dgvemp";
            this.dgvemp.Size = new System.Drawing.Size(545, 189);
            this.dgvemp.TabIndex = 0;
            this.dgvemp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvemp_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // selection
            // 
            this.selection.HeaderText = "selection";
            this.selection.Name = "selection";
            this.selection.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.selection.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvemp2
            // 
            this.dgvemp2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvemp2.Location = new System.Drawing.Point(90, 274);
            this.dgvemp2.Name = "dgvemp2";
            this.dgvemp2.Size = new System.Drawing.Size(240, 150);
            this.dgvemp2.TabIndex = 2;
            // 
            // displayinpdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvemp2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvemp);
            this.Name = "displayinpdf";
            this.Text = "displayinpdf";
            this.Load += new System.EventHandler(this.displayinpdf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvemp2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvemp;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selection;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvemp2;
    }
}