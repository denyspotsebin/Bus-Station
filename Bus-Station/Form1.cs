using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Bus_Station.Models;
using Bus_Station.Services;

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
            var lodedTrips = DataService.LoadTrips();
            _trips = new BindingList<Trip>(lodedTrips);

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

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            DataService.SaveTrips(_trips.ToList());
            base.OnFormClosing(e);
        }

    }
}
