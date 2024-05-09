using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class MainHome : Form
    {
        public MainHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2("Manager");
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2("Customer");
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cashiermain cashiermain = new Cashiermain();
            cashiermain.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            servermain servermain = new servermain();
            servermain.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2("Owner");
            form2.Show();
            this.Hide();
        }
    }
}
