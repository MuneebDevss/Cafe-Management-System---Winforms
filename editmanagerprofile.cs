using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class 
        editmanagerprofile : Form
    {
        private object panel1;

        public editmanagerprofile()
        {
            InitializeComponent();
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
            SqlConnection con = new SqlConnection(path);

            con.Open();
           

          
            string getname = " select Name from Manager;";
            string getemail = "select Email from Manager;";
            string getPhone = "select PhoneNumber from Manager;";
            string getPassword = "  select Password from Manager;"; 
            SqlCommand cmdname = new SqlCommand(getname, con);
            SqlCommand cmdemail = new SqlCommand(getemail, con);
            SqlCommand cmdphone= new SqlCommand(getPhone, con);
            SqlCommand cmdpassword= new SqlCommand(getPassword, con);
            Object Name= cmdname.ExecuteScalar();
            name.Text = Name.ToString();  
            Object Email = cmdemail.ExecuteScalar();
            email.Text = Email.ToString();
            Object Phone = cmdphone.ExecuteScalar();
            phonenumber.Text = Phone.ToString();
            Object Password = cmdpassword.ExecuteScalar();
             password.Text = Password.ToString();
            con.Close();
        ;
        }

        private void label6_Click(object sender, EventArgs e)
        {
             
            label1.BackColor = Color.Black; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
            SqlConnection con = new SqlConnection(path);
            con.Open();

            string email = textBox1.Text;

            // Check if the email follows the specified pattern
            string emailPattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Please enter a valid email address.");
                con.Close();
                return;
            }

            string updateemail = "UPDATE Manager SET email = @Email";
            SqlCommand run = new SqlCommand(updateemail, con);
            run.Parameters.AddWithValue("@Email", email);
            run.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Email updated!");

            ManagerMain main = new ManagerMain();
            main.Show();
            this.Hide();
        }


        private void editmanagerprofile_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManagerMain main = new ManagerMain();
            main.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
            SqlConnection con = new SqlConnection(path);
            con.Open();

            string password = textBox2.Text;

            // Check if the password length is at least 8 characters
            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.");
                con.Close();
                return;
            }

            string updatePassword = "UPDATE Manager SET Password = @Password";
            SqlCommand run = new SqlCommand(updatePassword, con);
            run.Parameters.AddWithValue("@Password", password);
            run.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Password updated!");

            ManagerMain main = new ManagerMain();
            main.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
            SqlConnection con = new SqlConnection(path);
            con.Open();

            string phoneNumber = textBox3.Text;

            // Check if the phone number length is exactly 11 characters
            if (phoneNumber.Length != 11)
            {
                MessageBox.Show("Phone number must be exactly 11 characters long.");
                con.Close();
                return;
            }

            string updatePhone = "UPDATE Manager SET PhoneNumber = @PhoneNumber";
            SqlCommand run = new SqlCommand(updatePhone, con);
            run.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
            run.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Phone number updated!");

            ManagerMain main = new ManagerMain();
            main.Show();
            this.Hide();
        }

    }
}
