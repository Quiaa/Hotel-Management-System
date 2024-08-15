namespace HotelManagementSystem
{
    partial class clientInfo
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
            label2 = new Label();
            close = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            client_clearButton = new Button();
            client_bookButton = new Button();
            client_address = new TextBox();
            label8 = new Label();
            client_gender = new ComboBox();
            label7 = new Label();
            client_contact = new TextBox();
            label6 = new Label();
            client_email = new TextBox();
            label5 = new Label();
            client_fullName = new TextBox();
            label4 = new Label();
            client_bookID = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(150, 17);
            label2.TabIndex = 1;
            label2.Text = "Client's Information";
            // 
            // close
            // 
            close.AutoSize = true;
            close.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close.ForeColor = Color.White;
            close.Location = new Point(732, 11);
            close.Name = "close";
            close.Size = new Size(18, 18);
            close.TabIndex = 0;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(762, 47);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(client_clearButton);
            panel2.Controls.Add(client_bookButton);
            panel2.Controls.Add(client_address);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(client_gender);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(client_contact);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(client_email);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(client_fullName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(client_bookID);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(738, 470);
            panel2.TabIndex = 3;
            // 
            // client_clearButton
            // 
            client_clearButton.BackColor = Color.MidnightBlue;
            client_clearButton.FlatAppearance.BorderSize = 0;
            client_clearButton.FlatAppearance.MouseDownBackColor = Color.Teal;
            client_clearButton.FlatAppearance.MouseOverBackColor = Color.Teal;
            client_clearButton.FlatStyle = FlatStyle.Flat;
            client_clearButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            client_clearButton.ForeColor = Color.White;
            client_clearButton.Location = new Point(393, 298);
            client_clearButton.Name = "client_clearButton";
            client_clearButton.Size = new Size(228, 41);
            client_clearButton.TabIndex = 18;
            client_clearButton.Text = "Clear";
            client_clearButton.UseVisualStyleBackColor = false;
            client_clearButton.Click += client_clearButton_Click;
            // 
            // client_bookButton
            // 
            client_bookButton.BackColor = Color.MidnightBlue;
            client_bookButton.FlatAppearance.BorderSize = 0;
            client_bookButton.FlatAppearance.MouseDownBackColor = Color.Teal;
            client_bookButton.FlatAppearance.MouseOverBackColor = Color.Teal;
            client_bookButton.FlatStyle = FlatStyle.Flat;
            client_bookButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            client_bookButton.ForeColor = Color.White;
            client_bookButton.Location = new Point(105, 298);
            client_bookButton.Name = "client_bookButton";
            client_bookButton.Size = new Size(228, 41);
            client_bookButton.TabIndex = 17;
            client_bookButton.Text = "Book Now";
            client_bookButton.UseVisualStyleBackColor = false;
            client_bookButton.Click += client_bookButton_Click;
            // 
            // client_address
            // 
            client_address.BorderStyle = BorderStyle.FixedSingle;
            client_address.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            client_address.Location = new Point(473, 168);
            client_address.Multiline = true;
            client_address.Name = "client_address";
            client_address.Size = new Size(149, 61);
            client_address.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label8.Location = new Point(406, 168);
            label8.Name = "label8";
            label8.Size = new Size(61, 16);
            label8.TabIndex = 10;
            label8.Text = "Address:";
            // 
            // client_gender
            // 
            client_gender.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            client_gender.FormattingEnabled = true;
            client_gender.Items.AddRange(new object[] { "Male", "Female" });
            client_gender.Location = new Point(473, 126);
            client_gender.Name = "client_gender";
            client_gender.Size = new Size(149, 24);
            client_gender.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label7.Location = new Point(409, 130);
            label7.Name = "label7";
            label7.Size = new Size(58, 16);
            label7.TabIndex = 8;
            label7.Text = "Gender:";
            // 
            // client_contact
            // 
            client_contact.BorderStyle = BorderStyle.FixedSingle;
            client_contact.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            client_contact.Location = new Point(187, 207);
            client_contact.Name = "client_contact";
            client_contact.Size = new Size(144, 22);
            client_contact.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label6.Location = new Point(68, 209);
            label6.Name = "label6";
            label6.Size = new Size(113, 16);
            label6.TabIndex = 6;
            label6.Text = "Contact Number:";
            // 
            // client_email
            // 
            client_email.BorderStyle = BorderStyle.FixedSingle;
            client_email.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            client_email.Location = new Point(187, 168);
            client_email.Name = "client_email";
            client_email.Size = new Size(144, 22);
            client_email.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label5.Location = new Point(80, 170);
            label5.Name = "label5";
            label5.Size = new Size(101, 16);
            label5.TabIndex = 4;
            label5.Text = "Email Address:";
            // 
            // client_fullName
            // 
            client_fullName.BorderStyle = BorderStyle.FixedSingle;
            client_fullName.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            client_fullName.Location = new Point(187, 128);
            client_fullName.Name = "client_fullName";
            client_fullName.Size = new Size(144, 22);
            client_fullName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label4.Location = new Point(105, 130);
            label4.Name = "label4";
            label4.Size = new Size(76, 16);
            label4.TabIndex = 2;
            label4.Text = "Full Name:";
            // 
            // client_bookID
            // 
            client_bookID.AutoSize = true;
            client_bookID.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            client_bookID.Location = new Point(187, 93);
            client_bookID.Name = "client_bookID";
            client_bookID.Size = new Size(60, 16);
            client_bookID.TabIndex = 1;
            client_bookID.Text = "Book ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label1.Location = new Point(121, 93);
            label1.Name = "label1";
            label1.Size = new Size(60, 16);
            label1.TabIndex = 0;
            label1.Text = "Book ID:";
            // 
            // clientInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(762, 556);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "clientInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "clientInfo";
            TopMost = true;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Label close;
        private Panel panel1;
        private Panel panel2;
        private Label client_bookID;
        private Label label1;
        private TextBox client_email;
        private Label label5;
        private TextBox client_fullName;
        private Label label4;
        private ComboBox client_gender;
        private Label label7;
        private TextBox client_contact;
        private Label label6;
        private TextBox client_address;
        private Label label8;
        private Button client_clearButton;
        private Button client_bookButton;
    }
}