﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AviaSalesConnection : DbContext
    {
        public AviaSalesConnection()
            : base("name=AviaSalesConnection")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Airport> Airports { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<FlightState> FlightStates { get; set; }
        public virtual DbSet<Passenger> Passengers { get; set; }
        public virtual DbSet<PlaneSeat> PlaneSeats { get; set; }
        public virtual DbSet<PlaneType> PlaneTypes { get; set; }
        public virtual DbSet<Price> Prices { get; set; }
        public virtual DbSet<Rout> Routs { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<SeatClass> SeatClasses { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<Tourist> Tourists { get; set; }
    
        public virtual ObjectResult<GetSchedule_Result> GetSchedule(Nullable<int> airportFrom_ID, Nullable<int> airportTo_ID, Nullable<System.DateTime> dateFrom, Nullable<System.DateTime> dateTo)
        {
            var airportFrom_IDParameter = airportFrom_ID.HasValue ?
                new ObjectParameter("AirportFrom_ID", airportFrom_ID) :
                new ObjectParameter("AirportFrom_ID", typeof(int));
    
            var airportTo_IDParameter = airportTo_ID.HasValue ?
                new ObjectParameter("AirportTo_ID", airportTo_ID) :
                new ObjectParameter("AirportTo_ID", typeof(int));
    
            var dateFromParameter = dateFrom.HasValue ?
                new ObjectParameter("DateFrom", dateFrom) :
                new ObjectParameter("DateFrom", typeof(System.DateTime));
    
            var dateToParameter = dateTo.HasValue ?
                new ObjectParameter("DateTo", dateTo) :
                new ObjectParameter("DateTo", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetSchedule_Result>("GetSchedule", airportFrom_IDParameter, airportTo_IDParameter, dateFromParameter, dateToParameter);
        }
    
        public virtual int BuyTicket(Nullable<long> flight_ID, Nullable<long> passanger_ID)
        {
            var flight_IDParameter = flight_ID.HasValue ?
                new ObjectParameter("Flight_ID", flight_ID) :
                new ObjectParameter("Flight_ID", typeof(long));
    
            var passanger_IDParameter = passanger_ID.HasValue ?
                new ObjectParameter("Passanger_ID", passanger_ID) :
                new ObjectParameter("Passanger_ID", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("BuyTicket", flight_IDParameter, passanger_IDParameter);
        }
    
        public virtual ObjectResult<CreatePassanger_Result> CreatePassanger(string fullName, string passport)
        {
            var fullNameParameter = fullName != null ?
                new ObjectParameter("FullName", fullName) :
                new ObjectParameter("FullName", typeof(string));
    
            var passportParameter = passport != null ?
                new ObjectParameter("Passport", passport) :
                new ObjectParameter("Passport", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CreatePassanger_Result>("CreatePassanger", fullNameParameter, passportParameter);
        }
    }
}
