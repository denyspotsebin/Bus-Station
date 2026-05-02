using Bus_Station.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusStationCashier.Models
{
    public class Ticket
    {
        public string PassengerName { get; set; }
        public string PassengerSurname { get; set; }
        public int SeatNumber { get; set; }
        public decimal Price { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public Trip SelectedTrip { get; set; }
    }
}
