using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;
using Bus_Station.Models;

namespace Bus_Station.Services
{
    public static class DataService
    {
        private const string FileName = "trips.json";

        public static void SaveTrips(List<Trip> trips)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };

            string jsonString = JsonSerializer.Serialize(trips, options);
            File.WriteAllText(FileName, jsonString);
        }

        public static List<Trip> LoadTrips()
        { 
            if (!File.Exists(FileName)) return new List<Trip>();

            string jsonString = File.ReadAllText(FileName);
            return JsonSerializer.Deserialize<List<Trip>>(jsonString) ?? new List<Trip>();
        }
    }
}
