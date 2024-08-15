namespace HotelManagementSystem
{
    partial class admin_dashboard
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
            panel5 = new Panel();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            panel7 = new Panel();
            AvailableRooms = new Label();
            label4 = new Label();
            panel8 = new Panel();
            label6 = new Label();
            profitToday = new Label();
            panel9 = new Panel();
            totalProfit = new Label();
            label8 = new Label();
            panel6 = new Panel();
            totalStaff = new Label();
            label1 = new Label();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label2);
            panel5.Controls.Add(dataGridView1);
            panel5.Location = new Point(14, 204);
            panel5.Name = "panel5";
            panel5.Size = new Size(792, 361);
            panel5.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 9);
            label2.Name = "label2";
            label2.Size = new Size(87, 18);
            label2.TabIndex = 7;
            label2.Text = "All Rooms";
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
            dataGridView1.Location = new Point(17, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.Size = new Size(760, 307);
            dataGridView1.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(panel9);
            panel4.Controls.Add(panel6);
            panel4.Location = new Point(15, 15);
            panel4.Name = "panel4";
            panel4.Size = new Size(792, 166);
            panel4.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Teal;
            panel7.Controls.Add(AvailableRooms);
            panel7.Controls.Add(label4);
            panel7.Location = new Point(210, 20);
            panel7.Name = "panel7";
            panel7.Size = new Size(177, 126);
            panel7.TabIndex = 1;
            // 
            // AvailableRooms
            // 
            AvailableRooms.AutoSize = true;
            AvailableRooms.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AvailableRooms.ForeColor = Color.White;
            AvailableRooms.Location = new Point(42, 27);
            AvailableRooms.Name = "AvailableRooms";
            AvailableRooms.Size = new Size(21, 22);
            AvailableRooms.TabIndex = 3;
            AvailableRooms.Text = "0";
            AvailableRooms.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(7, 83);
            label4.Name = "label4";
            label4.Size = new Size(162, 22);
            label4.TabIndex = 2;
            label4.Text = "Available Rooms";
            // 
            // panel8
            // 
            panel8.BackColor = Color.Teal;
            panel8.Controls.Add(label6);
            panel8.Controls.Add(profitToday);
            panel8.Location = new Point(405, 20);
            panel8.Name = "panel8";
            panel8.Size = new Size(177, 126);
            panel8.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(13, 83);
            label6.Name = "label6";
            label6.Size = new Size(136, 22);
            label6.TabIndex = 7;
            label6.Text = "Today's Profit";
            // 
            // profitToday
            // 
            profitToday.AutoSize = true;
            profitToday.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            profitToday.ForeColor = Color.White;
            profitToday.Location = new Point(38, 27);
            profitToday.Name = "profitToday";
            profitToday.Size = new Size(49, 22);
            profitToday.TabIndex = 5;
            profitToday.Text = "$0.0";
            profitToday.TextAlign = ContentAlignment.MiddleLeft;
            profitToday.Click += label5_Click;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Teal;
            panel9.Controls.Add(totalProfit);
            panel9.Controls.Add(label8);
            panel9.Location = new Point(599, 20);
            panel9.Name = "panel9";
            panel9.Size = new Size(177, 126);
            panel9.TabIndex = 1;
            // 
            // totalProfit
            // 
            totalProfit.AutoSize = true;
            totalProfit.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalProfit.ForeColor = Color.White;
            totalProfit.Location = new Point(38, 27);
            totalProfit.Name = "totalProfit";
            totalProfit.Size = new Size(49, 22);
            totalProfit.TabIndex = 7;
            totalProfit.Text = "$0.0";
            totalProfit.TextAlign = ContentAlignment.MiddleLeft;
            totalProfit.Click += totalProfit_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(9, 83);
            label8.Name = "label8";
            label8.Size = new Size(111, 22);
            label8.TabIndex = 6;
            label8.Text = "Total Profit";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Teal;
            panel6.Controls.Add(totalStaff);
            panel6.Controls.Add(label1);
            panel6.Location = new Point(16, 20);
            panel6.Name = "panel6";
            panel6.Size = new Size(177, 126);
            panel6.TabIndex = 0;
            // 
            // totalStaff
            // 
            totalStaff.AutoSize = true;
            totalStaff.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalStaff.ForeColor = Color.White;
            totalStaff.Location = new Point(55, 27);
            totalStaff.Name = "totalStaff";
            totalStaff.Size = new Size(21, 22);
            totalStaff.TabIndex = 1;
            totalStaff.Text = "0";
            totalStaff.TextAlign = ContentAlignment.MiddleLeft;
            totalStaff.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(34, 83);
            label1.Name = "label1";
            label1.Size = new Size(104, 22);
            label1.TabIndex = 0;
            label1.Text = "Total Staff";
            // 
            // admin_dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel5);
            Controls.Add(panel4);
            Name = "admin_dashboard";
            Size = new Size(821, 580);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Panel panel4;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel6;
        private Label totalStaff;
        private Label label1;
        private Label AvailableRooms;
        private Label label4;
        private Label profitToday;
        private Label totalProfit;
        private Label label8;
        private Label label6;
        private DataGridView dataGridView1;
        private Label label2;
    }
}
