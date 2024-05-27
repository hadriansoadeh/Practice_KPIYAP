using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1.Models
{
    public class Flight
    {
        public string DestinationName {  get; set; }
        public int FlightNumber {  get; set; }
        public string DepartureTime { get; set;}

        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine($"---> Destination is {DestinationName}")
                .AppendLine($"\tFlight number is {FlightNumber}")
                .AppendLine($"\tDeparture time is {DepartureTime}")
                .ToString();
        }
    }
}
