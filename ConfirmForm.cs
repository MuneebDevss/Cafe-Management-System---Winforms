using System.Data.SqlClient;
using System.Data;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;

namespace CafeManagementSystem
{
   
    public partial class ConfirmForm : Form
    {
        
        List<Order> orders1;
        
        public ConfirmForm(List<Order> orders)
        {
            
            InitializeComponent();
            orders1 = orders;
            textBox2.Text = GetTotalPrice().ToString();
            LoadData();
        }
        private void LoadData()
        {
            // Assuming the DataGridView has columns already defined (e.g., OrderID, CustomerID, TotalPrice, ItemID, OrderTime)
            // You may need to adjust column names or properties based on your actual DataGridView setup

            // Add rows to the DataGridView based on the data in orders1 list
            ;

            foreach (var order in orders1)
            {

                dataGridView1.Rows.Add( order.orderid, order.TotalPrice, order.ItemID, DateTime.Now);
            }
        }
       

        private void button3_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Your order has been cancelled");
            CustomerHome customerHome = new CustomerHome();
            customerHome.Show();
            this.Hide();
        }
        string getOrderIDs()
        {
            string connectionString = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
            string query = "SELECT MAX(OrderID) + 1 FROM [Order]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                object result = command.ExecuteScalar();

                string resultString = (result != DBNull.Value) ? result.ToString() : "1";

               return resultString;
            }
        }
        private void button2_Click(object sender, System.EventArgs e)
        {
            string totalorders = getOrderIDs();
            // Insert into [Order] table
            foreach (Order orders in orders1)
            {
                string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
                SqlConnection con = new SqlConnection(path);
                con.Open();
                string insertQuery = "INSERT INTO [Order] (OrderID,CustomerID, TotalPrice, ItemID, OrderTime,orderstatus) VALUES (@orderid,@customerId, @totalPrice, @itemId, GETDATE(),@Status)";
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                {
                    decimal prices = decimal.Parse(orders.TotalPrice) - (decimal.Parse(orders.TotalPrice) * (decimal.Parse(orders.discount) / 100));

                    insertCmd.Parameters.AddWithValue("@customerId", orders.CustomerID);
                    insertCmd.Parameters.AddWithValue("@totalPrice", prices.ToString());
                    insertCmd.Parameters.AddWithValue("@itemId", orders.ItemID);
                    insertCmd.Parameters.AddWithValue("@orderid", totalorders);
                    insertCmd.Parameters.AddWithValue("Status", "Not Confirmed");

                    int rowsAffected = insertCmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Order inserted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Failed to insert order.");
                    }
                }

                con.Close();

            }
            MessageBox.Show("Your order has been added");
            CustomerHome customerHome = new CustomerHome();
            customerHome.Show();
            this.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MakeOrderFixed makeOrderFixed = new MakeOrderFixed();
            makeOrderFixed.Show();
            this.Hide();
        }
        public decimal GetTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (var order in orders1)
            {
                decimal price = 0;
                decimal discount = 0;
                if (decimal.TryParse(order.TotalPrice, out price) && decimal.TryParse(order.discount, out discount))
                {
                    totalPrice += price - (price * (discount / 100));
                }
                else
                {
                    Console.WriteLine($"Error parsing TotalPrice for OrderID {order.ItemID}");
                    // Handle parsing errors as needed
                }
            }

            return totalPrice;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Please enter some data first");
                return;
            }
            string orderId = textBox1.Text;
            Order tempOrder = null;

            // Find the order with the specified order ID
            foreach (Order order in orders1)
            {
                if (orderId.Equals(order.orderid))
                {
                    tempOrder = order;
                    break; // Exit the loop once the order is found
                }
            }

            if (tempOrder != null)
            {
                orders1.Remove(tempOrder); // Remove the found order from the list
                MessageBox.Show("Order removed successfully.");
                textBox2.Text = GetTotalPrice().ToString(); // Update total price
                dataGridView1.Rows.Clear(); // Clear the DataGridView
                LoadData(); // Reload data into the DataGridView
            }
            else
            {
                MessageBox.Show("Order not found.");
            }



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrderMenu_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text)||textBox2.Text=="0")
            {
                MessageBox.Show("Please enter make some order.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GiveFeedBack giveFeedBack = new GiveFeedBack();
            giveFeedBack.Show();   
        }
    }
}