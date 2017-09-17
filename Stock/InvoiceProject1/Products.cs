﻿using System;
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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }
        
        private void statuscomboBox1_load(object sender, EventArgs e)
        {

        }

        private void Products_Load(object sender, EventArgs e)
        {
            comboBox1status.SelectedIndex = 0;
            LoadData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void productaddbutton2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=CASSIDY-PC\\SQLEXPRESS;Initial Catalog=StockTest1;Integrated Security=True");
            // Insert Logic 
            con.Open();
            bool status = false;
            if (comboBox1status.SelectedIndex == 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }

            var sqlQuery = "";
            if(IfProductsExists(con, productcodetextBox1.Text))
            {
                sqlQuery = @"UPDATE [Products] SET [ProductName] = '" + productnametextBox2.Text + "' ,[ProductStatus] = '" + status + "' WHERE [ProductCode] = '" + productcodetextBox1.Text + "'";
            }

            else
            {
                sqlQuery = @"INSERT INTO [dbo].[Products] ([ProductCode],[ProductName],[ProductStatus]) VALUES
                            ('" + productcodetextBox1.Text + "','" + productnametextBox2.Text + "','" + status + "')";
            }
              
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //Reading data
            LoadData();

        }                     

        private bool IfProductsExists(SqlConnection con, string productCode)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select 1 from [dbo].[Products] WHERE [ProductCode]='" + productCode + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count > 0)
                return true;
            else
                return false;
        } 
        public void LoadData() {
            SqlConnection con = new SqlConnection("Data Source=CASSIDY-PC\\SQLEXPRESS;Initial Catalog=StockTest1;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select * from [dbo].[Products]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["ProductCode"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["ProductName"].ToString();
                if ((bool)item["ProductStatus"])
                {
                    dataGridView1.Rows[n].Cells[2].Value = "Active";
                }
                else
                {
                    dataGridView1.Rows[n].Cells[2].Value = "Deactive";
                }                
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            productcodetextBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            productnametextBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "Active")
            {
                comboBox1status.SelectedIndex = 0;
            }
            else
            {
                comboBox1status.SelectedIndex = 1;
            }
            dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void productdeletebutton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=CASSIDY-PC\\SQLEXPRESS;Initial Catalog=StockTest1;Integrated Security=True");
            var sqlQuery = "";
            if (IfProductsExists(con, productcodetextBox1.Text))
            {
                con.Open();
                sqlQuery = @"DELETE FROM [Products] WHERE [ProductCode] = '" + productcodetextBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("Record Does Not Exists...!");
            }
            //Reading data
            LoadData();
        }
    }
}
