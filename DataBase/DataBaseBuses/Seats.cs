//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Seats
    {
        public Seats()
        {
            this.Tickets = new HashSet<Tickets>();
        }
    
        public int SeatId { get; set; }
        public int BusId { get; set; }
        public int NumberSeat { get; set; }
    
        public virtual Buses Buses { get; set; }
        public virtual ICollection<Tickets> Tickets { get; set; }
    }
}
