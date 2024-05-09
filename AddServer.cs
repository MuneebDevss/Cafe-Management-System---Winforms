using System.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class AddServer : Form
    {
        public AddServer()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            AddCashier cashier = new AddCashier();
            cashier.Show();
            this.Hide();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Owner owner = new Owner();
            owner.Show();
            this.Hide();
        }
        private void InsertCashier(string name, string phoneNumber, string email, float salary)
        {
            string connectionString = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";

            // SQL INSERT statement with parameters
            string insertQuery = "INSERT INTO Servingstaff (Name, PhoneNumber, Salary) VALUES (@Name, @PhoneNumber, @Salary)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@Salary", salary);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show(rowsAffected + " row(s) inserted.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error inserting data: " + ex.Message);
                    }
                }
            }
        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            string name = Names.Text;
            string phoneNumber = Phone.Text;
            string email = Emails.Text; // Assuming textBoxEmail is your email input field
            float salary;

            // Validate and parse the salary
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate email format
            if (!string.IsNullOrWhiteSpace(email) && !email.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validate and parse the salary
            if (!float.TryParse(Salary.Text, out salary))
            {
                MessageBox.Show("Invalid salary format. Please enter a valid numeric value.");
                return;
            }
            InsertCashier(name, phoneNumber, email, salary);
            MessageBox.Show("Staff has been update");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateManager updateManager = new UpdateManager();
            updateManager.Show();
            this.Hide();
        }
    }
}
