namespace HotelManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            login_button = new Button();
            login_password = new TextBox();
            label4 = new Label();
            login_username = new TextBox();
            label3 = new Label();
            login_welcome = new Label();
            close = new Label();
            panel1 = new Panel();
            login_registerButton = new Button();
            login_registertxt = new Label();
            label5 = new Label();
            login_showPass = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // login_button
            // 
            login_button.BackColor = Color.MidnightBlue;
            login_button.FlatAppearance.BorderSize = 0;
            login_button.FlatAppearance.MouseDownBackColor = Color.Teal;
            login_button.FlatAppearance.MouseOverBackColor = Color.Teal;
            login_button.FlatStyle = FlatStyle.Flat;
            login_button.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_button.ForeColor = Color.White;
            login_button.Location = new Point(402, 288);
            login_button.Name = "login_button";
            login_button.Size = new Size(118, 39);
            login_button.TabIndex = 25;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = false;
            login_button.Click += login_button_Click;
            // 
            // login_password
            // 
            login_password.BorderStyle = BorderStyle.FixedSingle;
            login_password.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_password.Location = new Point(336, 232);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(250, 26);
            login_password.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(337, 207);
            label4.Name = "label4";
            label4.Size = new Size(100, 22);
            label4.TabIndex = 23;
            label4.Text = "Password";
            // 
            // login_username
            // 
            login_username.BorderStyle = BorderStyle.FixedSingle;
            login_username.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_username.Location = new Point(337, 166);
            login_username.Name = "login_username";
            login_username.Size = new Size(250, 26);
            login_username.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(337, 141);
            label3.Name = "label3";
            label3.Size = new Size(103, 22);
            label3.TabIndex = 21;
            label3.Text = "Username";
            // 
            // login_welcome
            // 
            login_welcome.AutoSize = true;
            login_welcome.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_welcome.Location = new Point(354, 65);
            login_welcome.Name = "login_welcome";
            login_welcome.Size = new Size(218, 24);
            login_welcome.TabIndex = 20;
            login_welcome.Text = "Welcome back, User";
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.Location = new Point(613, 7);
            close.Name = "close";
            close.Size = new Size(15, 15);
            close.TabIndex = 19;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(login_registerButton);
            panel1.Controls.Add(login_registertxt);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 432);
            panel1.TabIndex = 18;
            // 
            // login_registerButton
            // 
            login_registerButton.BackColor = Color.MidnightBlue;
            login_registerButton.FlatAppearance.MouseDownBackColor = Color.Teal;
            login_registerButton.FlatAppearance.MouseOverBackColor = Color.Teal;
            login_registerButton.FlatStyle = FlatStyle.Flat;
            login_registerButton.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_registerButton.ForeColor = Color.White;
            login_registerButton.Location = new Point(19, 369);
            login_registerButton.Name = "login_registerButton";
            login_registerButton.Size = new Size(254, 39);
            login_registerButton.TabIndex = 8;
            login_registerButton.Text = "Register";
            login_registerButton.UseVisualStyleBackColor = false;
            login_registerButton.Click += login_registerButton_Click;
            // 
            // login_registertxt
            // 
            login_registertxt.AutoSize = true;
            login_registertxt.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_registertxt.ForeColor = Color.White;
            login_registertxt.Location = new Point(65, 348);
            login_registertxt.Name = "login_registertxt";
            login_registertxt.Size = new Size(170, 18);
            login_registertxt.TabIndex = 4;
            login_registertxt.Text = "Create new account";
            login_registertxt.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(19, 128);
            label5.Name = "label5";
            label5.Size = new Size(254, 22);
            label5.TabIndex = 3;
            label5.Text = "Hotel Management System";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_showPass.Location = new Point(337, 264);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(120, 18);
            login_showPass.TabIndex = 26;
            login_showPass.Text = "Show Password";
            login_showPass.UseVisualStyleBackColor = true;
            login_showPass.CheckedChanged += login_showPass_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(633, 432);
            Controls.Add(login_button);
            Controls.Add(login_password);
            Controls.Add(label4);
            Controls.Add(login_username);
            Controls.Add(label3);
            Controls.Add(login_welcome);
            Controls.Add(close);
            Controls.Add(panel1);
            Controls.Add(login_showPass);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login_button;
        private TextBox login_password;
        private Label label4;
        private TextBox login_username;
        private Label label3;
        private Label login_welcome;
        private Label close;
        private Panel panel1;
        private Button login_registerButton;
        private Label login_registertxt;
        private Label label5;
        private CheckBox login_showPass;
    }
}
