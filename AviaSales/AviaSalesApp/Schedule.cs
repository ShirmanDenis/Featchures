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
    
    public partial class Schedule
    {
        public long Schedule_ID { get; set; }
        public long Flight_ID { get; set; }
        public int Company_ID { get; set; }
        public int PlaneType_ID { get; set; }
        public System.TimeSpan Delay { get; set; }
        public System.DateTime DepartureDate { get; set; }
        public System.DateTime ArrivalDate { get; set; }
        public int Rout_ID { get; set; }
        public int State_ID { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual Flight Flight { get; set; }
        public virtual FlightState FlightState { get; set; }
        public virtual PlaneType PlaneType { get; set; }
        public virtual Rout Rout { get; set; }
    }
}
