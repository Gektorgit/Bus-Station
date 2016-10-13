using DataBase.BusinessLayer;
using DataBase.DataBaseBuses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Repositories
{
    public class BusinessFlightsRepository : IChildRepository<BusinessFlights>    
    {
        protected BusStationEntities _context;
        public virtual BusStationEntities context
        {
            get { return _context ?? (_context = new BusStationEntities()); }
        }

        public IEnumerable<BusinessFlights> GetAll()
        {
            return
                (from p in context.Flights
                 select new BusinessFlights
                 {
                     FlightId = p.FlightId,
                     FlightNumber = p.FlightNumber,
                     CityIdStart = p.CityIdStart,
                     CityIdEnd = p.CityIdEnd,
                     BusId = p.BusId,
                     CityStart = p.Cities1.CityName,
                     CityEnd = p.Cities.CityName,
                     DepartureDate = p.DepartureDate,
                     DepartureTime = p.DepartureTime,
                     ArrivalDate = p.ArrivalDate,
                     ArrivaTime = p.ArrivaTime,
                     Bus = p.Buses.BusName,
                     Price = p.Price
                 }
                     ).ToList();
        }

        public IEnumerable<BusinessFlights> GetAll(int parentId, int parId)
        {
            return
                (from p in context.Flights
                 where p.CityIdStart == parentId
                 select new BusinessFlights
                 {
                     FlightId = p.FlightId,
                     FlightNumber = p.FlightNumber,
                     CityIdStart = p.CityIdStart,
                     CityIdEnd = p.CityIdEnd,
                     BusId = p.BusId,
                     CityStart = p.Cities1.CityName,
                     CityEnd = p.Cities.CityName,
                     DepartureDate = p.DepartureDate,
                     DepartureTime = p.DepartureTime,
                     ArrivalDate = p.ArrivalDate,
                     ArrivaTime = p.ArrivaTime,
                     Bus = p.Buses.BusName,
                     Price = p.Price
                 }
                     ).ToList();
        }

        public IEnumerable<BusinessFlights> GetAll(Cities city)
        {
            return
                (from p in context.Flights
                 where p.Cities1.CityId == city.CityId || p.Cities.CityId == city.CityId
                 select new BusinessFlights
                 {
                     FlightId = p.FlightId,
                     FlightNumber = p.FlightNumber,
                     CityIdStart = p.CityIdStart,
                     CityIdEnd = p.CityIdEnd,
                     BusId = p.BusId,
                     CityStart = p.Cities1.CityName,
                     CityEnd = p.Cities.CityName,
                     DepartureDate = p.DepartureDate,
                     DepartureTime = p.DepartureTime,
                     ArrivalDate = p.ArrivalDate,
                     ArrivaTime = p.ArrivaTime,
                     Bus = p.Buses.BusName,
                     Price = p.Price
                 }
                     ).ToList();
        }

        public IEnumerable<BusinessFlights> GetAll(Buses bus)
        {
            return
                (from p in context.Flights
                 where p.Buses.BusId == bus.BusId
                 select new BusinessFlights
                 {
                     FlightId = p.FlightId,
                     FlightNumber = p.FlightNumber,
                     CityIdStart = p.CityIdStart,
                     CityIdEnd = p.CityIdEnd,
                     BusId = p.BusId,
                     CityStart = p.Cities1.CityName,
                     CityEnd = p.Cities.CityName,
                     DepartureDate = p.DepartureDate,
                     DepartureTime = p.DepartureTime,
                     ArrivalDate = p.ArrivalDate,
                     ArrivaTime = p.ArrivaTime,
                     Bus = p.Buses.BusName,
                     Price = p.Price
                 }
                     ).ToList();
        }

        public IEnumerable<BusinessFlights> GetAll(DateTime dt)
        {
            return
                (from p in context.Flights
                 where p.DepartureDate >= dt
                 select new BusinessFlights
                 {
                     FlightId = p.FlightId,
                     FlightNumber = p.FlightNumber,
                     CityIdStart = p.CityIdStart,
                     CityIdEnd = p.CityIdEnd,
                     BusId = p.BusId,
                     CityStart = p.Cities1.CityName,
                     CityEnd = p.Cities.CityName,
                     DepartureDate = p.DepartureDate,
                     DepartureTime = p.DepartureTime,
                     ArrivalDate = p.ArrivalDate,
                     ArrivaTime = p.ArrivaTime,
                     Bus = p.Buses.BusName,
                     Price = p.Price
                 }
                     ).ToList();
        }

        public IEnumerable<BusinessFlights> GetAll(string CityNameStart, string CityNameEnd, DateTime dt)
        {
            return
                (from p in context.Flights
                 where p.Cities1.CityName == CityNameStart && p.Cities.CityName == CityNameEnd && p.DepartureDate == dt
                 select new BusinessFlights
                 {
                     FlightId = p.FlightId,
                     FlightNumber = p.FlightNumber,
                     CityIdStart = p.CityIdStart,
                     CityIdEnd = p.CityIdEnd,
                     BusId = p.BusId,
                     CityStart = p.Cities1.CityName,
                     CityEnd = p.Cities.CityName,
                     DepartureDate = p.DepartureDate,
                     DepartureTime = p.DepartureTime,
                     ArrivalDate = p.ArrivalDate,
                     ArrivaTime = p.ArrivaTime,
                     Bus = p.Buses.BusName,
                     Price = p.Price
                 }
                     ).ToList();
        }

        public BusinessFlights Get(int id)
        {
            var p = context.Flights.Find(id);
            return

                    new BusinessFlights
                    {
                        FlightId = p.FlightId,
                        FlightNumber = p.FlightNumber,
                        CityIdStart = p.CityIdStart,
                        CityIdEnd = p.CityIdEnd,
                        BusId = p.BusId,
                        CityStart = p.Cities1.CityName,
                        CityEnd = p.Cities.CityName,
                        DepartureDate = p.DepartureDate,
                        DepartureTime = p.DepartureTime,
                        ArrivalDate = p.ArrivalDate,
                        ArrivaTime = p.ArrivaTime,
                        Bus = p.Buses.BusName,
                        Price = p.Price
                    };
        }
        public void Create(BusinessFlights obj)
        {
            Flights objSave = new Flights();
            objSave.FlightId = obj.FlightId;
            objSave.FlightNumber = obj.FlightNumber;
            objSave.CityIdStart = obj.CityIdStart;
            objSave.CityIdEnd = obj.CityIdEnd;
            objSave.DepartureDate = obj.DepartureDate;
            objSave.DepartureTime = obj.DepartureTime;
            objSave.ArrivalDate = obj.ArrivalDate;
            objSave.ArrivaTime = obj.ArrivaTime;
            objSave.BusId = obj.BusId;
            objSave.Price = obj.Price;

            context.Flights.Attach(objSave);
            context.Flights.Add(objSave);
            context.SaveChanges();
        }

        public void Delete(BusinessFlights obj)
        {
            Flights objDelete = context.Flights.Find(obj.FlightId);
            context.Flights.Remove(objDelete);
            context.SaveChanges();
        }

        public void Save(BusinessFlights obj)
        {
            Flights objSave = context.Flights.Find(obj.FlightId);
            objSave.FlightId = obj.FlightId;
            objSave.FlightNumber = obj.FlightNumber;
            objSave.CityIdStart = obj.CityIdStart;
            objSave.CityIdEnd = obj.CityIdEnd;
            objSave.DepartureDate = obj.DepartureDate;
            objSave.DepartureTime = obj.DepartureTime;
            objSave.ArrivalDate = obj.ArrivalDate;
            objSave.ArrivaTime = obj.ArrivaTime;
            objSave.BusId = obj.BusId;
            objSave.Price = obj.Price;

            context.SaveChanges();
        }
    }
}
