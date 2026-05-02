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

                if (selectedTrip.HasFreeSeats)
                {
                    using (SellTicketForm sellForm = new SellTicketForm())
                    {
                        if (sellForm.ShowDialog() == DialogResult.OK)
                        {
                            Ticket newTicket = sellForm.CreatedTicket;
                            newTicket.SelectedTrip = selectedTrip; 
                            newTicket.SeatNumber = selectedTrip.Tickets.Count + 1;

                            selectedTrip.Tickets.Add(newTicket);

                            dgvTrips.Refresh();
                            DataService.SaveTrips(_trips.ToList());

                            MessageBox.Show("Квиток успішно продано!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Місць немає!");
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            DataService.SaveTrips(_trips.ToList());
            base.OnFormClosing(e);
        }

        private void btnAddTrip_Click(object sender, EventArgs e)
        {
            using (AddTripForm addForm = new AddTripForm())
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
    }
}
