using System;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class ManagerMain : Form
    {
        public ManagerMain()
        {
            InitializeComponent();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            AssignCashier assigns=new AssignCashier();
            assigns.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            AssignStaff assigns=new AssignStaff();  
            assigns.Show();
            this.Hide();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            ManageInventory manageInventory=new ManageInventory();
            manageInventory.Show();
                this.Hide();
        }
         private void button2_Click(object sender, EventArgs e)
        {
            CustomerReports customerreports = new CustomerReports();
            customerreports.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AssignedStaff staff = new AssignedStaff();
            staff.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            editmanagerprofile profile = new editmanagerprofile();
            profile.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            managemenuitems managemenuitems = new managemenuitems();
            managemenuitems.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainHome home = new MainHome();
            home.Show();
            this.Hide();
        }

        private void lblWelcom_Click(object sender, EventArgs e)
        {

        }

        private void panelButtonsNavigation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSidebarTraveller_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelNavbar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
