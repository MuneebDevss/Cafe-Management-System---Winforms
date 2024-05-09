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
    public partial class CancelOrder : Form
    {
        public CancelOrder()
        {
            InitializeComponent();
            MyOrdera();
        }
        private void MyOrdera()
        {
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
            using (SqlConnection con = new SqlConnection(path))
            {
                con.Open();
                string customer = Form2.currentId;
                string query = "SELECT * FROM [Order] WHERE CustomerID = @customer";
                Console.WriteLine(query);
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@customer", customer);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            CustomerHome customerHome = new CustomerHome(); 
            customerHome.Show();
            this.Hide();    
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("")) 
            {
                MessageBox.Show("Please enter some data first");
                return;
            }
            string orderIdToDelete = textBox1.Text; // Assuming textBox1 contains the OrderID to delete
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";

            using (SqlConnection con = new SqlConnection(path))
            {
                con.Open();

                // Create a SQL DELETE statement to delete the order
                string deleteQuery = "DELETE FROM [Order] WHERE OrderID = @orderId";

                using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                {
                    cmd.Parameters.AddWithValue("@orderId", orderIdToDelete);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Order deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Order not found or deletion failed.");
                    }
                }
            }

        }
    }
}
