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
    public partial class RemoveCashier : Form
    {
        public RemoveCashier()
        {
            InitializeComponent();
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
            SqlConnection con = new SqlConnection(path);
            con.Open();
            string Query = "SELECT * FROM Cashier c";
            Console.WriteLine(Query);
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            con.Close();
        
    }

        private void button3_Click(object sender, EventArgs e)
        {
            RemoveServer removeServer   = new RemoveServer();
            removeServer.Show();
            this.Hide();
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

        private void DeleteCashierById(int cashierId)
        {
            string connectionString = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";

            // SQL DELETE statement with parameter
            string deleteQuery = "DELETE FROM CashierAssignment WHERE CashierID = @CashierID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    // Add parameter to the command
                    command.Parameters.AddWithValue("@CashierID", cashierId);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show(rowsAffected + " row(s) deleted.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting data: " + ex.Message);
                    }
                }
            }
        }
        public void UpdateCashierStatus(int cashierId)
        {
            string connectionString = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string updateQuery = "UPDATE Cashier SET Status = 'Unemployed' WHERE cashier_Id = @cashierID";

                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@cashierID", cashierId);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"Rows affected: {rowsAffected}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error updating cashier status: " + ex.Message);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int cashierId;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter some data first");
                return;
            }

            // Validate and parse the cashier ID
            if (!int.TryParse(textBox1.Text, out cashierId))
            {
                MessageBox.Show("Invalid cashier ID. Please enter a valid numeric value.");
                return;
            }

            DeleteCashierById(cashierId);
            UpdateCashierStatus(cashierId);

        }
    }
}
