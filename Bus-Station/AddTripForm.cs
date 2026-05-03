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

        private BindingList<Station> _tempStations = new BindingList<Station>();

        private List<Trip> _existingTrips;

        public AddTripForm(List<Trip> existingTrips)
        {
            InitializeComponent();
            _existingTrips = existingTrips;

            lbStations.DataSource = _tempStations;
            lbStations.DisplayMember = "Name";
        }

        private void AddTripForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumber.Text))
            {
                MessageBox.Show("Ведіть номер рейсу!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDestination.Text))
            {
                MessageBox.Show("Введіть пункт призначення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpDeparture.Value <= DateTime.Now)
            {
                MessageBox.Show("Час не може бути вказаний в минулому!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (numTotalSeats.Value <= 0)
            {
                MessageBox.Show("Кількість місць не може бути менишим, або рівним нулю!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool tripExists = _existingTrips.Any(t => t.TripNumber.Equals(txtNumber.Text, StringComparison.OrdinalIgnoreCase));
            if (tripExists)
            {
                MessageBox.Show("Рейс з таким номером вже існує в системі!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NewTrip = new Trip
            {
                TripNumber = txtNumber.Text,
                FinalDestination = txtDestination.Text,
                DepartureTime = dtpDeparture.Value,
                TotalSeats = (int)numTotalSeats.Value,
                IntermediateStations = _tempStations.ToList()
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lbStations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddStation_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtStationName.Text))
            {
                if (string.IsNullOrWhiteSpace(txtDestination.Text))
                {
                    MessageBox.Show("Спочатку введіть пунт призначння!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtDestination.Text.ToLower() == txtStationName.Text.ToLower())
                {
                    MessageBox.Show("Назва зупинки не може збігатися з місцем призначення!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _tempStations.Add(new Station
                {
                    Name = txtStationName.Text,
                    MinutesFromStart = 0
                });

                txtStationName.Clear();
                txtStationName.Focus();
            }
            else
            {
                MessageBox.Show("Введіть місце зупинки!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnRemoveStation_Click(object sender, EventArgs e)
        {
            if (lbStations.SelectedItem != null)
            {
                _tempStations.Remove((Station)lbStations.SelectedItem);
            }
        }
    }
}
