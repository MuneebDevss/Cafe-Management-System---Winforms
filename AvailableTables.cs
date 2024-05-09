using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class AvailableTables : Form
    {
        public AvailableTables()
        {
            InitializeComponent();
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
            SqlConnection con = new SqlConnection(path);
            con.Open();
            string Query = "SELECT * FROM [Table] c";
            Console.WriteLine(Query);
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            con.Close();

        }

        private void OrderMenu_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
            SqlConnection con = new SqlConnection(path);
            con.Open();

            string tableId = textBox1.Text; // Specify the Table_id value you want to match
            string startvar = textBox2.Text;
            string endvar = textBox3.Text;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter tableid data first");
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please enter starttime data first");
                return;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Please enter end time data first");
                return;
            }
            string query = $"SELECT TableID FROM Reservation " +
    $"WHERE TableID = @tableId" +
    $"  AND (DATEADD(minute, DATEDIFF(minute, StartTime, EndTime), StartTime) >= CONVERT(time, @startvar)" +
    $"  AND StartTime <= CONVERT(time, @startvar))" +
    $"  OR (DATEADD(minute, DATEDIFF(minute, CONVERT(time, @startvar), CONVERT(time, @endvar)), CONVERT(time, @startvar)) >= StartTime" +
    $"  AND StartTime >= CONVERT(time, @startvar))";

         

            // Validate that none of the fields are empty
            if (string.IsNullOrWhiteSpace(tableId) || string.IsNullOrWhiteSpace(startvar) || string.IsNullOrWhiteSpace(endvar))
            {
                MessageBox.Show("Please enter values for Table ID, Start Var, and End Var.");
                return; // Stop further execution
            }

            // Proceed with your operations after validation


            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@tableId", tableId);
                cmd.Parameters.AddWithValue("@startvar", startvar);
                cmd.Parameters.AddWithValue("@endvar", endvar);

                DataTable dataTable = new DataTable();

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                {
                    dataAdapter.Fill(dataTable);
                }

                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("There is a table already reserved during this duration");
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string tableIDResult = row["TableID"].ToString();
                        // Process tableIDResult if needed
                    }

                }
                else
                {

                    string insertQuery = "INSERT INTO Reservation (CustomerID, StartTime, EndTime, TableID) VALUES (@customerID, @startvar, @endvar, @tableId)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                    {
                        // Assuming you have a variable for CustomerID, replace 'customerIDValue' with its actual value
                        string customerIDValue = Form2.currentId;
                        insertCmd.Parameters.AddWithValue("@customerID", customerIDValue);
                        insertCmd.Parameters.AddWithValue("@startvar", startvar);
                        insertCmd.Parameters.AddWithValue("@endvar", endvar);
                        insertCmd.Parameters.AddWithValue("@tableId", tableId);

                        int rowsAffected = insertCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // Insertion successful
                            MessageBox.Show("Your Table has been reserved");
                        }
                        else
                        {
                            // Insertion failed
                            Console.WriteLine("Failed to insert reservation.");
                        }
                    }

                }

            }

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReservedTables reservedTables = new ReservedTables();
            reservedTables.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CustomerHome customerHome = new CustomerHome();
            customerHome.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
