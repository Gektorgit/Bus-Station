using DataBase.DataBaseBuses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Repositories
{
    public class BusRepository : SimpleRepository<Buses>
    {
        protected override DbSet<Buses> dbSet
        {
            get { return context.Buses; }
        }
    }

    public class CitiRepository : SimpleRepository<Cities>
    {
        protected override DbSet<Cities> dbSet
        {
            get { return context.Cities; }
        }
    }

    public class DiscountRepository : SimpleRepository<Discounts>
    {
        protected override DbSet<Discounts> dbSet
        {
            get { return context.Discounts; }
        }
    }

    public class FlightRepository : SimpleRepository<Flights>
    {
        protected override DbSet<Flights> dbSet
        {
            get { return context.Flights; }
        }
    }

    public class SeatsRepository : SimpleRepository<Seats>
    {
        protected override DbSet<Seats> dbSet
        {
            get { return context.Seats; }
        }
    }

    public class TicketRepository : SimpleRepository<Tickets>
    {
        protected override DbSet<Tickets> dbSet
        {
            get { return context.Tickets; }
        }
    }

    public class RoleRepository : SimpleRepository<Roles>
    {
        protected override System.Data.Entity.DbSet<Roles> dbSet
        {
            get { return context.Roles; }
        }
    }

    public class UserRepository : SimpleRepository<Users>
    {
        protected override System.Data.Entity.DbSet<Users> dbSet
        {
            get { return context.Users; }
        }
    }
    public class UserInRolesRepository : SimpleRepository<UserInRoles>
    {
        protected override System.Data.Entity.DbSet<UserInRoles> dbSet
        {
            get { return context.UserInRoles; }
        }
    }
}
