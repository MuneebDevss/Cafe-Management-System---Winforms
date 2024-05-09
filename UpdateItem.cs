using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System;

namespace CafeManagementSystem
{
    public partial class UpdateItem : Form
    {
        public UpdateItem()
        {
            InitializeComponent();
            
            dataGridView1.RowTemplate.Height = 20;
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
            SqlConnection conn = new SqlConnection(path);
            conn.Open();
            string displayInventory = " select i.itemid,i.Category,i.Name,i.Quantity from InventoryItems i;";
            SqlDataAdapter adapter = new SqlDataAdapter(displayInventory, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conn.Close();
        }

        private void UpdateItem_Load(object sender, System.EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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
                return;
            }

            // Delete record if ID is valid
            string deleteQuery = "DELETE FROM InventoryItems WHERE itemid = @ItemId";
            SqlCommand deleteCommand = new SqlCommand(deleteQuery, conn);
            deleteCommand.Parameters.AddWithValue("@ItemId", id);

            int rowsAffected = deleteCommand.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Record deleted successfully.");
                ManageInventory manageInventory = new ManageInventory();
                manageInventory.Show();

                this.Hide();

            }
            else
            {
                MessageBox.Show("No record found with the specified ID.");
            }

            conn.Close();
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            ManageInventory manageInventory = new ManageInventory();
            manageInventory.Show();
            this.Hide();
        }

        private void label3_Click(object sender, System.EventArgs e)
        {

        }

        private void button5_Click(object sender, System.EventArgs e)
        {

            string path = "Data Source=Ali\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True";
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
                    // Check if ID exists
                    string checkIdQuery = "SELECT COUNT(*) FROM InventoryItems WHERE itemid = " + id;
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
                        string updaterecord = "UPDATE InventoryItems SET Name = '" + name + "' WHERE itemid = " + id;
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
                // Validate quantity (must be a number)
                int quantity;
                if (!int.TryParse(textBox4.Text, out quantity))
                {
                    MessageBox.Show("Quantity must be a valid number.");
                    conn.Close();
                }
                else
                {
                    // Check if ID exists
                    string checkIdQuery = "SELECT COUNT(*) FROM InventoryItems WHERE itemid = @ID";
                    using (SqlCommand checkIdCmd = new SqlCommand(checkIdQuery, conn))
                    {
                        checkIdCmd.Parameters.AddWithValue("@ID", id);
                        int rowCount = (int)checkIdCmd.ExecuteScalar();
                        if (rowCount == 0)
                        {
                            MessageBox.Show("ID does not exist.");
                            conn.Close();
                        }
                        else
                        {
                            // Update record
                            string updaterecord = "UPDATE InventoryItems SET Quantity = @Quantity WHERE itemid = @ID";
                            using (SqlCommand cmd = new SqlCommand(updaterecord, conn))
                            {
                                cmd.Parameters.AddWithValue("@Quantity", quantity);
                                cmd.Parameters.AddWithValue("@ID", id);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Quantity has been updated!");

                                ManageInventory manageInventory = new ManageInventory();
                                manageInventory.Show();
                                this.Hide();
                            }
                        }
                    }
                }
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManagerMain managerMain = new ManagerMain();
            managerMain.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
