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
    public partial class addmenuitems : Form
    {
        public addmenuitems()
        {
            InitializeComponent();
        }

        private void button1_click(object sender, System.EventArgs e)
        {
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
            SqlConnection con = new SqlConnection(path);

            con.Open();

    
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
                    
                    float price;
                    if (!float.TryParse(Price.Text, out price) || string.IsNullOrWhiteSpace(Price.Text))
                    {
                        MessageBox.Show("Price must be a valid number and should not be empty.");
                        con.Close();
                    }
                    else
                    {
                        
                        
                        if ( string.IsNullOrWhiteSpace(Description.Text)|| !System.Text.RegularExpressions.Regex.IsMatch(Description.Text, "^[a-zA-Z]+$"))
                        {
                            MessageBox.Show("Description  should not be empty. and should only contain letters");
                            con.Close();
                        }
                        else
                        {
                            // Insert record
                            string insertclient = "INSERT INTO MenuItems (Name, Category, Price, Description) VALUES('" + name + "','" + category + "'," + price + "," + Description.Text + ")";
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            string path = "Data Source=Ali\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True";
            SqlConnection con = new SqlConnection(path);

            con.Open();

            string des;

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

                    float price;
                    if (!float.TryParse(Price.Text, out price) || string.IsNullOrWhiteSpace(Price.Text))
                    {
                        MessageBox.Show("Price must be a valid number and should not be empty.");
                        con.Close();
                    }
                    else
                    {
                        des = Description.Text;
                        if (string.IsNullOrWhiteSpace(Description.Text) || !System.Text.RegularExpressions.Regex.IsMatch(Description.Text, "^[a-zA-Z]+$"))
                        {
                            MessageBox.Show("Description  should not be empty. and should only contain letters");
                            con.Close();
                        }
                        else
                        {
                            // Insert record
                           string insertclient = "INSERT INTO MenuItems (Name, Category, Price, Description) VALUES(@Name, @Category, @Price, @Description)";
SqlCommand run = new SqlCommand(insertclient, con);
run.Parameters.AddWithValue("@Name", name);
run.Parameters.AddWithValue("@Category", category);
run.Parameters.AddWithValue("@Price", price);
run.Parameters.AddWithValue("@Description", des);
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

        private void button2_Click(object sender, EventArgs e)
        {
           ManagerMain managerMain  = new ManagerMain();
            managerMain.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
