using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelManagementSystem
{
    public partial class clientInfo : Form
    {
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aeren\OneDrive\Belgeler\hotel.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public clientInfo()
        {
            InitializeComponent();

            displayBookID();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void displayBookID()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                int getBookID = 0;

                string selectBID = "SELECT COUNT(id) FROM customer";

                using (SqlCommand cmd = new SqlCommand(selectBID, connect))
                {
                    getBookID = Convert.ToInt32(cmd.ExecuteScalar());

                    getBookID += 1;
                }

                client_bookID.Text = $"BID-{getBookID}";
            }
        }

        private void client_bookButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to book now?", "Confirmation Message", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (client_fullName.Text == "" || client_gender.SelectedIndex == -1 || client_address.Text == ""
                || client_email.Text == "" || client_contact.Text == "" || hotelData.roomID == "")
                {
                    MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();

                        string insertData = "INSERT INTO customer " +
                            "(book_id, full_name, email, contact, gender, address, room_id, price, status_payment, status" +
                            ", date_from, date_to, date_book) " +
                            "VALUES(@bookID, @fullname, @email, @contact, @gender, @address, @roomID, @price, @statusP" +
                            ", @status, @dateFrom, @dateTo, @dateBook)";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@bookID", client_bookID.Text);
                            cmd.Parameters.AddWithValue("@fullname", client_fullName.Text);
                            cmd.Parameters.AddWithValue("@email", client_email.Text);
                            cmd.Parameters.AddWithValue("@contact", client_contact.Text);
                            cmd.Parameters.AddWithValue("@gender", client_gender.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@address", client_address.Text);
                            cmd.Parameters.AddWithValue("@roomID", hotelData.roomID);
                            if (decimal.TryParse(hotelData.price, out decimal price))
                            {
                                cmd.Parameters.AddWithValue("@price", price);
                            }
                            else
                            {
                                MessageBox.Show("Invalid price format.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            cmd.Parameters.AddWithValue("@statusP", "Paid");
                            cmd.Parameters.AddWithValue("@status", "Checked In");
                            cmd.Parameters.AddWithValue("@dateFrom", hotelData.fromDate);
                            cmd.Parameters.AddWithValue("@dateTo", hotelData.toDate);

                            DateTime today = DateTime.Today;
                            cmd.Parameters.AddWithValue("@dateBook", today);

                            cmd.ExecuteNonQuery();

                            updateRoomStatus();

                            MessageBox.Show("Booked successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();
                        }
                    }
                }
            }
        }

        public void updateRoomStatus()
        {
            using(SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();

                string updateStatus = "UPDATE rooms SET status = @status WHERE room_id = @roomID";

                using(SqlCommand cmd = new SqlCommand(updateStatus, connect))
                {
                    cmd.Parameters.AddWithValue("@status", "Unavailable");
                    cmd.Parameters.AddWithValue("@roomID", hotelData.roomID);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void client_clearButton_Click(object sender, EventArgs e)
        {
            client_fullName.Text = "";
            client_email.Text = "";
            client_contact.Text = "";
            client_gender.SelectedIndex = -1;
            client_address.Text = "";
        }
    }
}
