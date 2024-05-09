using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class UpdateSalaryCashier : Form
    {
        public UpdateSalaryCashier()
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateSalaryServer updateSalaryServer = new UpdateSalaryServer();
            updateSalaryServer.Show();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateSalaryManager updateSalaryManager = new UpdateSalaryManager();
            updateSalaryManager.Show();
            this.Close();
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";

            // Get the new salary from textBox2
            string newSalary = textBox2.Text;
            string CashierID= textBox1.Text;
            // SQL UPDATE statement with parameters
            string updateQuery = "UPDATE Cashier SET Salary = @NewSalary WHERE cashier_id = @CashierID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@NewSalary", newSalary);
                    // Assuming you have a variable to store the selected cashier's ID
                    // Replace cashierIdVariable with the actual variable containing the ID
                    command.Parameters.AddWithValue("@CashierID", CashierID);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        string Query = " select c.cashier_id,c.Name,c.PhoneNumber,c.Salary from Cashier c";
                        SqlDataAdapter adapter = new SqlDataAdapter(Query, connection);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                        connection.Close();
                        MessageBox.Show(rowsAffected + " row(s) updated.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating salary: " + ex.Message);
                    }
                }
            }
        }

        private void UpdateSalaryCashier_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Assigned"))
            {
                string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
                SqlConnection con = new SqlConnection(path);
                con.Open();
                string Query = "SELECT ca.assignmentid, ca.Name AS AssignmentName, ca.assignedfrom, ca.assignedto, \r\n       cash.Name AS CashierName, cash.PhoneNumber, cash.Salary AS CashierSalary, cash.Status AS CashierStatus\r\nFROM CashierAssignment ca\r\nINNER JOIN Cashier cash ON ca.CashierID = cash.cashier_id;\r\n";
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
                string Query = "SELECT * FROM Cashier c";
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
