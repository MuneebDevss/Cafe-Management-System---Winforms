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
    public partial class MakeOrderFixed : Form
    {
        public MakeOrderFixed()
        {
            InitializeComponent();
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True";
            SqlConnection con = new SqlConnection(path);
            con.Open();
            string Query = " select * from MenuItems m";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConfirmForm confirm =new ConfirmForm(orders);
            confirm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomerHome home = new CustomerHome();
            home.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        List<Order> orders = new List<Order>();
        public decimal GetTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (var order in orders)
            {
                decimal price = 0;
                decimal discount = int.Parse(order.discount);
                if (decimal.TryParse(order.TotalPrice, out price))
                {
                    totalPrice += price-(price*(discount/100));
                }
                else
                {
                    Console.WriteLine($"Error parsing TotalPrice for OrderID {order.ItemID}");
                    // Handle parsing errors as needed
                }
            }

            return totalPrice;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter some data first");
                return;
            }

            string itemId = textBox1.Text;
            if (itemId.Equals(""))
            {
                MessageBox.Show("Insert item id first");
                return;
            }
            string customerId = Form2.currentId;
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True";
            SqlConnection con = new SqlConnection(path);
            con.Open();

            // Query to fetch percentage from the "discount" table
            string discountQuery = "SELECT precentage FROM discount WHERE menuitemid = @itemId";
            SqlDataAdapter discountAdapter = new SqlDataAdapter(discountQuery, con);
            discountAdapter.SelectCommand.Parameters.AddWithValue("@itemId", itemId);
            DataTable discountTable = new DataTable();
            discountAdapter.Fill(discountTable);

            string disc = "0";
            if (discountTable.Rows.Count > 0)
            {
                disc = discountTable.Rows[0]["precentage"].ToString();
            }
            else
            {
              
            }

            string query = "SELECT Price FROM [MenuItems] WHERE ItemId = @itemId";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.SelectCommand.Parameters.AddWithValue("@itemId", itemId);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            string Price = string.Empty;

            if (dataTable.Rows.Count > 0)
            {
                Price = dataTable.Rows[0]["Price"].ToString();
                Order order = new Order(customerId, Price, itemId, disc);
                orders.Add(order);
                textBox2.Text = GetTotalPrice().ToString();
            }
            else
            {
                MessageBox.Show("No data found for the given ItemId.");
            }





        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void MakeOrderFixed_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True";
            SqlConnection con = new SqlConnection(path);
            con.Open();
            string Query = " select m.*,m.Price*(d.precentage/100) as Discount from MenuItems m join discount d on m.ItemID=d.menuitemid";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True";
            SqlConnection con = new SqlConnection(path);
            con.Open();
            string Query = " select * from MenuItems m";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            con.Close();
        }
    }
}
