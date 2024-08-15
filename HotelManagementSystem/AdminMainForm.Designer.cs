namespace HotelManagementSystem
{
    partial class AdminMainForm
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
            panel1 = new Panel();
            label2 = new Label();
            close = new Label();
            panel2 = new Panel();
            logout_button = new Button();
            customers_button = new Button();
            rooms_button = new Button();
            addUser_button = new Button();
            dashboard_button = new Button();
            label3 = new Label();
            panel3 = new Panel();
            admin_dashboard1 = new admin_dashboard();
            admin_addUser2 = new admin_addUser();
            admin_rooms1 = new admin_rooms();
            admin_customers1 = new admin_customers();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
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
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
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
            close.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(logout_button);
            panel2.Controls.Add(customers_button);
            panel2.Controls.Add(rooms_button);
            panel2.Controls.Add(addUser_button);
            panel2.Controls.Add(dashboard_button);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 580);
            panel2.TabIndex = 1;
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
            customers_button.Location = new Point(29, 293);
            customers_button.Name = "customers_button";
            customers_button.Size = new Size(184, 56);
            customers_button.TabIndex = 6;
            customers_button.Text = "Customers";
            customers_button.UseVisualStyleBackColor = false;
            customers_button.Click += customers_button_Click;
            // 
            // rooms_button
            // 
            rooms_button.BackColor = Color.Teal;
            rooms_button.Cursor = Cursors.Hand;
            rooms_button.FlatAppearance.BorderSize = 0;
            rooms_button.FlatAppearance.MouseDownBackColor = Color.MidnightBlue;
            rooms_button.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            rooms_button.FlatStyle = FlatStyle.Flat;
            rooms_button.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rooms_button.ForeColor = Color.White;
            rooms_button.Location = new Point(29, 231);
            rooms_button.Name = "rooms_button";
            rooms_button.Size = new Size(184, 56);
            rooms_button.TabIndex = 5;
            rooms_button.Text = "Rooms";
            rooms_button.UseVisualStyleBackColor = false;
            rooms_button.Click += rooms_button_Click;
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
            addUser_button.Text = "Add User";
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
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(admin_dashboard1);
            panel3.Controls.Add(admin_addUser2);
            panel3.Controls.Add(admin_rooms1);
            panel3.Controls.Add(admin_customers1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(243, 47);
            panel3.Name = "panel3";
            panel3.Size = new Size(821, 580);
            panel3.TabIndex = 2;
            // 
            // admin_dashboard1
            // 
            admin_dashboard1.Location = new Point(0, 0);
            admin_dashboard1.Name = "admin_dashboard1";
            admin_dashboard1.Size = new Size(821, 580);
            admin_dashboard1.TabIndex = 3;
            // 
            // admin_addUser2
            // 
            admin_addUser2.Location = new Point(0, 0);
            admin_addUser2.Name = "admin_addUser2";
            admin_addUser2.Size = new Size(821, 580);
            admin_addUser2.TabIndex = 2;
            // 
            // admin_rooms1
            // 
            admin_rooms1.Location = new Point(0, 0);
            admin_rooms1.Name = "admin_rooms1";
            admin_rooms1.Size = new Size(821, 580);
            admin_rooms1.TabIndex = 1;
            // 
            // admin_customers1
            // 
            admin_customers1.Location = new Point(0, 0);
            admin_customers1.Name = "admin_customers1";
            admin_customers1.Size = new Size(821, 580);
            admin_customers1.TabIndex = 0;
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 627);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminMainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label close;
        private Label label2;
        private Panel panel2;
        private Button dashboard_button;
        private Label label3;
        private Button logout_button;
        private Button customers_button;
        private Button rooms_button;
        private Button addUser_button;
        private Panel panel3;
        private admin_addUser admin_addUser1;
        private admin_addUser admin_addUser2;
        private admin_rooms admin_rooms1;
        private admin_customers admin_customers1;
        private admin_dashboard admin_dashboard1;
    }
}