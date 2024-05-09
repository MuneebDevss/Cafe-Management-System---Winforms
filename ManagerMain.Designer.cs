namespace CafeManagementSystem
{
    partial class ManagerMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerMain));
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.panelButtonsNavigation = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelSidebarTraveller = new System.Windows.Forms.Panel();
            this.lblWelcom = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelNavbar.SuspendLayout();
            this.panelButtonsNavigation.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavbar
            // 
            this.panelNavbar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panelNavbar.Controls.Add(this.panelButtonsNavigation);
            this.panelNavbar.Controls.Add(this.lblWelcom);
            this.panelNavbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavbar.Location = new System.Drawing.Point(0, 0);
            this.panelNavbar.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(573, 952);
            this.panelNavbar.TabIndex = 4;
            this.panelNavbar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNavbar_Paint);
            // 
            // panelButtonsNavigation
            // 
            this.panelButtonsNavigation.Controls.Add(this.button4);
            this.panelButtonsNavigation.Controls.Add(this.button3);
            this.panelButtonsNavigation.Controls.Add(this.button2);
            this.panelButtonsNavigation.Controls.Add(this.button1);
            this.panelButtonsNavigation.Controls.Add(this.btnAppointment);
            this.panelButtonsNavigation.Controls.Add(this.btnReports);
            this.panelButtonsNavigation.Controls.Add(this.btnData);
            this.panelButtonsNavigation.Controls.Add(this.btnHome);
            this.panelButtonsNavigation.Controls.Add(this.panelSidebarTraveller);
            this.panelButtonsNavigation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelButtonsNavigation.Location = new System.Drawing.Point(-13, 185);
            this.panelButtonsNavigation.Name = "panelButtonsNavigation";
            this.panelButtonsNavigation.Size = new System.Drawing.Size(583, 715);
            this.panelButtonsNavigation.TabIndex = 5;
            this.panelButtonsNavigation.Paint += new System.Windows.Forms.PaintEventHandler(this.panelButtonsNavigation_Paint);
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
            this.button3.Location = new System.Drawing.Point(10, 537);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(573, 85);
            this.button3.TabIndex = 20;
            this.button3.Text = "Manage menu";
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
            this.button2.Location = new System.Drawing.Point(10, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(573, 85);
            this.button2.TabIndex = 19;
            this.button2.Text = "Customer Reports";
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
            this.button1.Location = new System.Drawing.Point(10, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(573, 102);
            this.button1.TabIndex = 18;
            this.button1.Text = "Assigned Staff";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAppointment
            // 
            this.btnAppointment.BackColor = System.Drawing.Color.Transparent;
            this.btnAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppointment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAppointment.FlatAppearance.BorderSize = 0;
            this.btnAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointment.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnAppointment.ForeColor = System.Drawing.Color.Black;
            this.btnAppointment.Image = ((System.Drawing.Image)(resources.GetObject("btnAppointment.Image")));
            this.btnAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppointment.Location = new System.Drawing.Point(10, 262);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(573, 88);
            this.btnAppointment.TabIndex = 17;
            this.btnAppointment.Text = "Manage Inventory";
            this.btnAppointment.UseVisualStyleBackColor = false;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Transparent;
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnReports.ForeColor = System.Drawing.Color.Black;
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(10, 185);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(573, 77);
            this.btnReports.TabIndex = 16;
            this.btnReports.Text = "Assign Servers";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnData
            // 
            this.btnData.BackColor = System.Drawing.Color.Transparent;
            this.btnData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnData.FlatAppearance.BorderSize = 0;
            this.btnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnData.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnData.ForeColor = System.Drawing.Color.Black;
            this.btnData.Image = ((System.Drawing.Image)(resources.GetObject("btnData.Image")));
            this.btnData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnData.Location = new System.Drawing.Point(10, 85);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(573, 100);
            this.btnData.TabIndex = 14;
            this.btnData.Text = "Assign Cashier";
            this.btnData.UseVisualStyleBackColor = false;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
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
            this.btnHome.Size = new System.Drawing.Size(573, 85);
            this.btnHome.TabIndex = 13;
            this.btnHome.Text = "Edit profile ";
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
            this.panelSidebarTraveller.Size = new System.Drawing.Size(10, 715);
            this.panelSidebarTraveller.TabIndex = 12;
            this.panelSidebarTraveller.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSidebarTraveller_Paint);
            // 
            // lblWelcom
            // 
            this.lblWelcom.AutoSize = true;
            this.lblWelcom.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblWelcom.ForeColor = System.Drawing.Color.SeaShell;
            this.lblWelcom.Location = new System.Drawing.Point(13, 20);
            this.lblWelcom.Name = "lblWelcom";
            this.lblWelcom.Size = new System.Drawing.Size(392, 114);
            this.lblWelcom.TabIndex = 3;
            this.lblWelcom.Text = "Welcome";
            this.lblWelcom.Click += new System.EventHandler(this.lblWelcom_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(570, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 949);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.button4.Location = new System.Drawing.Point(10, 622);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(573, 85);
            this.button4.TabIndex = 21;
            this.button4.Text = "Log out";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(0, -10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 968);
            this.panel2.TabIndex = 7;
            // 
            // ManagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1572, 952);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelNavbar);
            this.Name = "ManagerMain";
            this.Text = "Form1";
            this.panelNavbar.ResumeLayout(false);
            this.panelNavbar.PerformLayout();
            this.panelButtonsNavigation.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavbar;
        private System.Windows.Forms.Panel panelButtonsNavigation;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelSidebarTraveller;
        private System.Windows.Forms.Label lblWelcom;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
    }
}