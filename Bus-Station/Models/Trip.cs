using BusStationCashier.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Bus_Station.Models
{
    public class Trip
    {
        [DisplayName("Номер рейсу")]
        public string TripNumber { get; set; }

        [DisplayName("Пункт призначення")]
        public string FinalDestination { get; set; }

        [DisplayName("Час відправлення")]
        public DateTime DepartureTime { get; set; }

        [DisplayName("Усього місць")]
        public int TotalSeats { get; set; }

        [Browsable(false)]
        public List<Station> IntermediateStations { get; set; } = new List<Station>();

        [DisplayName("Проміжні зупинки")]
        public string StationsListString
        {
            get
            {
                if (IntermediateStations == null || IntermediateStations.Count == 0)
                    return "-";

                var stationNames = IntermediateStations.Select(s => s.Name);
                return string.Join(", ", stationNames);
            }
        }

        [Browsable(false)]
        public List<Ticket> Tickets { get; set; } = new List<Ticket>();

        [System.Text.Json.Serialization.JsonIgnore]
        [DisplayName("Продано квитків")]
        public int SoldSeats => Tickets.Count;

        [DisplayName("Вільні місця")]
        public int FreeSeats => TotalSeats - SoldSeats;

        [Browsable(false)]
        public bool HasFreeSeats => FreeSeats > 0;

        


    }
}
