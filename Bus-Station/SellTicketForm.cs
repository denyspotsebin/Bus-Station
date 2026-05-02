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
    public partial class SellTicketForm : Form
    {
        public Ticket CreatedTicket { get; private set; }

        public SellTicketForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                MessageBox.Show("Заповніть дані пасажира!");
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
    }
}
