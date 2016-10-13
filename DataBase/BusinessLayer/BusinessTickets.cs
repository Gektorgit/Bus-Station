using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.BusinessLayer
{
    public class BusinessTickets
    {
        public int TicketId { get; set; }
        public System.DateTime ReleaseDate { get; set; }
        public int FlightId { get; set; }
        public string FlightNumber { get; set; }
        public string CityStart { get; set; }
        public string CityEnd { get; set; }
        public System.DateTime DepartureDate { get; set; }
        public System.TimeSpan DepartureTime { get; set; }
        public System.DateTime ArrivalDate { get; set; }
        public System.TimeSpan ArrivaTime { get; set; }
        public string Bus { get; set; }
        public int SeatId { get; set; }
        public int NumberSeat { get; set; }
        public decimal Price { get; set; }
        public int DiscountId { get; set; }
        public string DiscountName { get; set; }
        public decimal PriceWithDiscount { get; set; }
        public Nullable<bool> Sold { get; set; }
        public Nullable<bool> Reserve { get; set; }
        public Nullable<bool> Canceled { get; set; }
    }
}
