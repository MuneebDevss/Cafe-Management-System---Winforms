using System;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class Owner : Form
    {
        public Owner()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddServer addServer = new AddServer();
            addServer.Show();
            this.Hide();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            UpdateSalaryManager updateSalaryManager = new UpdateSalaryManager();
            updateSalaryManager.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cashier cashier = new Cashier();
            cashier.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RemoveServer removeServer   = new RemoveServer();
            removeServer.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OwnerFeedback ownerFeedback = new OwnerFeedback();
            ownerFeedback.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SalesDetailsOwner salesDetailsManager = new SalesDetailsOwner();
            salesDetailsManager.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MainHome mainHome = new MainHome();
            mainHome.Show();
            this.Hide();
        }
    }
}
