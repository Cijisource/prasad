using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Singin : Form
    {
        public static string id, name, email, password, country;
        DBAccess objDbAccess = new DBAccess();

        private void btnmodify_Click(object sender, EventArgs e)
        {
            this.Hide();
            modify home = new modify();
            home.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        

        private void btnreports_Click(object sender, EventArgs e)
        {
            
            Reports reports = new Reports();
            reports.Show();
        }

        private void btndatacap_Click(object sender, EventArgs e)
        {
            this.Hide();
            datacapture singup = new datacapture();
            singup.Show();
        }

        DataTable dtUsers = new DataTable();
        public Singin()
        {
            InitializeComponent();
        }

        

        
    }
}
