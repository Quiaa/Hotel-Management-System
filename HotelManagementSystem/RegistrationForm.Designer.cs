namespace HotelManagementSystem
{
    partial class RegistrationForm
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
            register_button = new Button();
            register_confirmpassword = new TextBox();
            label4 = new Label();
            register_username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            close = new Label();
            panel1 = new Panel();
            register_signinButton = new Button();
            label6 = new Label();
            label5 = new Label();
            register_showPass = new CheckBox();
            register_password = new TextBox();
            label7 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // register_button
            // 
            register_button.BackColor = Color.MidnightBlue;
            register_button.FlatAppearance.BorderSize = 0;
            register_button.FlatAppearance.MouseDownBackColor = Color.Teal;
            register_button.FlatAppearance.MouseOverBackColor = Color.Teal;
            register_button.FlatStyle = FlatStyle.Flat;
            register_button.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_button.ForeColor = Color.White;
            register_button.Location = new Point(401, 337);
            register_button.Name = "register_button";
            register_button.Size = new Size(118, 39);
            register_button.TabIndex = 16;
            register_button.Text = "Sign Up";
            register_button.UseVisualStyleBackColor = false;
            register_button.Click += register_button_Click;
            // 
            // register_confirmpassword
            // 
            register_confirmpassword.BorderStyle = BorderStyle.FixedSingle;
            register_confirmpassword.Font = new Font("Arial Narrow", 12F);
            register_confirmpassword.Location = new Point(334, 275);
            register_confirmpassword.Name = "register_confirmpassword";
            register_confirmpassword.PasswordChar = '*';
            register_confirmpassword.Size = new Size(250, 26);
            register_confirmpassword.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(334, 250);
            label4.Name = "label4";
            label4.Size = new Size(177, 22);
            label4.TabIndex = 14;
            label4.Text = "Confirm Password";
            // 
            // register_username
            // 
            register_username.BorderStyle = BorderStyle.FixedSingle;
            register_username.Font = new Font("Arial Narrow", 12F);
            register_username.Location = new Point(334, 148);
            register_username.Name = "register_username";
            register_username.Size = new Size(250, 26);
            register_username.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(334, 123);
            label3.Name = "label3";
            label3.Size = new Size(103, 22);
            label3.TabIndex = 12;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(351, 77);
            label2.Name = "label2";
            label2.Size = new Size(134, 24);
            label2.TabIndex = 11;
            label2.Text = "Registration";
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.Location = new Point(612, 9);
            close.Name = "close";
            close.Size = new Size(15, 15);
            close.TabIndex = 10;
            close.Text = "X";
            close.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(register_signinButton);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 432);
            panel1.TabIndex = 9;
            // 
            // register_signinButton
            // 
            register_signinButton.BackColor = Color.MidnightBlue;
            register_signinButton.FlatAppearance.MouseDownBackColor = Color.Teal;
            register_signinButton.FlatAppearance.MouseOverBackColor = Color.Teal;
            register_signinButton.FlatStyle = FlatStyle.Flat;
            register_signinButton.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_signinButton.ForeColor = Color.White;
            register_signinButton.Location = new Point(19, 369);
            register_signinButton.Name = "register_signinButton";
            register_signinButton.Size = new Size(254, 39);
            register_signinButton.TabIndex = 8;
            register_signinButton.Text = "Sign In";
            register_signinButton.UseVisualStyleBackColor = false;
            register_signinButton.Click += register_signinButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(50, 348);
            label6.Name = "label6";
            label6.Size = new Size(197, 18);
            label6.TabIndex = 4;
            label6.Text = "Already has an account";
            label6.TextAlign = ContentAlignment.MiddleLeft;
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
            // register_showPass
            // 
            register_showPass.AutoSize = true;
            register_showPass.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_showPass.Location = new Point(334, 307);
            register_showPass.Name = "register_showPass";
            register_showPass.Size = new Size(120, 18);
            register_showPass.TabIndex = 17;
            register_showPass.Text = "Show Password";
            register_showPass.UseVisualStyleBackColor = true;
            register_showPass.CheckedChanged += register_showPass_CheckedChanged;
            // 
            // register_password
            // 
            register_password.BorderStyle = BorderStyle.FixedSingle;
            register_password.Font = new Font("Arial Narrow", 12F);
            register_password.Location = new Point(334, 211);
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(250, 26);
            register_password.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(334, 186);
            label7.Name = "label7";
            label7.Size = new Size(100, 22);
            label7.TabIndex = 18;
            label7.Text = "Password";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(633, 432);
            Controls.Add(register_password);
            Controls.Add(label7);
            Controls.Add(register_button);
            Controls.Add(register_confirmpassword);
            Controls.Add(label4);
            Controls.Add(register_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(close);
            Controls.Add(panel1);
            Controls.Add(register_showPass);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrationForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button register_button;
        private TextBox register_confirmpassword;
        private Label label4;
        private TextBox register_username;
        private Label label3;
        private Label label2;
        private Label close;
        private Panel panel1;
        private Button register_signinButton;
        private Label label6;
        private Label label5;
        private CheckBox register_showPass;
        private TextBox register_password;
        private Label label7;
    }
}