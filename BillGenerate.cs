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
    public partial class BillGenerate : Form
    {
        public BillGenerate()
        {
            InitializeComponent();
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
            SqlConnection con = new SqlConnection(path);
            con.Open();
            string Query = "SELECT * FROM Bill c";
            Console.WriteLine(Query);
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            con.Close();
        }
        void genereateReceipt() 
        {
            string query = @"SELECT c.Name AS CustomerName, o.OrderID, o.TotalPrice, b.BillID, b.Amount, cash.Name AS CashierName
                FROM [Order] o
                INNER JOIN Customer c ON o.CustomerID = c.CustomerID
                INNER JOIN Bill b ON o.OrderID = b.OrderID
                INNER JOIN Cashier cash ON b.CashierID = cash.cashier_id";

            using (SqlConnection connection = new SqlConnection("Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string customerName = reader["CustomerName"].ToString();
                            int orderID = (int)reader["OrderID"];
                            decimal totalPrice = (decimal)reader["TotalPrice"];
                            int billID = (int)reader["BillID"];
                            decimal amount = (decimal)reader["Amount"];
                            string cashierName = reader["CashierName"].ToString();

                            // Use the retrieved dta as needed
                            MessageBox.Show($"Receipt\nCustomer Name: {customerName}, Order ID: {orderID}, Total Price: {totalPrice}, Bill ID: {billID}, Amount: {amount}, Cashier Name: {cashierName}");
                        }
                    }
                }
            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Connection string for your database
            string connectionString = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";

            // SQL command to insert sales records into the Sales table
            string insertSalesQuery = @"INSERT INTO Sales (CustomerID, itemName, Price, Quantity)
                                SELECT  DISTINCT b.CustomerID, mi.Name, b.Amount, 1
                                FROM Bill b
                                INNER JOIN [Order] o ON b.OrderID = o.OrderID
                                INNER JOIN MenuItems mi ON o.ItemID = mi.ItemID";




            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Execute the SQL command to insert sales records into the Sales table
                    SqlCommand insertSalesCommand = new SqlCommand(insertSalesQuery, connection);
                    insertSalesCommand.ExecuteNonQuery();
                    MessageBox.Show("Sales records updated.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    genereateReceipt();
                    string tablename = "Bill"; // Specify the table name you want to delete from

                    // Assuming you have a SQL connection and command set up
                    string deleteQuery = $"DELETE FROM {tablename}";

                    SqlCommand cmd = new SqlCommand(deleteQuery, connection);

                    // Execute the command
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string tablename = "Bill"; // Specify the table name you want to delete from

            // Assuming you have a SQL connection and command set up
            string deleteQuery = $"DELETE FROM {tablename}";

            SqlCommand cmd = new SqlCommand(deleteQuery, sqlConnection);

            // Execute the command
            cmd.ExecuteNonQuery();

            Cashiermain cashiermain = new Cashiermain();
            cashiermain.Show();
            this.Hide();
        }
    }
}
