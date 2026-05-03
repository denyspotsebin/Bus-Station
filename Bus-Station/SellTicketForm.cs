using Bus_Station.Models;
using BusStationCashier.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Bus_Station
{
    public partial class SellTicketForm : Form
    {
        public Ticket CreatedTicket { get; private set; }
        private Trip _currentTrip;
        public SellTicketForm(Trip trip)
        {
            InitializeComponent();
            _currentTrip = trip;
            this.Text = $"Оформлення квитка: Рейс {_currentTrip.TripNumber} до {_currentTrip.FinalDestination}";
            this.Label.Text = $"Оформлення квитка: Рейс {_currentTrip.TripNumber} до {_currentTrip.FinalDestination}";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                MessageBox.Show("Заповніть дані пасажира!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtName.Text.Any(char.IsDigit) || txtSurname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Ім'я або прізвище не може мати цифри!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            CreatedTicket = new Ticket
            {
                PassengerName = txtName.Text,
                PassengerSurname = txtSurname.Text,
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
