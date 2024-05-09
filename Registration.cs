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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }
        
    public bool DoesCustomerExist(string email)
    {
        string connectionString = "Your_Connection_String_Here";
        bool exists = false;

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT COUNT(*) FROM Customers WHERE email = @Email";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Email", email);

            try
            {
                connection.Open();
                int count = (int)command.ExecuteScalar();
                exists = count > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error checking customer existence: " + ex.Message);
            }
        }

        return exists;
    }

    private void button2_Click(object sender, EventArgs e)
        {

            string Name = textBox1.Text + " " + textBox2.Text;
            string email = textBox3.Text;
            string password = textBox4.Text;
            string confirmPassword = textBox5.Text;
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Name and Email cannot be empty.");
                return; // Stop further execution
            }

            bool exists = DoesCustomerExist(email);
            if (exists) 
            {
                MessageBox.Show("There is acount exists with this email");
                return;
            }
            // Validate password is at least 8 characters long
            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.");
                return; // Stop further execution
            }

            // Validate password and confirmPassword match
            if (password != confirmPassword)
            {
                MessageBox.Show("Password and Confirm Password do not match.");
                return; // Stop further execution
            }
            // Assuming you have a SQL connection and command set up
            string insertQuery = "INSERT INTO Customer (Name, Email, Password, ContactInformation) VALUES (@Name, @Email, @Password, @ContactInformation)";
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
            SqlConnection con = new SqlConnection(path);
            con.Open();
            SqlCommand cmd = new SqlCommand(insertQuery, con);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@ContactInformation", confirmPassword); // Assuming confirmPassword is meant to represent contact information

            // Execute the command
            cmd.ExecuteNonQuery();
            con.Close();


        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2("Customer");
            form2.Show();
            this.Hide();
        }

        private void lblManagementSystem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblOspital_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
