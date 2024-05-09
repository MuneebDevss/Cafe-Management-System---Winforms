
namespace CafeManagementSystem
{
    partial class CustomerHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerHome));
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.panelButtonsNavigation = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MakeOrder = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelSidebarTraveller = new System.Windows.Forms.Panel();
            this.lblWelcom = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.panelNavbar.SuspendLayout();
            this.panelButtonsNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavbar
            // 
            this.panelNavbar.BackColor = System.Drawing.Color.CadetBlue;
            this.panelNavbar.Controls.Add(this.panelButtonsNavigation);
            this.panelNavbar.Controls.Add(this.lblWelcom);
            this.panelNavbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavbar.Location = new System.Drawing.Point(0, 0);
            this.panelNavbar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(486, 1106);
            this.panelNavbar.TabIndex = 3;
            // 
            // panelButtonsNavigation
            // 
            this.panelButtonsNavigation.Controls.Add(this.button4);
            this.panelButtonsNavigation.Controls.Add(this.button3);
            this.panelButtonsNavigation.Controls.Add(this.button2);
            this.panelButtonsNavigation.Controls.Add(this.button1);
            this.panelButtonsNavigation.Controls.Add(this.MakeOrder);
            this.panelButtonsNavigation.Controls.Add(this.btnHome);
            this.panelButtonsNavigation.Controls.Add(this.panelSidebarTraveller);
            this.panelButtonsNavigation.Location = new System.Drawing.Point(12, 186);
            this.panelButtonsNavigation.Name = "panelButtonsNavigation";
            this.panelButtonsNavigation.Size = new System.Drawing.Size(474, 649);
            this.panelButtonsNavigation.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(10, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(464, 72);
            this.button3.TabIndex = 20;
            this.button3.Text = "Cancel Order";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(10, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(464, 72);
            this.button2.TabIndex = 19;
            this.button2.Text = "Menu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(10, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(464, 72);
            this.button1.TabIndex = 18;
            this.button1.Text = "ReserveTable";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MakeOrder
            // 
            this.MakeOrder.BackColor = System.Drawing.Color.Transparent;
            this.MakeOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MakeOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.MakeOrder.FlatAppearance.BorderSize = 0;
            this.MakeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeOrder.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.MakeOrder.ForeColor = System.Drawing.Color.Black;
            this.MakeOrder.Image = ((System.Drawing.Image)(resources.GetObject("MakeOrder.Image")));
            this.MakeOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MakeOrder.Location = new System.Drawing.Point(10, 85);
            this.MakeOrder.Name = "MakeOrder";
            this.MakeOrder.Size = new System.Drawing.Size(464, 72);
            this.MakeOrder.TabIndex = 17;
            this.MakeOrder.Text = "Make an order";
            this.MakeOrder.UseVisualStyleBackColor = false;
            this.MakeOrder.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(10, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(464, 85);
            this.btnHome.TabIndex = 13;
            this.btnHome.Text = "About";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelSidebarTraveller
            // 
            this.panelSidebarTraveller.BackColor = System.Drawing.Color.Transparent;
            this.panelSidebarTraveller.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebarTraveller.ForeColor = System.Drawing.Color.Transparent;
            this.panelSidebarTraveller.Location = new System.Drawing.Point(0, 0);
            this.panelSidebarTraveller.Name = "panelSidebarTraveller";
            this.panelSidebarTraveller.Size = new System.Drawing.Size(10, 649);
            this.panelSidebarTraveller.TabIndex = 12;
            // 
            // lblWelcom
            // 
            this.lblWelcom.AutoSize = true;
            this.lblWelcom.BackColor = System.Drawing.Color.CadetBlue;
            this.lblWelcom.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblWelcom.ForeColor = System.Drawing.Color.Snow;
            this.lblWelcom.Location = new System.Drawing.Point(12, 20);
            this.lblWelcom.Name = "lblWelcom";
            this.lblWelcom.Size = new System.Drawing.Size(392, 114);
            this.lblWelcom.TabIndex = 3;
            this.lblWelcom.Text = "Welcome";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(10, 373);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(464, 72);
            this.button4.TabIndex = 21;
            this.button4.Text = "Log out";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // CustomerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(29F, 67F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1744, 1106);
            this.Controls.Add(this.panelNavbar);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomerHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.panelNavbar.ResumeLayout(false);
            this.panelNavbar.PerformLayout();
            this.panelButtonsNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelNavbar;
        private System.Windows.Forms.Label lblWelcom;
        private System.Windows.Forms.Panel panelButtonsNavigation;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelSidebarTraveller;
        private System.Windows.Forms.Button MakeOrder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}