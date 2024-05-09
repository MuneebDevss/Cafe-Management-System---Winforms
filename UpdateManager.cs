using System.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class UpdateManager : Form
    {
        public UpdateManager()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }

        private void InsertCashier(string name,string password, string phoneNumber, string email, float salary)
        {
            string connectionString = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";

            // SQL INSERT statement with parameters
            string insertQuery = "INSERT INTO Manager (manager_id,Name, PhoneNumber, Salary,Email,Password) VALUES (1,@Name, @PhoneNumber, @Salary,@email,@password)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);
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
        

    public void RemoveManager(int managerId)
    {
        string connectionString = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string deleteQuery = "DELETE FROM Manager WHERE manager_id = @managerID";

            SqlCommand command = new SqlCommand(deleteQuery, connection);
            command.Parameters.AddWithValue("@managerID", managerId);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    
                }
                else
                {
                    MessageBox.Show("Manager not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing manager: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void button1_Click_1(object sender, System.EventArgs e)
        {
            string name = Names.Text;
            string phoneNumber = Phone.Text;
            string email = Emails.Text; // Assuming textBoxEmail is your email input field
            string passwrd=password.Text;
            float salary;
            if (string.IsNullOrWhiteSpace(name)|| string.IsNullOrWhiteSpace(passwrd))
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
            RemoveManager(1);
            InsertCashier(name,passwrd, phoneNumber, email, salary);
            MessageBox.Show("Staff has been update");
        }

        private void Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UpdateManager_Load(object sender, EventArgs e)
        {

        }

        private void Salary_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Owner owner =new Owner();
            owner.Show();
            this.Hide();
        }

        private void Names_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
