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
    public partial class LoyalityProgram : Form
    {
        public LoyalityProgram()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Owner own = new Owner();
            own.Show();
            this.Hide();
        }
        

    public void UpdateInventoryItemDiscount(string itemId, string discount)
    {
            if (string.IsNullOrWhiteSpace(itemId))
            {
                Console.WriteLine("Item ID cannot be empty.");
                return;
            }

            if (string.IsNullOrWhiteSpace(discount))
            {
                Console.WriteLine("Discount value cannot be empty.");
                return;
            }
            string connectionString = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string updateQuery = "insert into  discounts (menuitemid,precentage) ( @ItemId,@Discount)";

            SqlCommand command = new SqlCommand(updateQuery, connection);
            command.Parameters.AddWithValue("@Discount", discount);
            command.Parameters.AddWithValue("@ItemId", itemId);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"Rows affected: {rowsAffected}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating inventory item discount: " + ex.Message);
            }
        }
    }

    private void button2_Click(object sender, EventArgs e)
        {
            UpdateInventoryItemDiscount(textBox1.Text, textBox2.Text);
        }
    }
}
