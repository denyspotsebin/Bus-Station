using System;
using System.Collections.Generic;
using System.Text;

namespace Bus_Station.Models
{
    public class Station
    {
        public string Name { get; set; }
        public int MinutesFromStart { get; set; }

        public override string ToString() => Name;
    }
}
