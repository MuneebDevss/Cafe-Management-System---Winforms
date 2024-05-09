using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace CafeManagementSystem
{
    public partial class ManageInventory : Form
    {
        public ManageInventory()
        {
            InitializeComponent();
            //dataGridView1.Height = 600;
            dataGridView1.RowTemplate.Height = 20;
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
            SqlConnection conn = new SqlConnection(path);
            conn.Open();
            string displayInventory = "select * from viewinventory;";
            SqlDataAdapter adapter = new SqlDataAdapter(displayInventory, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conn.Close();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            UpdateItem updateItems = new UpdateItem();
            updateItems.Show();
            this.Hide();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            additem additems = new additem();
            additems.Show();
            this.Hide();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            ManagerMain main = new ManagerMain();
             main.Show();
            this.Hide();
        }

        private void OrderMenu_Click(object sender, System.EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageInventory_Load(object sender, System.EventArgs e)
        {

        }
    }
}
