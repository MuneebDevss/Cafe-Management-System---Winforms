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
    public partial class updatemenuitems : Form
    {
        public updatemenuitems()
        {
            InitializeComponent();
            dataGridView1.RowTemplate.Height = 20;
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
            SqlConnection conn = new SqlConnection(path);
            conn.Open();
            string displayInventory = "  select m.ItemID,m.Name,m.Category,m.Description,m.Price from MenuItems m; ;";
            SqlDataAdapter adapter = new SqlDataAdapter(displayInventory, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conn.Close();

        }

        private void OrderMenu_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button5_Click(object sender, System.EventArgs e)
        {

            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
            SqlConnection conn = new SqlConnection(path);
            conn.Open();

            // Validate ID (must be a number)
            int id;
            if (!int.TryParse(textBox2.Text, out id))
            {
                MessageBox.Show("ID must be a valid number.");
                conn.Close();
            }
            else
            {
                // Validate name (should only contain letters)
                string name = textBox3.Text;
                if (!System.Text.RegularExpressions.Regex.IsMatch(name, "^[a-zA-Z]+$"))
                {
                    MessageBox.Show("Name should only contain letters.");
                    conn.Close();
                }
                else
                {// Check if ID exists
                    string checkIdQuery = "SELECT COUNT(*) FROM MenuItems WHERE ItemID =" + id;
                    SqlCommand checkIdCmd = new SqlCommand(checkIdQuery, conn);
                    int rowCount = (int)checkIdCmd.ExecuteScalar();
                    if (rowCount == 0)
                    {
                        MessageBox.Show("ID does not exist.");
                        conn.Close();
                    }

                    else
                    {
                        // Update record
                        string updaterecord = "UPDATE MenuItems SET Name = '" + name + "' WHERE itemid = " + id;
                        SqlCommand cmd = new SqlCommand(updaterecord, conn);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Name has been updated!");

                        ManageInventory manageInventory = new ManageInventory();
                        manageInventory.Show();
                        this.Hide();
                    }
                }
            }


        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
            SqlConnection conn = new SqlConnection(path);
            conn.Open();

            // Validate ID (must be a number)
            int id;
            if (!int.TryParse(textBox2.Text, out id))
            {
                MessageBox.Show("ID must be a valid number.");
                conn.Close();
            }
            else
            {
                // Validate name (should only contain letters)
                string name = textBox3.Text;
                if (!System.Text.RegularExpressions.Regex.IsMatch(name, "^[a-zA-Z]+$"))
                {
                    MessageBox.Show("Name should only contain letters.");
                    conn.Close();
                }
                else
                {
                    // Validate Category
                    string category = textBox4.Text;
                    if (string.IsNullOrWhiteSpace(category))
                    {
                        MessageBox.Show("Category cannot be empty.");
                        conn.Close();
                    }
                    else
                    {
                        // Check if ID exists
                        string checkIdQuery = "SELECT COUNT(*) FROM MenuItems WHERE ItemID = @id";
                        SqlCommand checkIdCmd = new SqlCommand(checkIdQuery, conn);
                        checkIdCmd.Parameters.AddWithValue("@id", id);
                        int rowCount = (int)checkIdCmd.ExecuteScalar();
                        if (rowCount == 0)
                        {
                            MessageBox.Show("ID does not exist.");
                            conn.Close();
                        }
                        else
                        {
                            // Update record
                            string updateRecord = "UPDATE MenuItems SET Name = @name, Category = @category WHERE itemid = @id";
                            SqlCommand cmd = new SqlCommand(updateRecord, conn);
                            cmd.Parameters.AddWithValue("@name", name);
                            cmd.Parameters.AddWithValue("@category", category);
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Name and Category have been updated!");

                            ManageInventory manageInventory = new ManageInventory();
                            manageInventory.Show();
                            this.Hide();
                        }
                    }
                }
            }
        }

     

        private void button4_Click(object sender, EventArgs e)
        {
            managemenuitems manage = new managemenuitems();
            manage.Show();
            this.Hide();
        }
        private void button2_Click(object sender, System.EventArgs e)
        {
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
            SqlConnection conn = new SqlConnection(path);
            conn.Open();

            // Validate ID (must be a number)
            int id;
            if (!int.TryParse(textBox2.Text, out id))
            {
                MessageBox.Show("ID must be a valid number.");
                conn.Close();
            }
            else
            {
                // Validate Category
                string category = textBox1.Text;
                if (string.IsNullOrWhiteSpace(category))
                {
                    MessageBox.Show("Category cannot be empty.");
                    conn.Close();
                }
                else
                {
                    // Check if ID exists
                    string checkIdQuery = "SELECT COUNT(*) FROM MenuItems WHERE ItemID = @id";
                    SqlCommand checkIdCmd = new SqlCommand(checkIdQuery, conn);
                    checkIdCmd.Parameters.AddWithValue("@id", id);
                    int rowCount = (int)checkIdCmd.ExecuteScalar();
                    if (rowCount == 0)
                    {
                        MessageBox.Show("ID does not exist.");
                        conn.Close();
                    }
                    else
                    {
                        // Update record
                        string updateRecord = "UPDATE MenuItems SET Category = @category WHERE itemid = @id";
                        SqlCommand cmd = new SqlCommand(updateRecord, conn);
                        cmd.Parameters.AddWithValue("@category", category);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Category has been updated!");

                        ManageInventory manageInventory = new ManageInventory();
                        manageInventory.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void updatemenuitems_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
