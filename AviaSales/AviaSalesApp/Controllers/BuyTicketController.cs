using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using AviaSalesApp.Common;
using NLog;

namespace AviaSalesApp.Controllers
{
    public class BuyTicketController
    {
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();
        private readonly IBuyTicketView _view;
        private readonly AviaSalesConnectionProvider _provider;

        public BuyTicketController(AviaSalesConnectionProvider provider, IBuyTicketView view)
        {
            _view = view;
            _provider = provider;
        }

        private CreatePassanger_Result GetPassenger(string fullName, string passport)
        {
            return _provider.AviaSalesConnection.CreatePassanger(fullName, passport).FirstOrDefault();
        }

        public long BuyTicket(Flight flight, string fullName, string passport, long priceId)
        {
            try
            {
                var passanger = GetPassenger(fullName, passport);

                if (passanger == null) return -1;

                _provider.AviaSalesConnection.BuyTicket(flight.Flight_ID, passanger.Passenger_ID, priceId);
                _provider.AviaSalesConnection.Tickets.Load();
                return _provider.AviaSalesConnection.Tickets.Local.First(t =>
                    t.Flight_ID == flight.Flight_ID && t.Passanger_ID == passanger.Passenger_ID).Ticket_ID;
            }
            catch (Exception e)
            {
                _logger.Debug(e, e.InnerException?.Message ?? "Inner is empty");
                throw new Exception(e.InnerException?.Message ?? e.Message);
            }
        }

        public List<SeatClass> GetSeatClasses(string planeType)
        {
            _provider.AviaSalesConnection.SeatClasses.Load();
            var planeTypeId = _provider.AviaSalesConnection.PlaneTypes.FirstOrDefault(p => p.PlaneTypeName == planeType)?.PlaneType_ID;

            return _provider
                .AviaSalesConnection
                .SeatClasses
                .Local
                .Where(sc => sc.PlaneSeats.Any(s => s.PlaneType_ID == planeTypeId))
                .ToList();
        }

        public GetPrice_Result GetPrice(string company, string seatClass, string planeType)
        {
            var companyId = _provider.AviaSalesConnection.Companies.FirstOrDefault(c => c.CompanyName == company);
            var seatClassId = _provider.AviaSalesConnection.SeatClasses.FirstOrDefault(sc => sc.SeatClassName == seatClass);
            var planeTypeId = _provider.AviaSalesConnection.PlaneTypes.FirstOrDefault(p => p.PlaneTypeName == planeType);

            return _provider.AviaSalesConnection.GetPrice(companyId?.Company_ID, planeTypeId?.PlaneType_ID, seatClassId?.SeatClass_ID).First();
        }
    }
}