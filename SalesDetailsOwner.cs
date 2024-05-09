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

namespace CafeManagementSystem
{
    public partial class SalesDetailsOwner : Form
    {
        public SalesDetailsOwner()
        {
            InitializeComponent();
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
            SqlConnection con = new SqlConnection(path);
            con.Open();
            string Query = "SELECT * FROM sales c";
            Console.WriteLine(Query);
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Owner owner = new Owner();
            owner.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Most Sales")
            {
                string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
                SqlConnection con = new SqlConnection(path);
                con.Open();
                string Query = "SELECT itemname,Count(c.Salesid)*SUM(Quantity)as TotalSales FROM sales c group by itemName\r\nhaving Count(c.Salesid)*SUM(Quantity)=(select MAX(TotalSales) from \r\n(SELECT itemname,Count(c.Salesid)*SUM(Quantity)as TotalSales FROM sales c group by itemName)as tabes )";
                Console.WriteLine(Query);
                SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                con.Close();
            }
            else if (comboBox1.Text.Equals("Least Sales"))
            {
                string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
                SqlConnection con = new SqlConnection(path);
                con.Open();
                string Query = "SELECT itemname,Count(c.Salesid)*SUM(Quantity)as TotalSales FROM sales c group by itemName\r\nhaving Count(c.Salesid)*SUM(Quantity)=(select MIN(TotalSales) from \r\n(SELECT itemname,Count(c.Salesid)*SUM(Quantity)as TotalSales FROM sales c group by itemName)as tabes )";
                Console.WriteLine(Query);
                SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                con.Close();
            }
            else {
                string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
                SqlConnection con = new SqlConnection(path);
                con.Open();
                string Query = "SELECT * FROM sales c";
                Console.WriteLine(Query);
                SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                con.Close();
            }
        }
    }
}
