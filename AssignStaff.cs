using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class AssignStaff : Form
    {
        int id;
        DateTime starttime;
        DateTime endtime;
        public AssignStaff()
        {
            InitializeComponent();
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
            SqlConnection con = new SqlConnection(path);
            con.Open();
            string Query = "select * from viewservingstaff";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            con.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OrderMenu_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagerMain manager = new ManagerMain();
            manager.Show();
            this.Hide();
        }

        public void InsertIntoServingStaffAssignment(int servingId, TimeSpan assignedFrom, TimeSpan assignedTo)
        {
            string connectionString = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";

            // Check if the entered serving staff ID exists in the serving staff table
            string checkQuery = "SELECT COUNT(*) FROM Servingstaff WHERE serving_id = @ServingId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(checkQuery, connection))
                {
                    command.Parameters.AddWithValue("@ServingId", servingId);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        // Serving staff ID exists, proceed to insert into the serving staff assignment table
                        string insertQuery = @"INSERT INTO ServicestaffAssignment (Name, assignedfrom, assignedto, ServingID) 
                                       SELECT Name, @AssignedFrom, @AssignedTo, @ServingId 
                                       FROM Servingstaff 
                                       WHERE serving_id = @ServingId";
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@AssignedFrom", assignedFrom);
                            insertCommand.Parameters.AddWithValue("@AssignedTo", assignedTo);
                            insertCommand.Parameters.AddWithValue("@ServingId", servingId);
                            insertCommand.ExecuteNonQuery();
                            MessageBox.Show("Values inserted into ServicestaffAssignment table.");
                            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
                            SqlConnection con = new SqlConnection(path);
                            con.Open();
                            string Query = "   select s.serving_id,s.Name,sa.assignedfrom,sa.assignedto  from Servingstaff s inner join ServicestaffAssignment sa on s.serving_id =sa.ServingID;";
                            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView2.DataSource = dataTable;
                            con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Serving staff ID does not exist in the Servingstaff table.");
                    }
                }
            }
        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("")) 
            {
                MessageBox.Show("please enter a valid id");
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

                InsertIntoServingStaffAssignment(id, startTime, endTime);
            }
            else
            {
                // Parsing failed, show error message
                MessageBox.Show("Please enter a valid number in the ID field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
