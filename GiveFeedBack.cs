using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class GiveFeedBack : Form
    {
        public GiveFeedBack()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string getOrderIDs()
        {
            string connectionString = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
            string query = "SELECT MAX(OrderID) FROM [order]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                object result = command.ExecuteScalar();

                string resultString = (result != DBNull.Value) ? result.ToString() : "1";

                return resultString;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            string comments = textBox2.Text;
            string customerid = Form2.currentId;
            string rating = comboBox1.Text;
            
            if (string.IsNullOrWhiteSpace(comments))
            {
                MessageBox.Show("Please enter comments.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(rating))
            {
                MessageBox.Show("Customer ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Proceed with further operations since both fields are not empty
            // Your code here...

            DateTime time = DateTime.Now;
            string orderId = getOrderIDs();

            string insertQuery = "INSERT INTO Feedback (CustomerID, Timing, Comments, Ratting, OrderID) " +
                     "VALUES (@CustomerID, @Timing, @Comments, @Rating, @OrderID)";
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True";
            SqlConnection connection = new SqlConnection(path);
            connection.Open();
            SqlCommand command = new SqlCommand(insertQuery, connection);
            command.Parameters.AddWithValue("@CustomerID", customerid);
            command.Parameters.AddWithValue("@Timing", time);
            command.Parameters.AddWithValue("@Comments", comments);
            command.Parameters.AddWithValue("@Rating", float.Parse(rating)); // Assuming rating is float
            command.Parameters.AddWithValue("@OrderID", orderId);

            command.ExecuteNonQuery();
            this.Close();
            MessageBox.Show("Thank you for the feedback");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
