using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceProject1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            //Need to do: setup SQL and then check login & password
            SqlConnection con = new SqlConnection("Data Source=CASSIDY-PC\\SQLEXPRESS;Initial Catalog=StockTest1;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT *
                 FROM[dbo].[Login] where UserName = '"+ usernameTexbox.Text +"' and Password = '"+ passwordTextbox.Text +"'",con);


            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count == 1)
                {
                    this.Hide();
                    StockMain main = new StockMain();
                    main.Show(); 
                }
            else
            {
                MessageBox.Show("Invalid Username or Password dipshit!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearbutton_Click(sender, e);


            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            usernameTexbox.Text = "";
            passwordTextbox.Clear();
            usernameTexbox.Focus();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
