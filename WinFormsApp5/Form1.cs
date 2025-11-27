using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace BookingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaveBooking_Click(object sender, EventArgs e)
        {
            string name = txtCustomerName.Text.Trim();
            string contact = txtContact.Text.Trim();
            string date = dtpDate.Value.ToShortDateString();
            string time = dtpTime.Value.ToShortTimeString();
            int guests = (int)numGuests.Value;
            string notes = txtNotes.Text.Trim();

            if (name == "" || contact == "")
            {
                MessageBox.Show("Please enter customer name and contact number.",
                                "Missing Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            string booking = $"📌 {name} ({contact})\n   {date} at {time} — Guests: {guests}\n   Notes: {notes}";
            listBookings.Items.Add(booking);

            // Reset inputs
            txtCustomerName.Text = "";
            txtContact.Text = "";
            txtNotes.Text = "";
            numGuests.Value = 1;
        }
    }
}
