using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using officeExcel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class Reports : Form
    {
        public static string id, iddes,data1,data2,data3,data4,data5,data6,data7,data8;
        DBAccess objDbAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        int i=0;
      
        public Reports()
        {
            InitializeComponent();
            
        }
        public void wait(int milliseconds)
        {
            var timer1 = new
                System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();

            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }


        }
        private void btnfetch_Click(object sender, EventArgs e)
        {
                
            this.dataGridView1.Rows.Clear();
            String srchid = txtid.Text;
            String dat;
            String Tim;

            if (rdyid.Checked)
            {
                dtUsers.Clear();
                string query = "select * from Datastore Where PRID ='" + srchid + " ' ";
                objDbAccess.readDatathroughAdapter(query, dtUsers);
                i = 0;
                int rowcount = dtUsers.Rows.Count;
                while (i < rowcount)
                {
                    id = dtUsers.Rows[i]["PRID"].ToString();
                    iddes = dtUsers.Rows[i]["PRIDDES"].ToString();
                    data1 = dtUsers.Rows[i]["DATA1"].ToString();
                    data2 = dtUsers.Rows[i]["DATA2"].ToString();
                    data3 = dtUsers.Rows[i]["DATA3"].ToString();
                    data4 = dtUsers.Rows[i]["DATA4"].ToString();
                    data5 = dtUsers.Rows[i]["DATA5"].ToString();
                    data6 = dtUsers.Rows[i]["DATA6"].ToString();
                    data7 = dtUsers.Rows[i]["DATA7"].ToString();
                    data8 = dtUsers.Rows[i]["DATA8"].ToString();
                    dat = dtUsers.Rows[i]["Date"].ToString();
                    Tim = dtUsers.Rows[i]["Time"].ToString();
                    this.dataGridView1.Rows.Add(id,iddes, dat, Tim,data1, data2,data3,data4,data5,data6,data7,data8);
                    
                    i = i + 1;

                }
            }
            if (rdbydate.Checked)
            {

                dtUsers.Clear(); 
                string query = "select * from Datastore Where Date between'" + dtpstrt.Value + "'and ' "+ dtpend.Value +" ' ";
                objDbAccess.readDatathroughAdapter(query, dtUsers);
                i = 0;
                int rowcount = dtUsers.Rows.Count;
                
                while (i < rowcount)
                {
                    id = dtUsers.Rows[i]["PRID"].ToString();
                    iddes = dtUsers.Rows[i]["PRIDDES"].ToString();
                    data1 = dtUsers.Rows[i]["DATA1"].ToString();
                    data2 = dtUsers.Rows[i]["DATA2"].ToString();
                    data3 = dtUsers.Rows[i]["DATA3"].ToString();
                    data4 = dtUsers.Rows[i]["DATA4"].ToString();
                    data5 = dtUsers.Rows[i]["DATA5"].ToString();
                    data6 = dtUsers.Rows[i]["DATA6"].ToString();
                    data7 = dtUsers.Rows[i]["DATA7"].ToString();
                    data8 = dtUsers.Rows[i]["DATA8"].ToString();
                    dat = dtUsers.Rows[i]["Date"].ToString();
                    Tim = dtUsers.Rows[i]["Time"].ToString();
                    this.dataGridView1.Rows.Add(id, iddes, dat, Tim, data1, data2, data3, data4, data5, data6, data7, data8);

                    i = i + 1;

                }
            }
   
        }
        private void btntoxl_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count>0)
            {
                {
                    Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
                    xlapp.Application.Workbooks.Add(Type.Missing);
                      
                    for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                    {
                        xlapp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;

                    }
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            xlapp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                        }
                    }
                    //Following line for display excel and do what you wish
                    xlapp.Columns.AutoFit();
                    xlapp.Visible = true;
                    xlapp.ActiveWorkbook.Saved = true;
                    // till here
                    // following line used for saving in document folder
                    //xlapp.ActiveWorkbook.SaveAs("d:\\save\\"+ "tryexcel");
                    //xlapp.Quit();
   
                }  

            }
        }
       private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
