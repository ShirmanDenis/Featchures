using System;
using System.Data.Entity;
using System.Linq;
using System.Text;
using AviaSalesApp.Common;
using NLog;

namespace AviaSalesApp.Controllers
{
    public class BuyTicketController
    {
        private Logger _logger = LogManager.GetCurrentClassLogger();
        private IBuyTicketView _view;
        private AviaSalesConnectionProvider _provider;

        public BuyTicketController(AviaSalesConnectionProvider provider, IBuyTicketView view)
        {
            _view = view;
            _provider = provider;
        }

        private CreatePassanger_Result GetPassenger(string fullName, string passport)
        {
            return _provider.AviaSalesConnection.CreatePassanger(fullName, passport).FirstOrDefault();
        }

        public void BuyTicket(Flight flight, string fullName, string passport)
        {
            try
            {
                var passanger = GetPassenger(fullName, passport);

                if (passanger == null) return;

                _provider.AviaSalesConnection.BuyTicket(flight.Flight_ID, passanger.Passenger_ID);
            }
            catch (Exception e)
            {
                _logger.ConditionalDebug(e, e.InnerException?.Message ?? "Inner is empty");
                throw new Exception(e.InnerException?.Message ?? e.Message);
            }
        }
    }
}