using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class Cashiermain : Form
    {
        List<Bill> bills;
        public Cashiermain()
        {

            InitializeComponent();
            bills = new List<Bill>();   
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
            SqlConnection con = new SqlConnection(path);
            con.Open();
            string Query = "select * from [Order]  where orderstatus!='confirmed'";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            con.Close();
        }

        private void Cashiermain_Load(object sender, EventArgs e)
        {

        }
        string getBillIDs()
        {
            string connectionString = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
            string query = "SELECT MAX(OrderID) + 1 FROM Bill";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                object result = command.ExecuteScalar();

                string resultString = (result != DBNull.Value) ? result.ToString() : "1";

                return resultString;
            }
        }
        private void generateBill()
        {
            string queryToInsertInBill = "INSERT INTO Bill(Amount, CustomerID, OrderID, BillDate, CashierID) VALUES(@Amount, @CustomerId, @OrderId, @BillDate, @CashierId)";
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";

            using (SqlConnection connection = new SqlConnection(path))
            {
                connection.Open();  // Open the connection before executing commands

                foreach (Bill bill in bills)
                {
                    using (SqlCommand insertInBillCommand = new SqlCommand(queryToInsertInBill, connection))
                    {
                        insertInBillCommand.Parameters.AddWithValue("@Amount", bill.price);
                        insertInBillCommand.Parameters.AddWithValue("@CustomerId", bill.customerId);
                        insertInBillCommand.Parameters.AddWithValue("@OrderId", bill.orderId);
                        insertInBillCommand.Parameters.AddWithValue("@BillDate", DateTime.Now);
                        insertInBillCommand.Parameters.AddWithValue("@CashierId", bill.cashierId);
                        insertInBillCommand.ExecuteNonQuery();
                    }
                }

                connection.Close();  // Close the connection after executing all commands
            }
        }


        private void insertBill(string billid, decimal price,string customerId,string orderId,string cashierId)
        {
            Bill bill = new Bill(billid,price, customerId, orderId, cashierId);
            bills.Add(bill);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("")|| (textBox2.Text.Equals("")))
            {
                MessageBox.Show("Please enter some data first");
                return;
            }
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
            int customerId = int.Parse(textBox1.Text);  // Assuming customerId is an integer
            int cashierId = int.Parse(textBox2.Text);  // Assuming cashierId is an integer

            string query = "SELECT COUNT(*) FROM [Order] WHERE CustomerID = @ID";

            using (SqlConnection conn = new SqlConnection(path))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ID", customerId);
                    int rowCount = (int)command.ExecuteScalar();

                    if (rowCount > 0)
                    {
                        string queryToGetCashierId = "SELECT COUNT(*) FROM CashierAssignment WHERE CashierID = @CashierId";
                        using (SqlCommand getCashierIdCommand = new SqlCommand(queryToGetCashierId, conn))
                        {
                            getCashierIdCommand.Parameters.AddWithValue("@CashierId", cashierId);
                            int cashierRowCount = (int)getCashierIdCommand.ExecuteScalar();

                            if (cashierRowCount > 0)
                            {
                                string queryToFetchDetails = "SELECT  OrderID, SUM(TotalPrice) FROM [Order] WHERE CustomerID = @CustomerId group by OrderID";

                                using (SqlCommand fetchDetailsCommand = new SqlCommand(queryToFetchDetails, conn))
                                {
                                    fetchDetailsCommand.Parameters.AddWithValue("@CustomerId", customerId);

                                    using (SqlDataReader reader = fetchDetailsCommand.ExecuteReader())
                                    {

                                        string billid = getBillIDs();
                                        while (reader.Read())
                                        {
                                            int orderId = reader.GetInt32(0);
                                            decimal price = reader.GetDecimal(1);

                                            insertBill(billid,price, customerId.ToString(), orderId.ToString(), cashierId.ToString());

                                        }
                                        reader.Close();  // Close the DataReader after reading all data
                                        generateBill();
                                    }
                                }

                                BillGenerate billGenerate = new BillGenerate();
                                billGenerate.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Cashier ID does not exist in the CashierAssignment table.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No orders found for the given Customer ID.");
                    }
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        public void GenerateBillForCustomer(int customerId, int cashierIdEntered)
        {
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainHome mainHome   = new MainHome();
            mainHome.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
            
