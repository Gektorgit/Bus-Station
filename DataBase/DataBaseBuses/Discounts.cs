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
    
    public partial class Discounts
    {
        public Discounts()
        {
            this.Tickets = new HashSet<Tickets>();
        }
    
        public int DiscountId { get; set; }
        public string DiscountName { get; set; }
        public byte Size { get; set; }
        public string Information { get; set; }
    
        public virtual ICollection<Tickets> Tickets { get; set; }
    }
}