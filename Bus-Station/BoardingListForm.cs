using Bus_Station.Models;
using BusStationCashier.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bus_Station
{
    public partial class BoardingListForm : Form
    {
        public bool HasChanges { get; private set; } = false;
        private Trip _currentTrip;

        public BoardingListForm(Trip trip)
        {
            InitializeComponent();
            _currentTrip = trip;
            this.Text = $"Посадкова відомість: Рейс {_currentTrip.TripNumber} до {_currentTrip.FinalDestination}";

            UpdateTicketList();
        }

        private void UpdateTicketList()
        {
            lbTickets.Items.Clear();

            if (_currentTrip.Tickets.Count == 0)
            {
                lbTickets.Items.Add("На цей рейс ще не продано жодного квитка.");
                return;
            }

            foreach (var ticket in _currentTrip.Tickets)
            {
                string ticketInfo = $"Місце {ticket.SeatNumber}: {ticket.PassengerSurname} {ticket.PassengerName}";
                lbTickets.Items.Add(ticketInfo);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReturnTicket_Click(object sender, EventArgs e)
        {
            if (_currentTrip.DepartureTime <= DateTime.Now)
            {
                MessageBox.Show("Цей рейс вже відправився! Повернення квитків неможливе.",
                                "Відмова операції",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (lbTickets.SelectedIndex != -1 && _currentTrip.Tickets.Count > 0)
            {
                int index = lbTickets.SelectedIndex;
                Ticket ticketToRemove = _currentTrip.Tickets[index];

                var confirmResult = MessageBox.Show(
                    $"Ви впевнені, що хочете повернути квиток пасажира {ticketToRemove.PassengerSurname}?",
                    "Підтвердження повернення",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    _currentTrip.Tickets.RemoveAt(index);
                    UpdateTicketList();
                    HasChanges = true;
                }
            }
            else
            {
                MessageBox.Show("Оберіть квиток для повернення!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
