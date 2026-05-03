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
            string name = txtName.Text.Trim();
            string surname = txtSurname.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname))
            {
                MessageBox.Show("Заповніть дані пасажира!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (name.Length < 2 || surname.Length < 2)
            {
                MessageBox.Show("Ім'я та прізвище повинні містити щонайменше 2 символи!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (name.Any(char.IsDigit) || surname.Any(char.IsDigit))
            {
                MessageBox.Show("Ім'я або прізвище не може містити цифри!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            CreatedTicket = new Ticket
            {
                PassengerName = name,
                PassengerSurname = surname
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
