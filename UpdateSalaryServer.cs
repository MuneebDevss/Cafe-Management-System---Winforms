using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace CafeManagementSystem
{
    public partial class UpdateSalaryServer : Form
    {
        public UpdateSalaryServer()
        {
            InitializeComponent();
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
            SqlConnection con = new SqlConnection(path);
            con.Open();
            string Query = "SELECT * FROM Servingstaff c";
            Console.WriteLine(Query);
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateSalaryCashier cashier = new UpdateSalaryCashier();
            cashier.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateSalaryManager cashier = new UpdateSalaryManager();
            cashier.Show();
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

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";

            // Get the new salary from textBox2
            string newSalary = textBox2.Text;
            string CashierID = textBox1.Text;
            // SQL UPDATE statement with parameters
            string updateQuery = "UPDATE Servingstaff SET Salary = @NewSalary WHERE serving_id = @CashierID";

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
                        string Query = "SELECT * FROM Servingstaff c";
                        Console.WriteLine(Query);
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

        private void UpdateSalaryServer_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Assigned"))
            {
                string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
                SqlConnection con = new SqlConnection(path);
                con.Open();
                string Query = "SELECT sa.assignmentid, sa.Name AS AssignmentName, sa.assignedfrom, sa.assignedto, \r\n       ss.Name AS StaffName, ss.PhoneNumber, ss.Salary AS StaffSalary\r\nFROM ServicestaffAssignment sa\r\nINNER JOIN Servingstaff ss ON sa.ServingID = ss.serving_id;\r\n";
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
                string Query = "SELECT * FROM Servingstaff c";
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
