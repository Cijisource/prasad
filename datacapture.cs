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

namespace WindowsFormsApp1
{
    public partial class datacapture : Form
    {
        DBAccess ObjDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        DBAccess2 ObjDBAccess2 = new DBAccess2();
        DataTable dtUsers1 = new DataTable();
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
        public datacapture()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String userid = txtid.Text;
            String useriddes = txtpriddes.Text;
            String tempdate = txtDate.Text;
            DateTime userDate = Convert.ToDateTime(tempdate);
            String tempTime = txtTime.Text;
            DateTime userTime = Convert.ToDateTime(tempTime);
            String userdata1 = txtdata1.Text;
            String userdata2 = txtdata2.Text;
            String userdata3 = txtdata3.Text;
            String userdata4 = txtdata4.Text;
            String userdata5 = txtdata5.Text;
            String userdata6 = txtdata6.Text;
            String userdata7 = txtdata7.Text;
            String userdata8 = txtdata8.Text;
            DateTime saveddate;
            String saveddatetemp;
            double diff;
            
            SqlCommand insertCommand = new SqlCommand("insert into Datastore(PRID,PRIDDES,DATE,TIME,DATA1,DATA2,DATA3,DATA4,DATA5,DATA6,DATA7,DATA8) values (@id,@iddes,@date,@time,@data1,@data2,@data3,@data4,@data5,@data6,@data7,@data8)");
            insertCommand.Parameters.AddWithValue("@id", userid);
            insertCommand.Parameters.AddWithValue("@iddes", useriddes);
            insertCommand.Parameters.AddWithValue("@Date", userDate);
            insertCommand.Parameters.AddWithValue("@Time", userTime);
            insertCommand.Parameters.AddWithValue("@data1", userdata1);
            insertCommand.Parameters.AddWithValue("@data2", userdata2);
            insertCommand.Parameters.AddWithValue("@data3", userdata3);
            insertCommand.Parameters.AddWithValue("@data4", userdata4);
            insertCommand.Parameters.AddWithValue("@data5", userdata5);
            insertCommand.Parameters.AddWithValue("@data6", userdata6);
            insertCommand.Parameters.AddWithValue("@data7", userdata7);
            insertCommand.Parameters.AddWithValue("@data8", userdata8);
            //~~~~~~~~~~~~~~~~~~~~~

            //~~~~~~~~~~~~~~~~~~~~~~~
            int row = ObjDBAccess.executeQuery(insertCommand);
            if (row == 1)
            {
                txtid.Text = "";
                txtpriddes.Text = "";
                txtdata1.Text = "";
                txtdata2.Text = "";
                txtdata3.Text = "";
                txtdata4.Text = "";
                txtdata5.Text = "";
                txtdata6.Text = "";
                txtdata7.Text = "";
                txtdata8.Text = "";
            }
            else
            {
                MessageBox.Show("Error occured Try Again in inserting data ");
            }
            
            //getting date from other database and finding difference~~~~~~~~~~~~~~~~~~~~~
           string query = "select * from Varistore";
            ObjDBAccess2.readDatathroughAdapter(query, dtUsers1);
            //fetching data from storage database
              saveddatetemp = dtUsers1.Rows[1]["storedate"].ToString();
             //textBox1.Text = saveddatetemp;
             //ImeModeConversion of string to date format
               saveddate = Convert.ToDateTime(saveddatetemp);
               //storage database closed
               ObjDBAccess2.closeConn();
               //differenc ebetween saved date and current date
               diff = (userDate - saveddate).TotalDays;
            if (diff > 0)
            {
                
                
                //runing loop for saving daywise data
                
                for (int i = 0; i < diff; i++)
                {
                    //difference date dat are being saved one file per day
                    dtUsers.Clear();
                    
                    string query1 = "select * from Datastore Where Date ='" + saveddate.AddDays(i+1)  + " ' ";
                    ObjDBAccess.readDatathroughAdapter(query1, dtUsers);
                    int rowcount = dtUsers.Rows.Count;
                    textBox1.Text = saveddate.ToString();
                   // wait(3000);
                    DateTime filenamdate = saveddate.AddDays(i + 1);
                    string namevar = "record" + filenamdate.ToString();
                    string filename = namevar.Remove(namevar.Length - 12);
                    
                    
                    if(rowcount > 0)

                    {
                        //decleration of excel for saving dayswise data
                        Microsoft.Office.Interop.Excel.Application xlappday = new Microsoft.Office.Interop.Excel.Application();
                        xlappday.Application.Workbooks.Add(Type.Missing);

                        //transferring datatable values to excell
                        for (int j = 0; j <dtUsers.Rows.Count; j++)
                        {
                            for (int k = 0; k < dtUsers.Columns.Count; k++)
                            {
                                xlappday.Cells[j+2, k+2] = dtUsers.Rows[j][k].ToString();
                                                                                             
                            }
                            
                        }

                        //saving excel file in specific folder
                        xlappday.ActiveWorkbook.SaveAs("d:\\save\\" + filename);
                        xlappday.Quit();

                   }
                    
                    textBox1.Text = "transfer over for one day";
                                     
                }

                //passing last saved date to storage database
                string query2 = "Update Varistore SET storedate = '" + @userDate.AddDays(-31) + "'";
                //string query2 = "Update Varistore SET storedate = '" + @userDate + "'";
                SqlCommand updateCommend = new SqlCommand(query2);
                updateCommend.Parameters.AddWithValue("@storedate", userDate.AddDays(-31));
                //updateCommend.Parameters.AddWithValue("@storedate", userDate);
                ObjDBAccess2.executeQuery(updateCommend);
                //End of getting date from other database and finding difference  ~~~~~~~~~~~~~~~~~~
                //saving file in excel if date differ
            }
                     
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            txtTime.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            this.Close();
            Singin Sing = new Singin();
            Sing.Show();
        }
    }
}
