using System.Windows.Forms;
using System.Data.SqlClient;
using System;
using System.Diagnostics;

namespace CafeManagementSystem
{
    public partial class additem : Form
    {
        public additem()
        {
            InitializeComponent();
        }

        private void AddItem_Load(object sender, System.EventArgs e)
        {

        }
        private void button1_click(object sender, System.EventArgs e)
        {
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
            SqlConnection con = new SqlConnection(path);

            con.Open();

            // Validate name (should only contain letters) and ensure it's not empty
            string name = textBox1.Text;
            if (string.IsNullOrWhiteSpace(name) || !System.Text.RegularExpressions.Regex.IsMatch(name, "^[a-zA-Z]+$"))
            {
                MessageBox.Show("Name should not be empty and should only contain letters.");
                con.Close();
            }
            else
            {
                // Validate category (should only contain letters) and ensure it's not empty
                string category = Category.Text;
                if (string.IsNullOrWhiteSpace(category) || !System.Text.RegularExpressions.Regex.IsMatch(category, "^[a-zA-Z]+$"))
                {
                    MessageBox.Show("Category should not be empty and should only contain letters.");
                    con.Close();
                }
                else
                {
                    // Validate price (must be a number) and ensure it's not empty
                    float price;
                    if (!float.TryParse(Price.Text, out price) || string.IsNullOrWhiteSpace(Price.Text))
                    {
                        MessageBox.Show("Price must be a valid number and should not be empty.");
                        con.Close();
                    }
                    else
                    {
                        // Validate quantity (must be a number) and ensure it's not empty
                        int quantity;
                        if (!int.TryParse(Quantity.Text, out quantity) || string.IsNullOrWhiteSpace(Quantity.Text))
                        {
                            MessageBox.Show("Quantity must be a valid number and should not be empty.");
                            con.Close();
                        }
                        else
                        {
                            // Insert record
                            string insertclient = "INSERT INTO InventoryItems (Name, Category, Price, Quantity) VALUES('" + name + "','" + category + "'," + price + "," + quantity + ")";
                            SqlCommand run = new SqlCommand(insertclient, con);
                            run.ExecuteNonQuery();

                            MessageBox.Show("Item Added");

                            ManageInventory manage = new ManageInventory();
                            manage.Show();
                            this.Hide();
                        }
                    }
                }
            }

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageInventory main = new ManageInventory();
            main.Show();
             this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
