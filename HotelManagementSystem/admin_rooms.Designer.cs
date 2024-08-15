namespace HotelManagementSystem
{
    partial class admin_rooms
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            rooms_clearButton = new Button();
            rooms_deleteButton = new Button();
            rooms_updateButton = new Button();
            rooms_addButton = new Button();
            rooms_ImportButton = new Button();
            panel3 = new Panel();
            rooms_picture = new PictureBox();
            rooms_status = new ComboBox();
            label6 = new Label();
            rooms_price = new TextBox();
            label5 = new Label();
            rooms_roomName = new TextBox();
            label4 = new Label();
            rooms_type = new ComboBox();
            label3 = new Label();
            rooms_roomID = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rooms_picture).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(20, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 324);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 18);
            label1.Name = "label1";
            label1.Size = new Size(109, 18);
            label1.TabIndex = 2;
            label1.Text = "Room's Data";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(21, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.Size = new Size(737, 266);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(rooms_clearButton);
            panel2.Controls.Add(rooms_deleteButton);
            panel2.Controls.Add(rooms_updateButton);
            panel2.Controls.Add(rooms_addButton);
            panel2.Controls.Add(rooms_ImportButton);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(rooms_status);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(rooms_price);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(rooms_roomName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(rooms_type);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(rooms_roomID);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(20, 354);
            panel2.Name = "panel2";
            panel2.Size = new Size(778, 214);
            panel2.TabIndex = 1;
            // 
            // rooms_clearButton
            // 
            rooms_clearButton.BackColor = Color.MidnightBlue;
            rooms_clearButton.FlatAppearance.BorderSize = 0;
            rooms_clearButton.FlatAppearance.MouseDownBackColor = Color.Teal;
            rooms_clearButton.FlatAppearance.MouseOverBackColor = Color.Teal;
            rooms_clearButton.FlatStyle = FlatStyle.Flat;
            rooms_clearButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rooms_clearButton.ForeColor = Color.White;
            rooms_clearButton.Location = new Point(455, 156);
            rooms_clearButton.Name = "rooms_clearButton";
            rooms_clearButton.Size = new Size(103, 41);
            rooms_clearButton.TabIndex = 19;
            rooms_clearButton.Text = "Clear";
            rooms_clearButton.UseVisualStyleBackColor = false;
            rooms_clearButton.Click += rooms_clearButton_Click;
            // 
            // rooms_deleteButton
            // 
            rooms_deleteButton.BackColor = Color.MidnightBlue;
            rooms_deleteButton.FlatAppearance.BorderSize = 0;
            rooms_deleteButton.FlatAppearance.MouseDownBackColor = Color.Teal;
            rooms_deleteButton.FlatAppearance.MouseOverBackColor = Color.Teal;
            rooms_deleteButton.FlatStyle = FlatStyle.Flat;
            rooms_deleteButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rooms_deleteButton.ForeColor = Color.White;
            rooms_deleteButton.Location = new Point(334, 156);
            rooms_deleteButton.Name = "rooms_deleteButton";
            rooms_deleteButton.Size = new Size(103, 41);
            rooms_deleteButton.TabIndex = 18;
            rooms_deleteButton.Text = "Delete";
            rooms_deleteButton.UseVisualStyleBackColor = false;
            rooms_deleteButton.Click += rooms_deleteButton_Click;
            // 
            // rooms_updateButton
            // 
            rooms_updateButton.BackColor = Color.MidnightBlue;
            rooms_updateButton.FlatAppearance.BorderSize = 0;
            rooms_updateButton.FlatAppearance.MouseDownBackColor = Color.Teal;
            rooms_updateButton.FlatAppearance.MouseOverBackColor = Color.Teal;
            rooms_updateButton.FlatStyle = FlatStyle.Flat;
            rooms_updateButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rooms_updateButton.ForeColor = Color.White;
            rooms_updateButton.Location = new Point(210, 156);
            rooms_updateButton.Name = "rooms_updateButton";
            rooms_updateButton.Size = new Size(103, 41);
            rooms_updateButton.TabIndex = 17;
            rooms_updateButton.Text = "Update";
            rooms_updateButton.UseVisualStyleBackColor = false;
            rooms_updateButton.Click += rooms_updateButton_Click;
            // 
            // rooms_addButton
            // 
            rooms_addButton.BackColor = Color.MidnightBlue;
            rooms_addButton.FlatAppearance.BorderSize = 0;
            rooms_addButton.FlatAppearance.MouseDownBackColor = Color.Teal;
            rooms_addButton.FlatAppearance.MouseOverBackColor = Color.Teal;
            rooms_addButton.FlatStyle = FlatStyle.Flat;
            rooms_addButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rooms_addButton.ForeColor = Color.White;
            rooms_addButton.Location = new Point(89, 156);
            rooms_addButton.Name = "rooms_addButton";
            rooms_addButton.Size = new Size(103, 41);
            rooms_addButton.TabIndex = 16;
            rooms_addButton.Text = "Add";
            rooms_addButton.UseVisualStyleBackColor = false;
            rooms_addButton.Click += rooms_addButton_Click;
            // 
            // rooms_ImportButton
            // 
            rooms_ImportButton.BackColor = Color.MidnightBlue;
            rooms_ImportButton.FlatAppearance.BorderSize = 0;
            rooms_ImportButton.FlatAppearance.MouseDownBackColor = Color.Teal;
            rooms_ImportButton.FlatAppearance.MouseOverBackColor = Color.Teal;
            rooms_ImportButton.FlatStyle = FlatStyle.Flat;
            rooms_ImportButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rooms_ImportButton.ForeColor = Color.White;
            rooms_ImportButton.Location = new Point(655, 137);
            rooms_ImportButton.Name = "rooms_ImportButton";
            rooms_ImportButton.Size = new Size(103, 41);
            rooms_ImportButton.TabIndex = 14;
            rooms_ImportButton.Text = "Import";
            rooms_ImportButton.UseVisualStyleBackColor = false;
            rooms_ImportButton.Click += rooms_ImportButton_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Controls.Add(rooms_picture);
            panel3.Location = new Point(655, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(103, 101);
            panel3.TabIndex = 13;
            panel3.Paint += panel3_Paint;
            // 
            // rooms_picture
            // 
            rooms_picture.Location = new Point(0, 0);
            rooms_picture.Name = "rooms_picture";
            rooms_picture.Size = new Size(103, 101);
            rooms_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            rooms_picture.TabIndex = 20;
            rooms_picture.TabStop = false;
            // 
            // rooms_status
            // 
            rooms_status.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            rooms_status.FormattingEnabled = true;
            rooms_status.Items.AddRange(new object[] { "Active", "Inactive", "Occupied" });
            rooms_status.Location = new Point(361, 64);
            rooms_status.Name = "rooms_status";
            rooms_status.Size = new Size(155, 28);
            rooms_status.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(306, 67);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 11;
            label6.Text = "Status:";
            // 
            // rooms_price
            // 
            rooms_price.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            rooms_price.Location = new Point(361, 30);
            rooms_price.Name = "rooms_price";
            rooms_price.Size = new Size(155, 26);
            rooms_price.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(292, 33);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 9;
            label5.Text = "Price ($):";
            // 
            // rooms_roomName
            // 
            rooms_roomName.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            rooms_roomName.Location = new Point(108, 95);
            rooms_roomName.Name = "rooms_roomName";
            rooms_roomName.Size = new Size(155, 26);
            rooms_roomName.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 101);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 7;
            label4.Text = "Room Name:";
            // 
            // rooms_type
            // 
            rooms_type.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            rooms_type.FormattingEnabled = true;
            rooms_type.Items.AddRange(new object[] { "Single Room", "Double Room" });
            rooms_type.Location = new Point(108, 61);
            rooms_type.Name = "rooms_type";
            rooms_type.Size = new Size(155, 28);
            rooms_type.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 64);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 5;
            label3.Text = "Type:";
            // 
            // rooms_roomID
            // 
            rooms_roomID.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            rooms_roomID.Location = new Point(108, 30);
            rooms_roomID.Name = "rooms_roomID";
            rooms_roomID.Size = new Size(155, 26);
            rooms_roomID.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 33);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 3;
            label2.Text = "Room ID:";
            // 
            // admin_rooms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "admin_rooms";
            Size = new Size(821, 580);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rooms_picture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private DataGridView dataGridView1;
        private ComboBox rooms_type;
        private Label label3;
        private TextBox rooms_roomID;
        private Label label2;
        private Button rooms_ImportButton;
        private Panel panel3;
        private ComboBox rooms_status;
        private Label label6;
        private TextBox rooms_price;
        private Label label5;
        private TextBox rooms_roomName;
        private Label label4;
        private Button rooms_clearButton;
        private Button rooms_deleteButton;
        private Button rooms_updateButton;
        private Button rooms_addButton;
        private PictureBox rooms_picture;
    }
}
