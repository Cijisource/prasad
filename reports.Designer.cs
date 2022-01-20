
namespace WindowsFormsApp1
{
    partial class Reports
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
            this.rdyid = new System.Windows.Forms.RadioButton();
            this.rdbydate = new System.Windows.Forms.RadioButton();
            this.txtid = new System.Windows.Forms.TextBox();
            this.dtpstrt = new System.Windows.Forms.DateTimePicker();
            this.dtpend = new System.Windows.Forms.DateTimePicker();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnfetch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciddes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdata1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdata2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdata3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdata4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdata5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdata6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdata7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdata8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btntoxl = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "FIRM CAPTION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "REPORT";
            // 
            // rdyid
            // 
            this.rdyid.AutoSize = true;
            this.rdyid.Location = new System.Drawing.Point(572, 76);
            this.rdyid.Name = "rdyid";
            this.rdyid.Size = new System.Drawing.Size(88, 17);
            this.rdyid.TabIndex = 3;
            this.rdyid.TabStop = true;
            this.rdyid.Text = "Search By ID";
            this.rdyid.UseVisualStyleBackColor = true;
            // 
            // rdbydate
            // 
            this.rdbydate.AutoSize = true;
            this.rdbydate.Location = new System.Drawing.Point(888, 77);
            this.rdbydate.Name = "rdbydate";
            this.rdbydate.Size = new System.Drawing.Size(100, 17);
            this.rdbydate.TabIndex = 4;
            this.rdbydate.TabStop = true;
            this.rdbydate.Text = "Search By Date";
            this.rdbydate.UseVisualStyleBackColor = true;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(682, 74);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(163, 20);
            this.txtid.TabIndex = 5;
            // 
            // dtpstrt
            // 
            this.dtpstrt.AllowDrop = true;
            this.dtpstrt.CustomFormat = "MM-dd-yyyy   hh:mm:ss";
            this.dtpstrt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpstrt.Location = new System.Drawing.Point(1006, 76);
            this.dtpstrt.Name = "dtpstrt";
            this.dtpstrt.Size = new System.Drawing.Size(81, 20);
            this.dtpstrt.TabIndex = 6;
            // 
            // dtpend
            // 
            this.dtpend.AllowDrop = true;
            this.dtpend.CustomFormat = "dd-MM-yyyy hh:mm:ss";
            this.dtpend.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpend.Location = new System.Drawing.Point(1124, 76);
            this.dtpend.Name = "dtpend";
            this.dtpend.Size = new System.Drawing.Size(96, 20);
            this.dtpend.TabIndex = 7;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(1206, 635);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(111, 35);
            this.btnclose.TabIndex = 8;
            this.btnclose.Text = "CLOSE REPORT";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnfetch
            // 
            this.btnfetch.Location = new System.Drawing.Point(43, 630);
            this.btnfetch.Name = "btnfetch";
            this.btnfetch.Size = new System.Drawing.Size(147, 45);
            this.btnfetch.TabIndex = 9;
            this.btnfetch.Text = "FETCH DATA";
            this.btnfetch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnfetch.UseVisualStyleBackColor = true;
            this.btnfetch.Click += new System.EventHandler(this.btnfetch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cid,
            this.ciddes,
            this.cdate,
            this.ctime,
            this.cdata1,
            this.cdata2,
            this.cdata3,
            this.cdata4,
            this.cdata5,
            this.cdata6,
            this.cdata7,
            this.cdata8});
            this.dataGridView1.Location = new System.Drawing.Point(43, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1293, 511);
            this.dataGridView1.TabIndex = 10;
            // 
            // cid
            // 
            this.cid.Frozen = true;
            this.cid.HeaderText = "ID";
            this.cid.Name = "cid";
            this.cid.ReadOnly = true;
            // 
            // ciddes
            // 
            this.ciddes.Frozen = true;
            this.ciddes.HeaderText = "ID DESCRIPTION";
            this.ciddes.Name = "ciddes";
            this.ciddes.ReadOnly = true;
            this.ciddes.Width = 150;
            // 
            // cdate
            // 
            this.cdate.Frozen = true;
            this.cdate.HeaderText = "DATE";
            this.cdate.Name = "cdate";
            this.cdate.ReadOnly = true;
            // 
            // ctime
            // 
            this.ctime.Frozen = true;
            this.ctime.HeaderText = "TIME";
            this.ctime.Name = "ctime";
            this.ctime.ReadOnly = true;
            // 
            // cdata1
            // 
            this.cdata1.Frozen = true;
            this.cdata1.HeaderText = "DATA 1";
            this.cdata1.Name = "cdata1";
            this.cdata1.ReadOnly = true;
            // 
            // cdata2
            // 
            this.cdata2.Frozen = true;
            this.cdata2.HeaderText = "DATA 2";
            this.cdata2.Name = "cdata2";
            this.cdata2.ReadOnly = true;
            // 
            // cdata3
            // 
            this.cdata3.Frozen = true;
            this.cdata3.HeaderText = "DATA 3";
            this.cdata3.Name = "cdata3";
            this.cdata3.ReadOnly = true;
            // 
            // cdata4
            // 
            this.cdata4.Frozen = true;
            this.cdata4.HeaderText = "DATA 4";
            this.cdata4.Name = "cdata4";
            this.cdata4.ReadOnly = true;
            // 
            // cdata5
            // 
            this.cdata5.Frozen = true;
            this.cdata5.HeaderText = "DATA 5";
            this.cdata5.Name = "cdata5";
            this.cdata5.ReadOnly = true;
            // 
            // cdata6
            // 
            this.cdata6.Frozen = true;
            this.cdata6.HeaderText = "DATA 6";
            this.cdata6.Name = "cdata6";
            this.cdata6.ReadOnly = true;
            // 
            // cdata7
            // 
            this.cdata7.Frozen = true;
            this.cdata7.HeaderText = "DATA 7";
            this.cdata7.Name = "cdata7";
            this.cdata7.ReadOnly = true;
            // 
            // cdata8
            // 
            this.cdata8.Frozen = true;
            this.cdata8.HeaderText = "DATA 8";
            this.cdata8.Name = "cdata8";
            this.cdata8.ReadOnly = true;
            // 
            // btntoxl
            // 
            this.btntoxl.Location = new System.Drawing.Point(468, 630);
            this.btntoxl.Name = "btntoxl";
            this.btntoxl.Size = new System.Drawing.Size(275, 49);
            this.btntoxl.TabIndex = 11;
            this.btntoxl.Text = "EXPORT TO EXCEL";
            this.btntoxl.UseVisualStyleBackColor = true;
            this.btntoxl.Click += new System.EventHandler(this.btntoxl_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btntoxl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnfetch);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.dtpend);
            this.Controls.Add(this.dtpstrt);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.rdbydate);
            this.Controls.Add(this.rdyid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Reports";
            this.Text = "REPORTS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdyid;
        private System.Windows.Forms.RadioButton rdbydate;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DateTimePicker dtpstrt;
        private System.Windows.Forms.DateTimePicker dtpend;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnfetch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciddes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdata1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdata2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdata3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdata4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdata5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdata6;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdata7;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdata8;
        private System.Windows.Forms.Button btntoxl;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}