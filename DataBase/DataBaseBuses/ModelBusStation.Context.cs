﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBase.DataBaseBuses
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BusStationEntities : DbContext
    {
        public BusStationEntities()
            : base("name=BusStationEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Buses> Buses { get; set; }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<Discounts> Discounts { get; set; }
        public DbSet<Flights> Flights { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Seats> Seats { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<UserInRoles> UserInRoles { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
