using System;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeManagementSystem
{

    public partial class Form2 : Form
    {

        public static string currentId = "1";
        private string UserType;
        public Form2(string userType)
        {
            InitializeComponent();
            UserType = userType;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Email.Text.Equals(""))
            {
                MessageBox.Show("Please enter some data first");
                return;
            }
            if (Password.Text.Equals(""))
            {
                MessageBox.Show("Please enter some data first");
                return;
            }
            if (UserType == "Customer")
            {
                string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
                SqlConnection con = new SqlConnection(path);
                con.Open();
                string email = Email.Text;
                string password = Password.Text;
                string Querry = "SELECT CustomerID FROM Customer WHERE Email=@Email AND Password=@Password";
                SqlCommand command = new SqlCommand(Querry, con);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                object result = command.ExecuteScalar();

                con.Close();
                if (result == null)
                {
                    MessageBox.Show("No user found with this email or password ");
                }
                else
                {
                    currentId = result.ToString();
                    CustomerHome customerHome = new CustomerHome();
                    customerHome.Show();
                    this.Hide();
                }
            }
            else if (UserType == "Manager") 
            {
                string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
                SqlConnection con = new SqlConnection(path);
                con.Open();
                string email = Email.Text;
                string password = Password.Text;
                string Querry = "SELECT manager_id FROM Manager WHERE Email=@Email AND Password=@Password";
                SqlCommand command = new SqlCommand(Querry, con);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                object result = command.ExecuteScalar();

                con.Close();
                if (result == null)
                {
                    MessageBox.Show("No user found with this email or password ");
                }
                else
                {
                    ManagerMain managerMain = new ManagerMain();
                    managerMain.Show();
                    this.Hide();
                }
            }
            else if (UserType == "Owner") 
            {
                string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
                SqlConnection con = new SqlConnection(path);
                con.Open();
                string email = Email.Text;
                string password = Password.Text;
                string Querry = "SELECT Name FROM cafeOwner WHERE Email=@Email AND Password=@Password";
                SqlCommand command = new SqlCommand(Querry, con);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                object result = command.ExecuteScalar();

                con.Close();
                if (result == null)
                {
                    MessageBox.Show("No user found with this email or password ");
                }
                else
                {
                   Owner owner = new Owner();
                    owner.Show();
                    this.Hide();
                }
            }
            else if (UserType == "Cashier") 
            {
                    
            }
            else if (UserType == "Server") { }
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MainHome mainHome = new MainHome();
            mainHome.Show();
            this.Hide();
        }
    }
}
