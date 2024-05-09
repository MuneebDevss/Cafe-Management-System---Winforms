
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class CustomerHome : Form
    {

        // ========================== Rounding Edges ==========================//
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );
        // =====================================================================//

        private Form activeForm = null;
        private Thread thread;
        private bool isRegion;
        public CustomerHome()
        {
            InitializeComponent();
         
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

            isRegion = true;



        }

        /********************* PICTURE BUTTONS **************************/
        private void picClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Close();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picSettings_Click(object sender, EventArgs e)
        {

        }
        /****************************************************************/

        /***************** BUTTONS CLICK EVENTS**************************/
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            highlightSelectedButton(btnHome);
            resetContextMenus();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            MakeOrderFixed makeOrderFixed = new MakeOrderFixed();
            makeOrderFixed.Show();
            this.Hide();
            
        }

        private void btnClinic_Click(object sender, EventArgs e)
        {


        }

        private void btnReports_Click(object sender, EventArgs e)
        {

            
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            highlightSelectedButton(MakeOrder);
            MakeOrderFixed makeOrderForm = new MakeOrderFixed();
            makeOrderForm.Show();
            this.Hide();

        }


        private void btnBill_Click(object sender, EventArgs e)
        {


        }

        private void btnShowRooms_Click(object sender, EventArgs e)
        {


        }

        private void btnShowReports_Click(object sender, EventArgs e)
        {


            Region = null;
            isRegion = false;
            WindowState = FormWindowState.Maximized;
            resetContextMenus();
        }

        private void btnChangeNID_Click(object sender, EventArgs e)
        {
            // openForm(new FormName());
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            //openForm(new ChangePasswordForm());

            resetContextMenus();

            if (!isRegion)
            {
                Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
                WindowState = FormWindowState.Normal;
                isRegion = true;
            }
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {

            resetContextMenus();

            if (!isRegion)
            {
                Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
                WindowState = FormWindowState.Normal;
                isRegion = true;
            }
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {


            if (!isRegion)
            {
                Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
                WindowState = FormWindowState.Normal;
                isRegion = true;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            thread = new Thread(openThread);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            Close();
        }

        private void openThread(object obj)
        {
            Application.Run();
        }
        /****************************************************************/

        /******************TRANSITION & EFFECTS *************************/
        private void highlightSelectedButton(Button selectedButton)
        {
            foreach (Control b in panelButtonsNavigation.Controls)
                if (b == selectedButton)
                {

                    b.ForeColor = Color.Blue;
                }
                else if (b is Button)
                    b.ForeColor = Color.Beige;

            if (!isRegion)
            {
                Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
                WindowState = FormWindowState.Normal;
                isRegion = true;
            }
        }

        private void resetContextMenus()
        {
            
        }

        private void openForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            
            childForm.BringToFront();
            childForm.Show();
            resetContextMenus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AvailableTables reserveTable = new AvailableTables();
            reserveTable.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu me = new Menu();
            me.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CancelOrder cancelOrder = new CancelOrder();
            cancelOrder.Show(); 
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MainHome mainHome = new MainHome();
            mainHome.Show();
            this.Hide();
        }
    }
}
