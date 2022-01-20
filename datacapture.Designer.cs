
namespace WindowsFormsApp1
{
    partial class datacapture
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtpriddes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtdata5 = new System.Windows.Forms.TextBox();
            this.txtdata1 = new System.Windows.Forms.TextBox();
            this.txtdata6 = new System.Windows.Forms.TextBox();
            this.txtdata2 = new System.Windows.Forms.TextBox();
            this.txtdata7 = new System.Windows.Forms.TextBox();
            this.txtdata3 = new System.Windows.Forms.TextBox();
            this.txtdata8 = new System.Windows.Forms.TextBox();
            this.txtdata4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(124, 196);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(205, 20);
            this.txtid.TabIndex = 2;
            // 
            // txtpriddes
            // 
            this.txtpriddes.Location = new System.Drawing.Point(759, 197);
            this.txtpriddes.Name = "txtpriddes";
            this.txtpriddes.Size = new System.Drawing.Size(205, 20);
            this.txtpriddes.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(532, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID DESCRIPTION";
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(571, 565);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(132, 33);
            this.btnupdate.TabIndex = 9;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtDate
            // 
            this.txtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(719, 82);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(261, 26);
            this.txtDate.TabIndex = 12;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTime
            // 
            this.txtTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(986, 82);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(238, 26);
            this.txtTime.TabIndex = 13;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(1021, 558);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(99, 40);
            this.btnexit.TabIndex = 14;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnhome
            // 
            this.btnhome.Location = new System.Drawing.Point(43, 563);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(130, 44);
            this.btnhome.TabIndex = 15;
            this.btnhome.Text = "HOME";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(308, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "FIRM CAPTION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "DATA 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "DATA 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "DATA 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "DATA 4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(621, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 24);
            this.label7.TabIndex = 24;
            this.label7.Text = "DATA 8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(621, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 24);
            this.label9.TabIndex = 23;
            this.label9.Text = "DATA 7";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(621, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 24);
            this.label10.TabIndex = 22;
            this.label10.Text = "DATA 6";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(621, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 24);
            this.label11.TabIndex = 21;
            this.label11.Text = "DATA 5";
            // 
            // txtdata5
            // 
            this.txtdata5.Location = new System.Drawing.Point(737, 255);
            this.txtdata5.Name = "txtdata5";
            this.txtdata5.Size = new System.Drawing.Size(197, 20);
            this.txtdata5.TabIndex = 26;
            // 
            // txtdata1
            // 
            this.txtdata1.Location = new System.Drawing.Point(141, 251);
            this.txtdata1.Name = "txtdata1";
            this.txtdata1.Size = new System.Drawing.Size(188, 20);
            this.txtdata1.TabIndex = 25;
            // 
            // txtdata6
            // 
            this.txtdata6.Location = new System.Drawing.Point(737, 303);
            this.txtdata6.Name = "txtdata6";
            this.txtdata6.Size = new System.Drawing.Size(197, 20);
            this.txtdata6.TabIndex = 28;
            // 
            // txtdata2
            // 
            this.txtdata2.Location = new System.Drawing.Point(141, 305);
            this.txtdata2.Name = "txtdata2";
            this.txtdata2.Size = new System.Drawing.Size(188, 20);
            this.txtdata2.TabIndex = 27;
            // 
            // txtdata7
            // 
            this.txtdata7.Location = new System.Drawing.Point(737, 349);
            this.txtdata7.Name = "txtdata7";
            this.txtdata7.Size = new System.Drawing.Size(197, 20);
            this.txtdata7.TabIndex = 30;
            // 
            // txtdata3
            // 
            this.txtdata3.Location = new System.Drawing.Point(141, 354);
            this.txtdata3.Name = "txtdata3";
            this.txtdata3.Size = new System.Drawing.Size(188, 20);
            this.txtdata3.TabIndex = 29;
            // 
            // txtdata8
            // 
            this.txtdata8.Location = new System.Drawing.Point(737, 404);
            this.txtdata8.Name = "txtdata8";
            this.txtdata8.Size = new System.Drawing.Size(197, 20);
            this.txtdata8.TabIndex = 32;
            // 
            // txtdata4
            // 
            this.txtdata4.Location = new System.Drawing.Point(141, 401);
            this.txtdata4.Name = "txtdata4";
            this.txtdata4.Size = new System.Drawing.Size(188, 20);
            this.txtdata4.TabIndex = 31;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(265, 514);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 33;
            // 
            // datacapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtdata8);
            this.Controls.Add(this.txtdata4);
            this.Controls.Add(this.txtdata7);
            this.Controls.Add(this.txtdata3);
            this.Controls.Add(this.txtdata6);
            this.Controls.Add(this.txtdata2);
            this.Controls.Add(this.txtdata5);
            this.Controls.Add(this.txtdata1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtpriddes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label2);
            this.Name = "datacapture";
            this.Text = "SingUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtpriddes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtdata5;
        private System.Windows.Forms.TextBox txtdata1;
        private System.Windows.Forms.TextBox txtdata6;
        private System.Windows.Forms.TextBox txtdata2;
        private System.Windows.Forms.TextBox txtdata7;
        private System.Windows.Forms.TextBox txtdata3;
        private System.Windows.Forms.TextBox txtdata8;
        private System.Windows.Forms.TextBox txtdata4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

