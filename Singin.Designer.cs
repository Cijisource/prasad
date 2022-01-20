
namespace WindowsFormsApp1
{
    partial class Singin
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
            this.btnreports = new System.Windows.Forms.Button();
            this.btnmodify = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btndatacap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIRM CAPTION";
            // 
            // btnreports
            // 
            this.btnreports.Location = new System.Drawing.Point(525, 169);
            this.btnreports.Name = "btnreports";
            this.btnreports.Size = new System.Drawing.Size(123, 35);
            this.btnreports.TabIndex = 7;
            this.btnreports.Text = "REPORTS";
            this.btnreports.UseVisualStyleBackColor = true;
            this.btnreports.Click += new System.EventHandler(this.btnreports_Click);
            // 
            // btnmodify
            // 
            this.btnmodify.Location = new System.Drawing.Point(938, 157);
            this.btnmodify.Name = "btnmodify";
            this.btnmodify.Size = new System.Drawing.Size(123, 35);
            this.btnmodify.TabIndex = 8;
            this.btnmodify.Text = "MODIFY";
            this.btnmodify.UseVisualStyleBackColor = true;
            this.btnmodify.Click += new System.EventHandler(this.btnmodify_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(525, 379);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(132, 44);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btndatacap
            // 
            this.btndatacap.Location = new System.Drawing.Point(139, 170);
            this.btndatacap.Name = "btndatacap";
            this.btndatacap.Size = new System.Drawing.Size(122, 34);
            this.btndatacap.TabIndex = 10;
            this.btndatacap.Text = "DATA CAPTURE";
            this.btndatacap.UseVisualStyleBackColor = true;
            this.btndatacap.Click += new System.EventHandler(this.btndatacap_Click);
            // 
            // Singin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btndatacap);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnmodify);
            this.Controls.Add(this.btnreports);
            this.Controls.Add(this.label1);
            this.Name = "Singin";
            this.Text = "Sing in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnreports;
        private System.Windows.Forms.Button btnmodify;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btndatacap;
    }
}