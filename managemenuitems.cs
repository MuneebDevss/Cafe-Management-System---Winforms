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
    public partial class managemenuitems : Form
    {
        public managemenuitems()
        {
            InitializeComponent();
            string path = "Data Source=MUNEEB\\SQLEXPRESS;Initial Catalog=CafeManagementSystem;Integrated Security=True;Encrypt=False;";
            SqlConnection conn = new SqlConnection(path);
            conn.Open();
            string displayInventory = "  select m.ItemID,m.Name,m.Category,m.Description,m.Price from MenuItems m; ;";
            SqlDataAdapter adapter = new SqlDataAdapter(displayInventory, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conn.Close();

        }

        private void OrderMenu_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            updatemenuitems update = new updatemenuitems();
            update.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addmenuitems add = new addmenuitems();
            add.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManagerMain main = new ManagerMain();
            main.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void managemenuitems_Load(object sender, EventArgs e)
        {

        }
    }
}
