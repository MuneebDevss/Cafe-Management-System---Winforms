using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class CustomerReports : Form
    {
        public CustomerReports()
        {
            InitializeComponent();
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
            SqlConnection con = new SqlConnection(path);
            con.Open();
            string Query = "   select * from Feedback;";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            con.Close();

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            ManagerMain main = new ManagerMain();
            main.Show();
            this.Hide();
        }

        private void OrderMenu_Click(object sender, System.EventArgs e)
        {

        }

        private void CustomerReports_Load(object sender, System.EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
