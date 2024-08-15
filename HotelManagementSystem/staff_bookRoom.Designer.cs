namespace HotelManagementSystem
{
    partial class staff_bookRoom
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
            panel7 = new Panel();
            bookRoom_regPrice = new Label();
            label3 = new Label();
            bookRoom_clearButton = new Button();
            bookRoom_scheduleButton = new Button();
            bookRoom_bookButton = new Button();
            bookRoom_total = new Label();
            label14 = new Label();
            bookRoom_to = new DateTimePicker();
            bookRoom_from = new DateTimePicker();
            label13 = new Label();
            label12 = new Label();
            bookRoom_status = new Label();
            label11 = new Label();
            bookRoom_roomName = new Label();
            label9 = new Label();
            bookRoom_roomType = new Label();
            label7 = new Label();
            bookRoom_roomID = new Label();
            label4 = new Label();
            panel6 = new Panel();
            panel8 = new Panel();
            bookRoom_ImageView = new PictureBox();
            panel5 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookRoom_ImageView).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(bookRoom_regPrice);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(bookRoom_clearButton);
            panel7.Controls.Add(bookRoom_scheduleButton);
            panel7.Controls.Add(bookRoom_bookButton);
            panel7.Controls.Add(bookRoom_total);
            panel7.Controls.Add(label14);
            panel7.Controls.Add(bookRoom_to);
            panel7.Controls.Add(bookRoom_from);
            panel7.Controls.Add(label13);
            panel7.Controls.Add(label12);
            panel7.Controls.Add(bookRoom_status);
            panel7.Controls.Add(label11);
            panel7.Controls.Add(bookRoom_roomName);
            panel7.Controls.Add(label9);
            panel7.Controls.Add(bookRoom_roomType);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(bookRoom_roomID);
            panel7.Controls.Add(label4);
            panel7.Location = new Point(511, 21);
            panel7.Name = "panel7";
            panel7.Size = new Size(295, 539);
            panel7.TabIndex = 5;
            // 
            // bookRoom_regPrice
            // 
            bookRoom_regPrice.AutoSize = true;
            bookRoom_regPrice.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            bookRoom_regPrice.Location = new Point(124, 136);
            bookRoom_regPrice.Name = "bookRoom_regPrice";
            bookRoom_regPrice.Size = new Size(39, 18);
            bookRoom_regPrice.TabIndex = 23;
            bookRoom_regPrice.Text = "0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(10, 137);
            label3.Name = "label3";
            label3.Size = new Size(108, 16);
            label3.TabIndex = 22;
            label3.Text = "Regular Price ($):";
            // 
            // bookRoom_clearButton
            // 
            bookRoom_clearButton.BackColor = Color.MidnightBlue;
            bookRoom_clearButton.FlatAppearance.BorderSize = 0;
            bookRoom_clearButton.FlatAppearance.MouseDownBackColor = Color.Teal;
            bookRoom_clearButton.FlatAppearance.MouseOverBackColor = Color.Teal;
            bookRoom_clearButton.FlatStyle = FlatStyle.Flat;
            bookRoom_clearButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookRoom_clearButton.ForeColor = Color.White;
            bookRoom_clearButton.Location = new Point(33, 456);
            bookRoom_clearButton.Name = "bookRoom_clearButton";
            bookRoom_clearButton.Size = new Size(233, 41);
            bookRoom_clearButton.TabIndex = 21;
            bookRoom_clearButton.Text = "Clear";
            bookRoom_clearButton.UseVisualStyleBackColor = false;
            bookRoom_clearButton.Click += bookRoom_clearButton_Click;
            // 
            // bookRoom_scheduleButton
            // 
            bookRoom_scheduleButton.BackColor = Color.MidnightBlue;
            bookRoom_scheduleButton.FlatAppearance.BorderSize = 0;
            bookRoom_scheduleButton.FlatAppearance.MouseDownBackColor = Color.Teal;
            bookRoom_scheduleButton.FlatAppearance.MouseOverBackColor = Color.Teal;
            bookRoom_scheduleButton.FlatStyle = FlatStyle.Flat;
            bookRoom_scheduleButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookRoom_scheduleButton.ForeColor = Color.White;
            bookRoom_scheduleButton.Location = new Point(33, 249);
            bookRoom_scheduleButton.Name = "bookRoom_scheduleButton";
            bookRoom_scheduleButton.Size = new Size(233, 41);
            bookRoom_scheduleButton.TabIndex = 19;
            bookRoom_scheduleButton.Text = "Schedule Now";
            bookRoom_scheduleButton.UseVisualStyleBackColor = false;
            bookRoom_scheduleButton.Click += bookRoom_scheduleButton_Click;
            // 
            // bookRoom_bookButton
            // 
            bookRoom_bookButton.BackColor = Color.MidnightBlue;
            bookRoom_bookButton.FlatAppearance.BorderSize = 0;
            bookRoom_bookButton.FlatAppearance.MouseDownBackColor = Color.Teal;
            bookRoom_bookButton.FlatAppearance.MouseOverBackColor = Color.Teal;
            bookRoom_bookButton.FlatStyle = FlatStyle.Flat;
            bookRoom_bookButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookRoom_bookButton.ForeColor = Color.White;
            bookRoom_bookButton.Location = new Point(33, 362);
            bookRoom_bookButton.Name = "bookRoom_bookButton";
            bookRoom_bookButton.Size = new Size(233, 41);
            bookRoom_bookButton.TabIndex = 18;
            bookRoom_bookButton.Text = "Book";
            bookRoom_bookButton.UseVisualStyleBackColor = false;
            bookRoom_bookButton.Click += bookRoom_bookButton_Click;
            // 
            // bookRoom_total
            // 
            bookRoom_total.AutoSize = true;
            bookRoom_total.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            bookRoom_total.Location = new Point(174, 308);
            bookRoom_total.Name = "bookRoom_total";
            bookRoom_total.Size = new Size(40, 19);
            bookRoom_total.TabIndex = 13;
            bookRoom_total.Text = "0.00";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label14.Location = new Point(60, 309);
            label14.Name = "label14";
            label14.Size = new Size(108, 18);
            label14.TabIndex = 12;
            label14.Text = "Total Price ($):";
            // 
            // bookRoom_to
            // 
            bookRoom_to.Location = new Point(115, 211);
            bookRoom_to.Name = "bookRoom_to";
            bookRoom_to.Size = new Size(167, 23);
            bookRoom_to.TabIndex = 11;
            // 
            // bookRoom_from
            // 
            bookRoom_from.Location = new Point(115, 177);
            bookRoom_from.Name = "bookRoom_from";
            bookRoom_from.Size = new Size(167, 23);
            bookRoom_from.TabIndex = 10;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label13.Location = new Point(27, 216);
            label13.Name = "label13";
            label13.Size = new Size(82, 16);
            label13.TabIndex = 9;
            label13.Text = "To Schedule:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label12.Location = new Point(10, 182);
            label12.Name = "label12";
            label12.Size = new Size(99, 16);
            label12.TabIndex = 8;
            label12.Text = "From Schedule:";
            // 
            // bookRoom_status
            // 
            bookRoom_status.AutoSize = true;
            bookRoom_status.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            bookRoom_status.Location = new Point(124, 108);
            bookRoom_status.Name = "bookRoom_status";
            bookRoom_status.Size = new Size(56, 18);
            bookRoom_status.TabIndex = 7;
            bookRoom_status.Text = "------------";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label11.Location = new Point(69, 110);
            label11.Name = "label11";
            label11.Size = new Size(49, 16);
            label11.TabIndex = 6;
            label11.Text = "Status:";
            // 
            // bookRoom_roomName
            // 
            bookRoom_roomName.AutoSize = true;
            bookRoom_roomName.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            bookRoom_roomName.Location = new Point(124, 78);
            bookRoom_roomName.Name = "bookRoom_roomName";
            bookRoom_roomName.Size = new Size(56, 18);
            bookRoom_roomName.TabIndex = 5;
            bookRoom_roomName.Text = "------------";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.Location = new Point(35, 80);
            label9.Name = "label9";
            label9.Size = new Size(83, 16);
            label9.TabIndex = 4;
            label9.Text = "Room Name:";
            // 
            // bookRoom_roomType
            // 
            bookRoom_roomType.AutoSize = true;
            bookRoom_roomType.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            bookRoom_roomType.Location = new Point(124, 50);
            bookRoom_roomType.Name = "bookRoom_roomType";
            bookRoom_roomType.Size = new Size(56, 18);
            bookRoom_roomType.TabIndex = 3;
            bookRoom_roomType.Text = "------------";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(42, 52);
            label7.Name = "label7";
            label7.Size = new Size(76, 16);
            label7.TabIndex = 2;
            label7.Text = "Room Type:";
            // 
            // bookRoom_roomID
            // 
            bookRoom_roomID.AutoSize = true;
            bookRoom_roomID.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            bookRoom_roomID.Location = new Point(124, 23);
            bookRoom_roomID.Name = "bookRoom_roomID";
            bookRoom_roomID.Size = new Size(56, 18);
            bookRoom_roomID.TabIndex = 1;
            bookRoom_roomID.Text = "------------";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(57, 25);
            label4.Name = "label4";
            label4.Size = new Size(61, 16);
            label4.TabIndex = 0;
            label4.Text = "Room ID:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(panel8);
            panel6.Location = new Point(14, 372);
            panel6.Name = "panel6";
            panel6.Size = new Size(487, 188);
            panel6.TabIndex = 4;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Silver;
            panel8.Controls.Add(bookRoom_ImageView);
            panel8.Location = new Point(12, 11);
            panel8.Name = "panel8";
            panel8.Size = new Size(459, 164);
            panel8.TabIndex = 0;
            // 
            // bookRoom_ImageView
            // 
            bookRoom_ImageView.Location = new Point(0, 0);
            bookRoom_ImageView.Name = "bookRoom_ImageView";
            bookRoom_ImageView.Size = new Size(459, 164);
            bookRoom_ImageView.SizeMode = PictureBoxSizeMode.StretchImage;
            bookRoom_ImageView.TabIndex = 0;
            bookRoom_ImageView.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(dataGridView1);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(14, 21);
            panel5.Name = "panel5";
            panel5.Size = new Size(487, 334);
            panel5.TabIndex = 3;
            // 
            // dataGridView1
            // 
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
            dataGridView1.Location = new Point(12, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.Size = new Size(459, 276);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(140, 18);
            label1.TabIndex = 3;
            label1.Text = "Available Rooms";
            // 
            // staff_bookRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Name = "staff_bookRoom";
            Size = new Size(821, 580);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bookRoom_ImageView).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private Button bookRoom_clearButton;
        private Button bookRoom_scheduleButton;
        private Button bookRoom_bookButton;
        private Label bookRoom_total;
        private Label label14;
        private DateTimePicker bookRoom_to;
        private DateTimePicker bookRoom_from;
        private Label label13;
        private Label label12;
        private Label bookRoom_status;
        private Label label11;
        private Label bookRoom_roomName;
        private Label label9;
        private Label bookRoom_roomType;
        private Label label7;
        private Label bookRoom_roomID;
        private Label label4;
        private Panel panel6;
        private Panel panel8;
        private PictureBox bookRoom_ImageView;
        private Panel panel5;
        private DataGridView dataGridView1;
        private Label label1;
        private Label bookRoom_regPrice;
        private Label label3;
    }
}
