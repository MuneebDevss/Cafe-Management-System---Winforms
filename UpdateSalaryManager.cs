using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;

namespace CafeManagementSystem
{
    public partial class UpdateSalaryManager : Form
    {
        public UpdateSalaryManager()
        {
            InitializeComponent();
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
            SqlConnection con = new SqlConnection(path);
            con.Open();
            string Query = "SELECT manager_id,Name,Email,Salary,PhoneNumber FROM Manager c";
            Console.WriteLine(Query);
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateSalaryServer update = new UpdateSalaryServer();
            update.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateSalaryCashier update = new UpdateSalaryCashier();
            update.Show();
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
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection con = new SqlConnection(path);
            con.Open();
            string Query = " select c.cashier_id,c.Name,c.PhoneNumber,c.Salary from Manager c";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            con.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";

            // Get the new salary from textBox2
            string newSalary = textBox2.Text;
            string CashierID = "1";
            // SQL UPDATE statement with parameters
            string updateQuery = "UPDATE Manager SET Salary = @NewSalary WHERE manager_id = @CashierID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@NewSalary", newSalary);
                    // Assuming you have a variable to store the selected cashier's ID
                    // Replace cashierIdVariable with the actual variable containing the ID
                    command.Parameters.AddWithValue("@CashierID", 1);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        string Query = "SELECT manager_id,Name,Email,Salary,PhoneNumber FROM Manager c";
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
    }
    }
