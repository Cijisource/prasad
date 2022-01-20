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
    public partial class modify : Form
        
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        int ip = 0;
        public modify()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string srchid = txtid.Text;
            string newtxtpriddes=txtpriddes.Text;
            string newtxtdate= txtdate.Text ;
            string newtxttime= txttime.Text ;
            string newtxtdata1=txtdata1.Text ;
            string newtxtdata2=txtdata2.Text ;
            string newtxtdata3=txtdata3.Text ;
            string newtxtdata4=txtdata4.Text ;
            string newtxtdata5=txtdata5.Text ;
            string newtxtdata6=txtdata6.Text ;
            string newtxtdata7=txtdata7.Text ;
            string newtxtdata8=txtdata8.Text ;
            
            if (dtUsers.Rows.Count < 1)
            {
                MessageBox.Show("please enter ID and click fetch data...!!!!");

            }
           else
            {
                dtUsers.Rows[ip]["PRID"] = srchid;
                dtUsers.Rows[ip]["PRIDDES"] = newtxtpriddes;
                dtUsers.Rows[ip]["DATE"] = newtxtdate;
                dtUsers.Rows[ip]["TIME"] = txttime.Text;
                dtUsers.Rows[ip]["DATA1"] = newtxtdata1;
                dtUsers.Rows[ip]["DATA2"] = newtxtdata2;
                dtUsers.Rows[ip]["DATA3"] = newtxtdata3;
                dtUsers.Rows[ip]["DATA4"] = newtxtdata4;
                dtUsers.Rows[ip]["DATA5"] = newtxtdata5;
                dtUsers.Rows[ip]["DATA6"] = newtxtdata6;
                dtUsers.Rows[ip]["DATA7"] = newtxtdata7;
                dtUsers.Rows[ip]["DATA8"] = newtxtdata8;

                int rowcnt = dtUsers.Rows.Count;
                textBox1.Text = "deleting process started";
                string query = "DELETE from Datastore Where PRID ='" + srchid + "'";
                SqlCommand deleteCommend = new SqlCommand(query);
                objDBAccess.executeQuery(deleteCommend);
                ip = 0;
                while (ip < rowcnt)
                {
                    SqlCommand insertCommand = new SqlCommand("insert into Datastore(PRID,PRIDDES,DATE,TIME,DATA1,DATA2,DATA3,DATA4,DATA5,DATA6,DATA7,DATA8) values (@id,@iddes,@date,@time,@data1,@data2,@data3,@data4,@data5,@data6,@data7,@data8)");
                    insertCommand.Parameters.AddWithValue("@id", dtUsers.Rows[ip]["PRID"]);
                    insertCommand.Parameters.AddWithValue("@iddes", dtUsers.Rows[ip]["PRIDDES"]);
                    insertCommand.Parameters.AddWithValue("@Date", dtUsers.Rows[ip]["DATE"]);
                    insertCommand.Parameters.AddWithValue("@Time", dtUsers.Rows[ip]["TIME"]);
                    insertCommand.Parameters.AddWithValue("@data1", dtUsers.Rows[ip]["DATA1"]);
                    insertCommand.Parameters.AddWithValue("@data2", dtUsers.Rows[ip]["DATA2"]);
                    insertCommand.Parameters.AddWithValue("@data3", dtUsers.Rows[ip]["DATA3"]);
                    insertCommand.Parameters.AddWithValue("@data4", dtUsers.Rows[ip]["DATA4"]);
                    insertCommand.Parameters.AddWithValue("@data5", dtUsers.Rows[ip]["DATA5"]);
                    insertCommand.Parameters.AddWithValue("@data6", dtUsers.Rows[ip]["DATA6"]);
                    insertCommand.Parameters.AddWithValue("@data7", dtUsers.Rows[ip]["DATA7"]);
                    insertCommand.Parameters.AddWithValue("@data8", dtUsers.Rows[ip]["DATA8"]);

                    objDBAccess.executeQuery(insertCommand);
                    ip = ip + 1;
                }
                textBox1.Text = "deleting process completed";
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            String srchid = txtid.Text;

            if (dtUsers.Rows.Count < 1)
            {
                MessageBox.Show("please enter ID and click fetch data...!!!!");
            }

            else
            {
                DialogResult dialog = MessageBox.Show("Are you sure?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    //string query = "DELETE from Users Where ID ='" + Singin.id + "'";
                    /*
                    string query = "DELETE from Datastore Where PRID ='" + srchid + "'";
                    SqlCommand deleteCommend = new SqlCommand(query);
                    int row = objDBAccess.executeQuery(deleteCommend);

                    if (row == 1)
                    {
                        MessageBox.Show("Account Deleted Successfully ");
                        txtid.Text = "";
                        txtpriddes.Text = "";
                        txtdate.Text = "";
                        txttime.Text = "";
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
                        MessageBox.Show("Error occured Try Again ");
                    }
                    int rowcnt = dtUsers.Rows.Count;
                    ip = 0;
                    while (ip < rowcnt)
                    {
                        string query = "Update Datastore SET PRID = '" + @dtUsers.Rows[ip]["PRID"] + "' , PRIDDES = '" + @dtUsers.Rows[ip]["PRIDDES"] + "' , DATE ='" + @dtUsers.Rows[ip]["Date"] + "' , TIME ='" + @dtUsers.Rows[ip]["Time"] + "' , data1 ='" + @dtUsers.Rows[ip]["DATA1"] + "' , data2 ='" + @dtUsers.Rows[ip]["DATA2"] + "' , data3 ='" + @dtUsers.Rows[ip]["DATA3"] + "' , data4 ='" + @dtUsers.Rows[ip]["DATA4"] + "' , data5 ='" + @dtUsers.Rows[ip]["DATA5"] + "' , data6 ='" + @dtUsers.Rows[ip]["DATA6"] + "' , data7 ='" + @dtUsers.Rows[ip]["DATA7"] + "' , data8 ='" + @dtUsers.Rows[ip]["DATA8"] + "' Where PRID ='" + srchid + " ' ";
                        SqlCommand updateCommend = new SqlCommand(query);
                        //textBox1.Text = i.ToString();
                        
                        updateCommend.Parameters.AddWithValue("@PRID", dtUsers.Rows[ip]["PRID"]);
                        updateCommend.Parameters.AddWithValue("@PRIDDES", dtUsers.Rows[ip]["PRIDDES"]);
                        updateCommend.Parameters.AddWithValue("@Date", dtUsers.Rows[ip]["DATE"]);
                        updateCommend.Parameters.AddWithValue("@TIME", dtUsers.Rows[ip]["TIME"]);
                        updateCommend.Parameters.AddWithValue("@data1", dtUsers.Rows[ip]["DATA1"]);
                        updateCommend.Parameters.AddWithValue("@data2", dtUsers.Rows[ip]["DATA2"]);
                        updateCommend.Parameters.AddWithValue("@data3", dtUsers.Rows[ip]["DATA3"]);
                        updateCommend.Parameters.AddWithValue("@data4", dtUsers.Rows[ip]["DATA4"]);
                        updateCommend.Parameters.AddWithValue("@data5", dtUsers.Rows[ip]["DATA5"]);
                        updateCommend.Parameters.AddWithValue("@data6", dtUsers.Rows[ip]["DATA6"]);
                        updateCommend.Parameters.AddWithValue("@data7", dtUsers.Rows[ip]["DATA7"]);
                        updateCommend.Parameters.AddWithValue("@data8", dtUsers.Rows[ip]["DATA8"]);
                        objDBAccess.executeQuery(updateCommend);
                        ip = ip + 1;
                    }*/
                    dtUsers.Rows.RemoveAt(ip);
                    int rowcnt = dtUsers.Rows.Count;
                    textBox1.Text = "deleting process started";
                    string query = "DELETE from Datastore Where PRID ='" + srchid + "'";
                    SqlCommand deleteCommend = new SqlCommand(query);
                    objDBAccess.executeQuery(deleteCommend);
                    ip = 0;
                    while (ip < rowcnt)
                    {
                        SqlCommand insertCommand = new SqlCommand("insert into Datastore(PRID,PRIDDES,DATE,TIME,DATA1,DATA2,DATA3,DATA4,DATA5,DATA6,DATA7,DATA8) values (@id,@iddes,@date,@time,@data1,@data2,@data3,@data4,@data5,@data6,@data7,@data8)");
                        insertCommand.Parameters.AddWithValue("@id", dtUsers.Rows[ip]["PRID"]);
                        insertCommand.Parameters.AddWithValue("@iddes", dtUsers.Rows[ip]["PRIDDES"]);
                        insertCommand.Parameters.AddWithValue("@Date", dtUsers.Rows[ip]["DATE"]);
                        insertCommand.Parameters.AddWithValue("@Time", dtUsers.Rows[ip]["TIME"]);
                        insertCommand.Parameters.AddWithValue("@data1", dtUsers.Rows[ip]["DATA1"]);
                        insertCommand.Parameters.AddWithValue("@data2", dtUsers.Rows[ip]["DATA2"]);
                        insertCommand.Parameters.AddWithValue("@data3", dtUsers.Rows[ip]["DATA3"]);
                        insertCommand.Parameters.AddWithValue("@data4", dtUsers.Rows[ip]["DATA4"]);
                        insertCommand.Parameters.AddWithValue("@data5", dtUsers.Rows[ip]["DATA5"]);
                        insertCommand.Parameters.AddWithValue("@data6", dtUsers.Rows[ip]["DATA6"]);
                        insertCommand.Parameters.AddWithValue("@data7", dtUsers.Rows[ip]["DATA7"]);
                        insertCommand.Parameters.AddWithValue("@data8", dtUsers.Rows[ip]["DATA8"]);

                        objDBAccess.executeQuery(insertCommand);
                        ip = ip + 1;
                    }
                    textBox1.Text = "deleting process completed";
                }
            }
        }

        private void txtNameHome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            this.Close();
            Singin sign = new Singin();
            sign.Show();
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            ip = 0;
            txtid.Text = "";
            txtpriddes.Text = "";
            txtdate.Text = "";
            txttime.Text = "";
            txtdata1.Text = "";
            txtdata2.Text = "";
            txtdata3.Text = "";
            txtdata4.Text = "";
            txtdata5.Text = "";
            txtdata6.Text = "";
            txtdata7.Text = "";
            txtdata8.Text = "";
        }

        private void btnfetch_Click(object sender, EventArgs e)
        {
            dtUsers.Clear();
            String srchid = txtid.Text;
            ip =0;
            if (srchid.Equals(""))
            {
                MessageBox.Show("please enter ID...");
            }
            else
            {
                //string query = "select * from Datastore Where PRID='" + srchid + " ' ";
                string query = "select * from Datastore Where PRID ='" + srchid + " ' ";
                objDBAccess.readDatathroughAdapter(query, dtUsers);
                if (dtUsers.Rows.Count > 0)
                {
                    
                    string id = dtUsers.Rows[0]["PRID"].ToString();
                    string iddes = dtUsers.Rows[0]["PRIDDES"].ToString();
                    String date = dtUsers.Rows[0]["DATE"].ToString();
                    String time = dtUsers.Rows[0]["TIME"].ToString();
                    String data1 = dtUsers.Rows[0]["DATA1"].ToString();
                    String data2 = dtUsers.Rows[0]["DATA2"].ToString();
                    String data3 = dtUsers.Rows[0]["DATA3"].ToString();
                    String data4 = dtUsers.Rows[0]["DATA4"].ToString();
                    String data5 = dtUsers.Rows[0]["DATA5"].ToString();
                    String data6 = dtUsers.Rows[0]["DATA6"].ToString();
                    String data7 = dtUsers.Rows[0]["DATA7"].ToString();
                    String data8 = dtUsers.Rows[0]["DATA8"].ToString();

                   objDBAccess.closeConn();

                    txtpriddes.Text = iddes;
                    txtdate.Text = date;
                    txttime.Text = time;
                    txtdata1.Text = data1;
                    txtdata2.Text = data2;
                    txtdata3.Text = data3;
                    txtdata4.Text = data4;
                    txtdata5.Text = data5;
                    txtdata6.Text = data6;
                    txtdata7.Text = data7;
                    txtdata8.Text = data8;


                }
                else
                {
                    MessageBox.Show("NO DATA AVAILABLE.... ");

                }
            }
            
        }

        private void btnprvfile_Click(object sender, EventArgs e)
        {
            ip = ip - 1;
            /*
           string query = "select * from Datastore Where PRID ='" + srchid + " ' ";
           objDBAccess.readDatathroughAdapter(query, dtUsers); string id = dtUsers.Rows[ip]["PRID"].ToString();
           */
            if (ip >=0)
            {
                
                string iddes = dtUsers.Rows[ip]["PRIDDES"].ToString();
                String date = dtUsers.Rows[ip]["DATE"].ToString();
                String time = dtUsers.Rows[ip]["TIME"].ToString();
                String data1 = dtUsers.Rows[ip]["DATA1"].ToString();
                String data2 = dtUsers.Rows[ip]["DATA2"].ToString();
                String data3 = dtUsers.Rows[ip]["DATA3"].ToString();
                String data4 = dtUsers.Rows[ip]["DATA4"].ToString();
                String data5 = dtUsers.Rows[ip]["DATA5"].ToString();
                String data6 = dtUsers.Rows[ip]["DATA6"].ToString();
                String data7 = dtUsers.Rows[ip]["DATA7"].ToString();
                String data8 = dtUsers.Rows[ip]["DATA8"].ToString();

                objDBAccess.closeConn();

                txtpriddes.Text = iddes;
                txtdate.Text = date;
                txttime.Text = time;
                txtdata1.Text = data1;
                txtdata2.Text = data2;
                txtdata3.Text = data3;
                txtdata4.Text = data4;
                txtdata5.Text = data5;
                txtdata6.Text = data6;
                txtdata7.Text = data7;
                txtdata8.Text = data8;
                textBox1.Text = ip.ToString();
                btnnxtfile.Visible = true;
            }
            else
            {
               
                btnprvfile.Visible = false;
                
            }

        }
        

        private void btnnxtfile_Click(object sender, EventArgs e)
        {

            ip = ip + 1;

            /*
            string query = "select * from Datastore Where PRID ='" + srchid + " ' ";
            objDBAccess.readDatathroughAdapter(query, dtUsers); string id = dtUsers.Rows[ip]["PRID"].ToString();
            */
            if (ip < dtUsers.Rows.Count )
            {
                
                string iddes = dtUsers.Rows[ip]["PRIDDES"].ToString();
                String date = dtUsers.Rows[ip]["DATE"].ToString();
                String time = dtUsers.Rows[ip]["TIME"].ToString();
                String data1 = dtUsers.Rows[ip]["DATA1"].ToString();
                String data2 = dtUsers.Rows[ip]["DATA2"].ToString();
                String data3 = dtUsers.Rows[ip]["DATA3"].ToString();
                String data4 = dtUsers.Rows[ip]["DATA4"].ToString();
                String data5 = dtUsers.Rows[ip]["DATA5"].ToString();
                String data6 = dtUsers.Rows[ip]["DATA6"].ToString();
                String data7 = dtUsers.Rows[ip]["DATA7"].ToString();
                String data8 = dtUsers.Rows[ip]["DATA8"].ToString();

                objDBAccess.closeConn();

                txtpriddes.Text = iddes;
                txtdate.Text = date;
                txttime.Text = time;
                txtdata1.Text = data1;
                txtdata2.Text = data2;
                txtdata3.Text = data3;
                txtdata4.Text = data4;
                txtdata5.Text = data5;
                txtdata6.Text = data6;
                txtdata7.Text = data7;
                txtdata8.Text = data8;
                textBox1.Text = ip.ToString();
                btnprvfile.Visible = true;
            }
            else
            {
                btnnxtfile.Visible = false;
                
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            String userid = txtid.Text;
            String useriddes = txtpriddes.Text;
            String tempdate = txtdate.Text;
            DateTime userDate = Convert.ToDateTime(tempdate);
            String tempTime = txttime.Text;
            DateTime userTime = Convert.ToDateTime(tempTime);
            String userdata1 = txtdata1.Text;
            String userdata2 = txtdata2.Text;
            String userdata3 = txtdata3.Text;
            String userdata4 = txtdata4.Text;
            String userdata5 = txtdata5.Text;
            String userdata6 = txtdata6.Text;
            String userdata7 = txtdata7.Text;
            String userdata8 = txtdata8.Text;
            

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
            int row = objDBAccess.executeQuery(insertCommand);
            if (row == 1)
            {
                txtid.Text = "";
                txtpriddes.Text = "";
                txtdate.Text = "";
                txttime.Text = "";
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

        }
    }
}
