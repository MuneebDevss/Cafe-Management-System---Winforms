using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Drawing;

namespace CafeManagementSystem
{
    public partial class AssignCashier : Form
    {
    int id;
        DateTime starttime;
        DateTime endtime;
        public AssignCashier()
        {
        InitializeComponent();
        string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
        SqlConnection con = new SqlConnection(path);
        con.Open();
        string Query = "select * from viewcashierstaff;";
        SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
        DataTable dataTable = new DataTable();
        adapter.Fill(dataTable);
        dataGridView1.DataSource = dataTable;
        con.Close();
            
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            ManagerMain manager = new ManagerMain();
            manager.Show();
            this.Hide();
        }
        private void button2_Click(object sender, System.EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Please Enter id first");
                return;
            }
            if (int.TryParse(textBox1.Text, out id))
            {
                // Parsing successful, 'id' contains the parsed integer value
                // Now you can proceed with the insertion process
                DateTime startTimeDateTime = dateTimePicker1.Value;
                TimeSpan startTime = startTimeDateTime.TimeOfDay; // Extract time part as TimeSpan
                DateTime endTimeDateTime = dateTimePicker2.Value;
                TimeSpan endTime = endTimeDateTime.TimeOfDay; // Extract time part as TimeSpan

                InsertIntoCashierAssignment(id, startTime, endTime);
            }
            else
            {
                // Parsing failed, show error message
                MessageBox.Show("Please enter a valid number in the ID field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void InsertIntoCashierAssignment(int cashierId, TimeSpan assignedFrom, TimeSpan assignedTo)
        {
            string connectionString = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";

            // Check if the entered cashier ID exists in the cashier table
            string checkQuery = "SELECT COUNT(*) FROM Cashier WHERE cashier_id = @CashierId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(checkQuery, connection))
                {
                    command.Parameters.AddWithValue("@CashierId", cashierId);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        // Cashier ID exists, proceed to insert into the cashier assignment table
                        string insertQuery = @"INSERT INTO CashierAssignment (Name, assignedfrom, assignedto, CashierID) 
                                       SELECT Name, @AssignedFrom, @AssignedTo, @CashierId 
                                       FROM Cashier 
                                       WHERE cashier_id = @CashierId";
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@AssignedFrom", assignedFrom);
                            insertCommand.Parameters.AddWithValue("@AssignedTo", assignedTo);
                            insertCommand.Parameters.AddWithValue("@CashierId", cashierId);
                            insertCommand.ExecuteNonQuery();
                            MessageBox.Show("Values inserted into CashierAssignment table.");
                            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
                            SqlConnection con = new SqlConnection(path);
                            con.Open();
                            string Query = "   select ca.assignmentid,c.Name,ca.assignedfrom,ca.assignedto from Cashier c inner join  CashierAssignment ca on ca.CashierID =c.cashier_id; ";
                            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView2.DataSource = dataTable;
                            con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cashier ID does not exist in the Cashier table.");
                    }
                }
            }
        }

        private void AssignCashier_Load(object sender, System.EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, System.EventArgs e)
        {
           
        }

        private void OrderMenu_Click(object sender, System.EventArgs e)
        {
           
        }

        private void label5_Click(object sender, System.EventArgs e)
        {
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
