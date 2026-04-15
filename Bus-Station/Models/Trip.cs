using System;
using System.Collections.Generic;
using System.Text;

namespace Bus_Station.Models
{
    public class Trip
    {

        public string TripNumber { get; set; }
        public string FinalDestination { get; set; }
        public DateTime DepartureTime { get; set; }
        public int TotalSeats { get; set; }
        public int SoldSeats { get; set; }

        public List<Station> IntermediateStations { get; set; } = new List<Station>();

        public int FreeSeats => TotalSeats - SoldSeats;
        public bool HasFreeSeats => FreeSeats > 0;
    }
}
