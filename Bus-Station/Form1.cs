using Bus_Station.Models;
using Bus_Station.Services;
using BusStationCashier.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Bus_Station
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private BindingList<Trip> _trips;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            var loadedTrips = DataService.LoadTrips();
            _trips = new BindingList<Trip>(loadedTrips);

            dgvTrips.AutoGenerateColumns = true;
            dgvTrips.DataSource = _trips;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.ToLower();

            var filtered = _trips.Where(t =>
                t.FinalDestination.ToLower().Contains(query) ||
                t.IntermediateStations.Any(s => s.Name.ToLower().Contains(query))
                ).ToList();

            if (filtered.Count == 0)
            {
                MessageBox.Show("На жаль, рейсів за таким напрямком не знайдено.",
                        "Результат пошуку",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                txtSearch.Clear();
                return;
            }
            dgvTrips.DataSource = new BindingList<Trip>(filtered);

        }

        private void dgvTrips_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSellTicket_Click(object sender, EventArgs e)
        {



            if (dgvTrips.CurrentRow != null)    
            {
                Trip selectedTrip = (Trip)dgvTrips.CurrentRow.DataBoundItem;

                if (selectedTrip.DepartureTime <= DateTime.Now)
                {
                    MessageBox.Show("Рейс вже відправився! Продаж закритий.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (selectedTrip.HasFreeSeats)
                {
                    using (SellTicketForm sellForm = new SellTicketForm(selectedTrip))
                    {
                        if (sellForm.ShowDialog() == DialogResult.OK)
                        {
                            int assignedSeat = 1;
                            for (int i = 1; i <= selectedTrip.TotalSeats; i++)
                            {
                                if (!selectedTrip.Tickets.Any(t => t.SeatNumber == i))
                                {
                                    assignedSeat = i;
                                    break;
                                }
                            }
                            Ticket newTicket = sellForm.CreatedTicket;
                            newTicket.SelectedTrip = selectedTrip;
                            newTicket.SeatNumber = assignedSeat;

                            selectedTrip.Tickets.Add(newTicket);

                            dgvTrips.Refresh();
                            DataService.SaveTrips(_trips.ToList());

                            MessageBox.Show("Квиток успішно продано!", "Результат операції", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Місць немає!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть рейс зі списку.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            DataService.SaveTrips(_trips.ToList());
            base.OnFormClosing(e);
        }

        private void btnAddTrip_Click(object sender, EventArgs e)
        {
            using (AddTripForm addForm = new AddTripForm(_trips.ToList()))
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    _trips.Add(addForm.NewTrip);
                    DataService.SaveTrips(_trips.ToList());
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBoardingList_Click(object sender, EventArgs e)
        {
            if (dgvTrips.CurrentRow != null)
            {
                Trip selectedTrip = (Trip)dgvTrips.CurrentRow.DataBoundItem;

                using (BoardingListForm boardingForm = new BoardingListForm(selectedTrip))
                {
                    boardingForm.ShowDialog();

                    if (boardingForm.HasChanges)
                    {
                        dgvTrips.Refresh();
                        DataService.SaveTrips(_trips.ToList());
                    }
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть рейс зі списку.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}
