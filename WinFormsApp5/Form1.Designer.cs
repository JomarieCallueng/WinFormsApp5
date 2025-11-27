namespace BookingApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.lblGuests = new System.Windows.Forms.Label();
            this.numGuests = new System.Windows.Forms.NumericUpDown();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnSaveBooking = new System.Windows.Forms.Button();
            this.listBookings = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerName
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(20, 20);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(91, 15);
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // txtCustomerName
            this.txtCustomerName.Location = new System.Drawing.Point(140, 17);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(250, 23);
            // 
            // lblContact
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(20, 60);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(93, 15);
            this.lblContact.Text = "Contact Number:";
            // 
            // txtContact
            this.txtContact.Location = new System.Drawing.Point(140, 57);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(200, 23);
            // 
            // lblDate
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(20, 100);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(73, 15);
            this.lblDate.Text = "Booking Date:";
            // 
            // dtpDate
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(140, 97);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(150, 23);
            // 
            // lblTime
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(20, 140);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(76, 15);
            this.lblTime.Text = "Booking Time:";
            // 
            // dtpTime
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Location = new System.Drawing.Point(140, 137);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(100, 23);
            // 
            // lblGuests
            this.lblGuests.AutoSize = true;
            this.lblGuests.Location = new System.Drawing.Point(20, 180);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(103, 15);
            this.lblGuests.Text = "Number of Guests:";
            // 
            // numGuests
            this.numGuests.Location = new System.Drawing.Point(140, 177);
            this.numGuests.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numGuests.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            this.numGuests.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.numGuests.Name = "numGuests";
            this.numGuests.Size = new System.Drawing.Size(60, 23);
            // 
            // lblNotes
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(20, 220);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(40, 15);
            this.lblNotes.Text = "Notes:";
            // 
            // txtNotes
            this.txtNotes.Location = new System.Drawing.Point(140, 217);
            this.txtNotes.Multiline = true;
            this.txtNotes.Size = new System.Drawing.Size(250, 80);
            this.txtNotes.Name = "txtNotes";
            // 
            // btnSaveBooking
            this.btnSaveBooking.Location = new System.Drawing.Point(140, 310);
            this.btnSaveBooking.Name = "btnSaveBooking";
            this.btnSaveBooking.Size = new System.Drawing.Size(150, 30);
            this.btnSaveBooking.Text = "Save Booking";
            this.btnSaveBooking.Click += new System.EventHandler(this.btnSaveBooking_Click);
            // 
            // listBookings
            this.listBookings.Location = new System.Drawing.Point(20, 360);
            this.listBookings.Size = new System.Drawing.Size(450, 200);
            this.listBookings.Name = "listBookings";
            // 
            // Form1
            this.ClientSize = new System.Drawing.Size(500, 580);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.lblGuests);
            this.Controls.Add(this.numGuests);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.btnSaveBooking);
            this.Controls.Add(this.listBookings);
            this.Name = "Form1";
            this.Text = "Booking & Reservation";
            ((System.ComponentModel.ISupportInitialize)(this.numGuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label lblGuests;
        private System.Windows.Forms.NumericUpDown numGuests;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnSaveBooking;
        private System.Windows.Forms.ListBox listBookings;
    }
}
