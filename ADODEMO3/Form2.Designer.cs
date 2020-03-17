namespace ADODEMO3
{
    partial class Form2
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
            this.submitbtn = new System.Windows.Forms.Button();
            this.cbbdeptno = new System.Windows.Forms.ComboBox();
            this.commtxt = new System.Windows.Forms.TextBox();
            this.saltxt = new System.Windows.Forms.TextBox();
            this.dtphiredate = new System.Windows.Forms.DateTimePicker();
            this.jobtxt = new System.Windows.Forms.TextBox();
            this.mgrtxt = new System.Windows.Forms.TextBox();
            this.enametxt = new System.Windows.Forms.TextBox();
            this.empnotxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelhiredate = new System.Windows.Forms.Label();
            this.labelmgr = new System.Windows.Forms.Label();
            this.labeljob = new System.Windows.Forms.Label();
            this.labelename = new System.Windows.Forms.Label();
            this.labelempno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textinc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submitbtn
            // 
            this.submitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.Location = new System.Drawing.Point(351, 415);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(75, 35);
            this.submitbtn.TabIndex = 33;
            this.submitbtn.Text = "submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // cbbdeptno
            // 
            this.cbbdeptno.Enabled = false;
            this.cbbdeptno.FormattingEnabled = true;
            this.cbbdeptno.Location = new System.Drawing.Point(453, 346);
            this.cbbdeptno.Name = "cbbdeptno";
            this.cbbdeptno.Size = new System.Drawing.Size(121, 21);
            this.cbbdeptno.TabIndex = 32;
            // 
            // commtxt
            // 
            this.commtxt.Enabled = false;
            this.commtxt.Location = new System.Drawing.Point(453, 300);
            this.commtxt.Name = "commtxt";
            this.commtxt.Size = new System.Drawing.Size(100, 20);
            this.commtxt.TabIndex = 31;
            // 
            // saltxt
            // 
            this.saltxt.Enabled = false;
            this.saltxt.Location = new System.Drawing.Point(453, 262);
            this.saltxt.Name = "saltxt";
            this.saltxt.Size = new System.Drawing.Size(100, 20);
            this.saltxt.TabIndex = 30;
            // 
            // dtphiredate
            // 
            this.dtphiredate.Enabled = false;
            this.dtphiredate.Location = new System.Drawing.Point(453, 214);
            this.dtphiredate.Name = "dtphiredate";
            this.dtphiredate.Size = new System.Drawing.Size(200, 20);
            this.dtphiredate.TabIndex = 29;
            // 
            // jobtxt
            // 
            this.jobtxt.Location = new System.Drawing.Point(453, 112);
            this.jobtxt.Name = "jobtxt";
            this.jobtxt.Size = new System.Drawing.Size(100, 20);
            this.jobtxt.TabIndex = 28;
            // 
            // mgrtxt
            // 
            this.mgrtxt.Enabled = false;
            this.mgrtxt.Location = new System.Drawing.Point(453, 164);
            this.mgrtxt.Name = "mgrtxt";
            this.mgrtxt.Size = new System.Drawing.Size(100, 20);
            this.mgrtxt.TabIndex = 27;
            // 
            // enametxt
            // 
            this.enametxt.Enabled = false;
            this.enametxt.Location = new System.Drawing.Point(453, 66);
            this.enametxt.Name = "enametxt";
            this.enametxt.Size = new System.Drawing.Size(100, 20);
            this.enametxt.TabIndex = 26;
            // 
            // empnotxt
            // 
            this.empnotxt.Location = new System.Drawing.Point(453, 19);
            this.empnotxt.Name = "empnotxt";
            this.empnotxt.Size = new System.Drawing.Size(100, 20);
            this.empnotxt.TabIndex = 25;
            this.empnotxt.Leave += new System.EventHandler(this.empnotxt_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(147, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "deptno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "commission";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "salary";
            // 
            // labelhiredate
            // 
            this.labelhiredate.AutoSize = true;
            this.labelhiredate.Location = new System.Drawing.Point(147, 221);
            this.labelhiredate.Name = "labelhiredate";
            this.labelhiredate.Size = new System.Drawing.Size(45, 13);
            this.labelhiredate.TabIndex = 21;
            this.labelhiredate.Text = "hiredate";
            // 
            // labelmgr
            // 
            this.labelmgr.AutoSize = true;
            this.labelmgr.Location = new System.Drawing.Point(147, 164);
            this.labelmgr.Name = "labelmgr";
            this.labelmgr.Size = new System.Drawing.Size(48, 13);
            this.labelmgr.TabIndex = 20;
            this.labelmgr.Text = "manager";
            // 
            // labeljob
            // 
            this.labeljob.AutoSize = true;
            this.labeljob.Location = new System.Drawing.Point(147, 112);
            this.labeljob.Name = "labeljob";
            this.labeljob.Size = new System.Drawing.Size(21, 13);
            this.labeljob.TabIndex = 19;
            this.labeljob.Text = "job";
            // 
            // labelename
            // 
            this.labelename.AutoSize = true;
            this.labelename.Location = new System.Drawing.Point(147, 69);
            this.labelename.Name = "labelename";
            this.labelename.Size = new System.Drawing.Size(81, 13);
            this.labelename.TabIndex = 18;
            this.labelename.Text = "employee name";
            // 
            // labelempno
            // 
            this.labelempno.AutoSize = true;
            this.labelempno.Location = new System.Drawing.Point(147, 22);
            this.labelempno.Name = "labelempno";
            this.labelempno.Size = new System.Drawing.Size(39, 13);
            this.labelempno.TabIndex = 17;
            this.labelempno.Text = "empno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "inc percentage";
            // 
            // textinc
            // 
            this.textinc.Location = new System.Drawing.Point(453, 381);
            this.textinc.Name = "textinc";
            this.textinc.Size = new System.Drawing.Size(121, 20);
            this.textinc.TabIndex = 35;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textinc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.cbbdeptno);
            this.Controls.Add(this.commtxt);
            this.Controls.Add(this.saltxt);
            this.Controls.Add(this.dtphiredate);
            this.Controls.Add(this.jobtxt);
            this.Controls.Add(this.mgrtxt);
            this.Controls.Add(this.enametxt);
            this.Controls.Add(this.empnotxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelhiredate);
            this.Controls.Add(this.labelmgr);
            this.Controls.Add(this.labeljob);
            this.Controls.Add(this.labelename);
            this.Controls.Add(this.labelempno);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.ComboBox cbbdeptno;
        private System.Windows.Forms.TextBox commtxt;
        private System.Windows.Forms.TextBox saltxt;
        private System.Windows.Forms.DateTimePicker dtphiredate;
        private System.Windows.Forms.TextBox jobtxt;
        private System.Windows.Forms.TextBox mgrtxt;
        private System.Windows.Forms.TextBox enametxt;
        private System.Windows.Forms.TextBox empnotxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelhiredate;
        private System.Windows.Forms.Label labelmgr;
        private System.Windows.Forms.Label labeljob;
        private System.Windows.Forms.Label labelename;
        private System.Windows.Forms.Label labelempno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textinc;
    }
}