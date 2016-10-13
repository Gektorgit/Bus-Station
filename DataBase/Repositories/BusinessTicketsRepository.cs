using DataBase.BusinessLayer;
using DataBase.DataBaseBuses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Repositories
{
    public class BusinessTicketsRepository : IChildRepository<BusinessTickets>    
    {
        protected BusStationEntities _context;
        public virtual BusStationEntities context
        {
            get { return _context ?? (_context = new BusStationEntities()); }
        }
        public IEnumerable<BusinessTickets> GetAll()
        {
            return
                (from t in context.Tickets
                 select new BusinessTickets
                 {
                     TicketId = t.TicketId,
                     ReleaseDate = t.ReleaseDate,
                     FlightId = t.FlightId,
                     FlightNumber = t.Flights.FlightNumber,
                     CityStart = t.Flights.Cities1.CityName,
                     CityEnd = t.Flights.Cities.CityName,
                     DepartureDate = t.Flights.DepartureDate,
                     DepartureTime = t.Flights.DepartureTime,
                     ArrivalDate = t.Flights.ArrivalDate,
                     ArrivaTime = t.Flights.ArrivaTime,
                     Bus = t.Flights.Buses.BusName,
                     SeatId = t.SeatId,
                     NumberSeat = t.Seats.NumberSeat,
                     Price = t.Flights.Price,
                     DiscountId = t.DiscountId,
                     DiscountName = t.Discounts.DiscountName,
                     PriceWithDiscount = t.Flights.Price - (t.Flights.Price * t.Discounts.Size) / 100,
                     Sold = t.Sold,
                     Reserve = t.Reserve,
                     Canceled = t.Canceled
                 }
                     ).ToList();
        }

        public IEnumerable<BusinessTickets> GetAll(int DiscountId)
        {
            return
                (from t in context.Tickets
                 where t.DiscountId == DiscountId
                 select new BusinessTickets
                 {
                     TicketId = t.TicketId,
                     ReleaseDate = t.ReleaseDate,
                     FlightId = t.FlightId,
                     FlightNumber = t.Flights.FlightNumber,
                     CityStart = t.Flights.Cities1.CityName,
                     CityEnd = t.Flights.Cities.CityName,
                     DepartureDate = t.Flights.DepartureDate,
                     DepartureTime = t.Flights.DepartureTime,
                     ArrivalDate = t.Flights.ArrivalDate,
                     ArrivaTime = t.Flights.ArrivaTime,
                     Bus = t.Flights.Buses.BusName,
                     SeatId = t.SeatId,
                     NumberSeat = t.Seats.NumberSeat,
                     Price = t.Flights.Price,
                     DiscountId = t.DiscountId,
                     DiscountName = t.Discounts.DiscountName,
                     PriceWithDiscount = t.Flights.Price - (t.Flights.Price * t.Discounts.Size) / 100,
                     Sold = t.Sold,
                     Reserve = t.Reserve,
                     Canceled = t.Canceled
                 }
                     ).ToList();
        }

        public IEnumerable<BusinessTickets> GetAll(BusinessFlights bflights)
        {
            return
                (from t in context.Tickets
                 where t.FlightId == bflights.FlightId
                 select new BusinessTickets
                 {
                     TicketId = t.TicketId,
                     ReleaseDate = t.ReleaseDate,
                     FlightId = t.FlightId,
                     FlightNumber = t.Flights.FlightNumber,
                     CityStart = t.Flights.Cities1.CityName,
                     CityEnd = t.Flights.Cities.CityName,
                     DepartureDate = t.Flights.DepartureDate,
                     DepartureTime = t.Flights.DepartureTime,
                     ArrivalDate = t.Flights.ArrivalDate,
                     ArrivaTime = t.Flights.ArrivaTime,
                     Bus = t.Flights.Buses.BusName,
                     SeatId = t.SeatId,
                     NumberSeat = t.Seats.NumberSeat,
                     Price = t.Flights.Price,
                     DiscountId = t.DiscountId,
                     DiscountName = t.Discounts.DiscountName,
                     PriceWithDiscount = t.Flights.Price - (t.Flights.Price * t.Discounts.Size) / 100,
                     Sold = t.Sold,
                     Reserve = t.Reserve,
                     Canceled = t.Canceled
                 }
                     ).ToList();
        }

        public IEnumerable<BusinessTickets> GetAll(BusinessFlights bflights, int i)
        {
            string obj = context.Flights.Where(p => p.FlightId == bflights.FlightId).Select(p => p.FlightNumber).First();
            return
                (from t in context.Tickets
                 where t.Flights.FlightNumber == obj
                 select new BusinessTickets
                 {
                     TicketId = t.TicketId,
                     ReleaseDate = t.ReleaseDate,
                     FlightId = t.FlightId,
                     FlightNumber = t.Flights.FlightNumber,
                     CityStart = t.Flights.Cities1.CityName,
                     CityEnd = t.Flights.Cities.CityName,
                     DepartureDate = t.Flights.DepartureDate,
                     DepartureTime = t.Flights.DepartureTime,
                     ArrivalDate = t.Flights.ArrivalDate,
                     ArrivaTime = t.Flights.ArrivaTime,
                     Bus = t.Flights.Buses.BusName,
                     SeatId = t.SeatId,
                     NumberSeat = t.Seats.NumberSeat,
                     Price = t.Flights.Price,
                     DiscountId = t.DiscountId,
                     DiscountName = t.Discounts.DiscountName,
                     PriceWithDiscount = t.Flights.Price - (t.Flights.Price * t.Discounts.Size) / 100,
                     Sold = t.Sold,
                     Reserve = t.Reserve,
                     Canceled = t.Canceled
                 }
                     ).ToList();
        }

        public IEnumerable<BusinessTickets> GetAll(Cities city)
        {
            return
                (from t in context.Tickets
                 where t.Flights.Cities1.CityId == city.CityId || t.Flights.Cities.CityId == city.CityId
                 select new BusinessTickets
                 {
                     TicketId = t.TicketId,
                     ReleaseDate = t.ReleaseDate,
                     FlightId = t.FlightId,
                     FlightNumber = t.Flights.FlightNumber,
                     CityStart = t.Flights.Cities1.CityName,
                     CityEnd = t.Flights.Cities.CityName,
                     DepartureDate = t.Flights.DepartureDate,
                     DepartureTime = t.Flights.DepartureTime,
                     ArrivalDate = t.Flights.ArrivalDate,
                     ArrivaTime = t.Flights.ArrivaTime,
                     Bus = t.Flights.Buses.BusName,
                     SeatId = t.SeatId,
                     NumberSeat = t.Seats.NumberSeat,
                     Price = t.Flights.Price,
                     DiscountId = t.DiscountId,
                     DiscountName = t.Discounts.DiscountName,
                     PriceWithDiscount = t.Flights.Price - (t.Flights.Price * t.Discounts.Size) / 100,
                     Sold = t.Sold,
                     Reserve = t.Reserve,
                     Canceled = t.Canceled
                 }
                     ).ToList();
        }

        public IEnumerable<BusinessTickets> GetAll(Buses bus)
        {
            return
                (from t in context.Tickets
                 where t.Flights.Buses.BusId == bus.BusId
                 select new BusinessTickets
                 {
                     TicketId = t.TicketId,
                     ReleaseDate = t.ReleaseDate,
                     FlightId = t.FlightId,
                     FlightNumber = t.Flights.FlightNumber,
                     CityStart = t.Flights.Cities1.CityName,
                     CityEnd = t.Flights.Cities.CityName,
                     DepartureDate = t.Flights.DepartureDate,
                     DepartureTime = t.Flights.DepartureTime,
                     ArrivalDate = t.Flights.ArrivalDate,
                     ArrivaTime = t.Flights.ArrivaTime,
                     Bus = t.Flights.Buses.BusName,
                     SeatId = t.SeatId,
                     NumberSeat = t.Seats.NumberSeat,
                     Price = t.Flights.Price,
                     DiscountId = t.DiscountId,
                     DiscountName = t.Discounts.DiscountName,
                     PriceWithDiscount = t.Flights.Price - (t.Flights.Price * t.Discounts.Size) / 100,
                     Sold = t.Sold,
                     Reserve = t.Reserve,
                     Canceled = t.Canceled
                 }
                     ).ToList();
        }

        public IEnumerable<BusinessTickets> GetAll(DateTime NowDate)
        {
            return
                (from t in context.Tickets
                 where t.Flights.ArrivalDate < NowDate
                 select new BusinessTickets
                 {
                     TicketId = t.TicketId
                 }
                     ).ToList();
        }

        public IEnumerable<BusinessTickets> GetAll(int FlightId, int RoleId = 0)
        {
            return
                (from t in context.Tickets
                 where t.FlightId == FlightId
                 select new BusinessTickets
                 {
                     TicketId = t.TicketId
                 }
                     ).ToList();
        }

        public BusinessTickets Get(int id)
        {
            var t = context.Tickets.Find(id);
            return

                    new BusinessTickets
                    {
                        TicketId = t.TicketId,
                        ReleaseDate = t.ReleaseDate,
                        FlightId = t.Flights.FlightId,
                        FlightNumber = t.Flights.FlightNumber,
                        CityStart = t.Flights.Cities.CityName,
                        CityEnd = t.Flights.Cities1.CityName,
                        DepartureDate = t.Flights.DepartureDate,
                        DepartureTime = t.Flights.DepartureTime,
                        ArrivalDate = t.Flights.ArrivalDate,
                        ArrivaTime = t.Flights.ArrivaTime,
                        Bus = t.Flights.Buses.BusName,
                        SeatId = t.SeatId,
                        NumberSeat = t.Seats.NumberSeat,
                        Price = t.Flights.Price,
                        DiscountId = t.DiscountId,
                        DiscountName = t.Discounts.DiscountName,
                        //PriceWithDiscount = Convert.ToDecimal((t.Flights.Price * t.Discounts.Size) / 100),
                        Sold = t.Sold,
                        Reserve = t.Reserve,
                        Canceled = t.Canceled
                    };
        }

        public void Create(BusinessTickets obj)
        {
            Tickets objSave = new Tickets();
            objSave.TicketId = obj.TicketId;
            objSave.ReleaseDate = obj.ReleaseDate;
            objSave.FlightId = obj.FlightId;
            objSave.SeatId = obj.SeatId;
            objSave.DiscountId = obj.DiscountId;
            objSave.Sold = obj.Sold;
            objSave.Reserve = obj.Reserve;
            objSave.Canceled = obj.Canceled;

            context.Tickets.Attach(objSave);
            context.Tickets.Add(objSave);
            context.SaveChanges();
        }

        public void Save(BusinessTickets obj)
        {
            Tickets objSave = context.Tickets.Find(obj.TicketId);
            objSave.TicketId = obj.TicketId;
            objSave.ReleaseDate = obj.ReleaseDate;
            objSave.FlightId = obj.FlightId;
            objSave.SeatId = obj.SeatId;
            objSave.DiscountId = obj.DiscountId;
            objSave.Sold = obj.Sold;
            objSave.Reserve = obj.Reserve;
            objSave.Canceled = obj.Canceled;

            context.SaveChanges();
        }
        public void Delete(BusinessTickets obj)
        {
            Tickets objDelete = context.Tickets.Find(obj.TicketId);
            context.Tickets.Remove(objDelete);
            context.SaveChanges();
        }
    }
}
