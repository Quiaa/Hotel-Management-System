namespace HotelManagementSystem
{
    partial class staffMainForm
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
            panel3 = new Panel();
            admin_dashboard1 = new admin_dashboard();
            staff_bookRoom1 = new staff_bookRoom();
            admin_customers1 = new admin_customers();
            panel2 = new Panel();
            logout_button = new Button();
            customers_button = new Button();
            addUser_button = new Button();
            dashboard_button = new Button();
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            close = new Label();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(admin_dashboard1);
            panel3.Controls.Add(staff_bookRoom1);
            panel3.Controls.Add(admin_customers1);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(panel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1064, 627);
            panel3.TabIndex = 5;
            // 
            // admin_dashboard1
            // 
            admin_dashboard1.Location = new Point(243, 47);
            admin_dashboard1.Name = "admin_dashboard1";
            admin_dashboard1.Size = new Size(821, 580);
            admin_dashboard1.TabIndex = 5;
            // 
            // staff_bookRoom1
            // 
            staff_bookRoom1.Location = new Point(243, 47);
            staff_bookRoom1.Name = "staff_bookRoom1";
            staff_bookRoom1.Size = new Size(821, 580);
            staff_bookRoom1.TabIndex = 4;
            // 
            // admin_customers1
            // 
            admin_customers1.Location = new Point(243, 47);
            admin_customers1.Name = "admin_customers1";
            admin_customers1.Size = new Size(821, 580);
            admin_customers1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(logout_button);
            panel2.Controls.Add(customers_button);
            panel2.Controls.Add(addUser_button);
            panel2.Controls.Add(dashboard_button);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 580);
            panel2.TabIndex = 2;
            // 
            // logout_button
            // 
            logout_button.BackColor = Color.Teal;
            logout_button.Cursor = Cursors.Hand;
            logout_button.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            logout_button.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            logout_button.FlatStyle = FlatStyle.Flat;
            logout_button.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logout_button.ForeColor = Color.White;
            logout_button.Location = new Point(28, 498);
            logout_button.Name = "logout_button";
            logout_button.Size = new Size(184, 56);
            logout_button.TabIndex = 7;
            logout_button.Text = "Logout";
            logout_button.UseVisualStyleBackColor = false;
            logout_button.Click += logout_button_Click;
            // 
            // customers_button
            // 
            customers_button.BackColor = Color.Teal;
            customers_button.Cursor = Cursors.Hand;
            customers_button.FlatAppearance.BorderSize = 0;
            customers_button.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            customers_button.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            customers_button.FlatStyle = FlatStyle.Flat;
            customers_button.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customers_button.ForeColor = Color.White;
            customers_button.Location = new Point(28, 238);
            customers_button.Name = "customers_button";
            customers_button.Size = new Size(184, 56);
            customers_button.TabIndex = 6;
            customers_button.Text = "Customers";
            customers_button.UseVisualStyleBackColor = false;
            customers_button.Click += customers_button_Click;
            // 
            // addUser_button
            // 
            addUser_button.BackColor = Color.Teal;
            addUser_button.Cursor = Cursors.Hand;
            addUser_button.FlatAppearance.BorderSize = 0;
            addUser_button.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            addUser_button.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            addUser_button.FlatStyle = FlatStyle.Flat;
            addUser_button.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUser_button.ForeColor = Color.White;
            addUser_button.Location = new Point(28, 176);
            addUser_button.Name = "addUser_button";
            addUser_button.Size = new Size(184, 56);
            addUser_button.TabIndex = 4;
            addUser_button.Text = "Book Hotel";
            addUser_button.UseVisualStyleBackColor = false;
            addUser_button.Click += addUser_button_Click;
            // 
            // dashboard_button
            // 
            dashboard_button.BackColor = Color.Teal;
            dashboard_button.Cursor = Cursors.Hand;
            dashboard_button.FlatAppearance.BorderSize = 0;
            dashboard_button.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            dashboard_button.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            dashboard_button.FlatStyle = FlatStyle.Flat;
            dashboard_button.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboard_button.ForeColor = Color.White;
            dashboard_button.Location = new Point(28, 114);
            dashboard_button.Name = "dashboard_button";
            dashboard_button.Size = new Size(184, 56);
            dashboard_button.TabIndex = 3;
            dashboard_button.Text = "Dashboard";
            dashboard_button.UseVisualStyleBackColor = false;
            dashboard_button.Click += dashboard_button_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(59, 75);
            label3.Name = "label3";
            label3.Size = new Size(119, 17);
            label3.TabIndex = 2;
            label3.Text = "Welcome, User";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1064, 47);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(200, 17);
            label2.TabIndex = 1;
            label2.Text = "Hotel Management System";
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.ForeColor = Color.White;
            close.Location = new Point(1039, 11);
            close.Name = "close";
            close.Size = new Size(18, 18);
            close.TabIndex = 0;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // staffMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 627);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "staffMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "staffMainForm";
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel1;
        private Label label2;
        private Label close;
        private Panel panel2;
        private Button logout_button;
        private Button customers_button;
        private Button addUser_button;
        private Button dashboard_button;
        private Label label3;
        private admin_dashboard admin_dashboard1;
        private staff_bookRoom staff_bookRoom1;
        private admin_customers admin_customers1;
    }
}