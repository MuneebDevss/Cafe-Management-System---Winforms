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
    public partial class OwnerFeedback : Form
    {
        public OwnerFeedback()
        {
            InitializeComponent();
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
            SqlConnection con = new SqlConnection(path);
            con.Open();
            string Query = "SELECT * FROM Feedback c";
            Console.WriteLine(Query);
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Owner owner = new Owner();
            owner.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Most Rating"))
            {
                string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
                SqlConnection con = new SqlConnection(path);
                con.Open();
                string Query = "select o.OrderID,Count(f.Feedback_id) as Most_rating from  Feedback f join [Order] o on \r\n o.OrderID=f.OrderID\r\n join MenuItems m on o.ItemID=m.ItemID\r\n where f.Ratting=5\r\n group by o.OrderID having COUNT(f.Feedback_id)=(select Max(Most_rating) from (\r\n select o.OrderID,Count(f.Feedback_id) as Most_rating from  Feedback f join [Order] o on \r\n o.OrderID=f.OrderID\r\n join MenuItems m on o.ItemID=m.ItemID\r\n where f.Ratting=5\r\n group by o.OrderID\r\n )as ratingtable)";
                Console.WriteLine(Query);
                SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                con.Close();
            }
            else if (comboBox1.Text.Equals("Least Rating"))
            {
                string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
                SqlConnection con = new SqlConnection(path);
                con.Open();
                string Query = "select o.OrderID,Count(f.Feedback_id) as Least_rating from  Feedback f join [Order] o on \r\n o.OrderID=f.OrderID\r\n join MenuItems m on o.ItemID=m.ItemID\r\n where f.Ratting=5\r\n group by o.OrderID having COUNT(f.Feedback_id)=(select Max(Most_rating) from (\r\n select o.OrderID,Count(f.Feedback_id) as Most_rating from  Feedback f join [Order] o on \r\n o.OrderID=f.OrderID\r\n join MenuItems m on o.ItemID=m.ItemID\r\n where f.Ratting=1\r\n group by o.OrderID\r\n )as ratingtable)";
                Console.WriteLine(Query);
                SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                con.Close();
            }
            else 
            {
                string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
                SqlConnection con = new SqlConnection(path);
                con.Open();
                string Query = "SELECT * FROM Feedback c";
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
