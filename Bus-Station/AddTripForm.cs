using Bus_Station.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bus_Station
{
    public partial class AddTripForm : Form
    {

        public Trip NewTrip { get; private set; }

        public AddTripForm()
        {
            InitializeComponent();
        }

        private void AddTripForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDestination.Text))
            {
                MessageBox.Show("Введіть пункт призначення!");
                return;
            }

            NewTrip = new Trip
            {
                TripNumber = txtNumber.Text,
                FinalDestination = txtDestination.Text,
                DepartureTime = dtpDeparture.Value,
                TotalSeats = (int)numTotalSeats.Value,
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
