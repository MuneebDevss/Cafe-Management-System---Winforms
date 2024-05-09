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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeManagementSystem
{
    public partial class servermain : Form
    {
        public servermain()
        {
            InitializeComponent();
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
            SqlConnection con = new SqlConnection(path);
            con.Open();
            string Query = "SELECT * FROM [order] c where orderstatus!='confirmed'";
            Console.WriteLine(Query);
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            con.Close();
        }




        private void servermain_Load(object sender, EventArgs e)
        {

        }

        
            private void button2_Click(object sender, EventArgs e)
            {
            string customerid = textBox1.Text;
            string orderid = textBox5.Text;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter customerid data first");
                return;
            }
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Please enter orderid data first");
                return;
            }
            
            string query = "UPDATE [Order] SET orderstatus = 'confirmed' WHERE OrderID = @orderid AND CustomerID = @customerid";

            using (SqlConnection connection = new SqlConnection("Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;"))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@orderid", orderid);
                    command.Parameters.AddWithValue("@customerid", customerid);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Order status updated to confirmed.");
                    }
                    else
                    {
                        MessageBox.Show("No order found for the given OrderID and CustomerID.");
                    }
                }
            }


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainHome mainHome = new MainHome();
            mainHome.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
    