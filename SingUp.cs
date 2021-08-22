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
    public partial class SingUp : Form
    {
        DBAccess ObjDBAccess   = new DBAccess();
        public SingUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = txtName.Text;
            String useremail = txtEmail.Text;
            String userpassword = txtPassword.Text;
            String usercountry = txtCountry.Text;

            if (username.Equals(""))
            {
                MessageBox.Show("Please enter your user name");
            }
            else if (useremail.Equals(""))
            {
                MessageBox.Show("Please enter your Email");
            }
            else if (userpassword.Equals(""))
            {
                MessageBox.Show("Please enter your Password");
            }
            else if (usercountry.Equals(""))
            {
                MessageBox.Show("Please enter your Country");
            }
            else
            {
                SqlCommand insertCommand = new SqlCommand("insert into signUp(Name,Email,Password,Country) values (@username, @useremail, @userpassword, @usercountry)");

                insertCommand.Parameters.AddWithValue("@username", username);
                insertCommand.Parameters.AddWithValue("@useremail", useremail);
                insertCommand.Parameters.AddWithValue("@userpassword", userpassword);
                insertCommand.Parameters.AddWithValue("@usercountry", usercountry);

                int row =ObjDBAccess.executeQuery(insertCommand);
                if(row == 1)
                {
                    MessageBox.Show("Account is Created Successfully ");
                    txtName.Text = "";
                    txtEmail.Text = "";
                    txtPassword.Text = "";
                    txtCountry.Text = "";

              
                }
                else 
                {
                    MessageBox.Show("Error occured Try Again ");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}


