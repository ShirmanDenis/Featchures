//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AviaSalesApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Price
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Price()
        {
            this.Tickets = new HashSet<Ticket>();
        }
    
        public long Price_ID { get; set; }
        public int Company_ID { get; set; }
        public int PlaneType_ID { get; set; }
        public long SeatClass_ID { get; set; }
        public decimal Cost { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual PlaneType PlaneType { get; set; }
        public virtual SeatClass SeatClass { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}