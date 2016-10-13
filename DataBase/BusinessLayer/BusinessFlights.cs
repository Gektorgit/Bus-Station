using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.BusinessLayer
{
    public class BusinessFlights
    {
        public int FlightId { get; set; }
        public int CityIdStart { get; set; }
        public int CityIdEnd { get; set; }
        public int BusId { get; set; } 
        public string FlightNumber { get; set; }
        public string CityStart { get; set; }
        public string CityEnd { get; set; }
        public System.DateTime DepartureDate { get; set; }
        public System.TimeSpan DepartureTime { get; set; }
        public System.DateTime ArrivalDate { get; set; }
        public System.TimeSpan ArrivaTime { get; set; }
        public string Bus { get; set; }
        public decimal Price { get; set; }
    }
}
