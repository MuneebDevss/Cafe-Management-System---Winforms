namespace CafeManagementSystem
{
    partial class AddCashier
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Salary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Emails = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Names = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Brown;
            this.button2.Location = new System.Drawing.Point(1356, 801);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 102);
            this.button2.TabIndex = 47;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Location = new System.Drawing.Point(1083, 801);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 102);
            this.button1.TabIndex = 46;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Salary
            // 
            this.Salary.Location = new System.Drawing.Point(344, 821);
            this.Salary.Multiline = true;
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(429, 56);
            this.Salary.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 763);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 37);
            this.label5.TabIndex = 44;
            this.label5.Text = "Salary";
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(344, 664);
            this.Phone.Multiline = true;
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(429, 56);
            this.Phone.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 606);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 37);
            this.label4.TabIndex = 42;
            this.label4.Text = "Phone#";
            // 
            // Emails
            // 
            this.Emails.Location = new System.Drawing.Point(344, 499);
            this.Emails.Multiline = true;
            this.Emails.Name = "Emails";
            this.Emails.Size = new System.Drawing.Size(429, 56);
            this.Emails.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 37);
            this.label3.TabIndex = 40;
            this.label3.Text = "Email";
            // 
            // Names
            // 
            this.Names.Location = new System.Drawing.Point(344, 328);
            this.Names.Multiline = true;
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(429, 56);
            this.Names.TabIndex = 39;
            this.Names.TextChanged += new System.EventHandler(this.Names_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 37);
            this.label2.TabIndex = 38;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button4.Location = new System.Drawing.Point(231, 72);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(216, 102);
            this.button4.TabIndex = 63;
            this.button4.Text = "Cashier";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.CadetBlue;
            this.button3.Location = new System.Drawing.Point(27, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 102);
            this.button3.TabIndex = 62;
            this.button3.Text = "Server";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.BackColor = System.Drawing.Color.CadetBlue;
            this.button5.Location = new System.Drawing.Point(440, 71);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(216, 102);
            this.button5.TabIndex = 64;
            this.button5.Text = "Manager";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // AddCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1884, 992);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Emails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Names);
            this.Controls.Add(this.label2);
            this.Name = "AddCashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStaff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Salary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Emails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Names;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
    }
}