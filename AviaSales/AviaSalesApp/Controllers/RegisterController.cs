using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviaSalesApp.Common;
using NLog;

namespace AviaSalesApp.Controllers
{
    public class RegisterController
    {
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();
        private readonly AviaSalesConnectionProvider _provider;
        private readonly IRegisterView _view;

        public RegisterController(AviaSalesConnectionProvider provider, IRegisterView view)
        {
            _provider = provider;
            _view = view;
        }

        public void Save()
        {
            try
            {
                _provider.AviaSalesConnection.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.Debug(e.InnerException?.Message ?? e.Message);
                throw e.InnerException ?? e;
            }

        }

        public Ticket FindTicket(long ticketId)
        {
            try
            {
                var ticket = _provider.AviaSalesConnection.Tickets.Find(ticketId);
                return ticket;
            }
            catch (Exception e)
            {
                _logger.Debug(e.InnerException ?? e);
                return null;
            }
        }

        public List<PlaneSeat> FindPlaneSeats(int planeTypeId, long seatClassId)
        {
            try
            {
                _provider.AviaSalesConnection.PlaneSeats.Load();
                var result = _provider
                    .AviaSalesConnection
                    .PlaneSeats
                    .Local
                    .Where(s => s.PlaneType_ID == planeTypeId && s.SeatClass_ID == seatClassId).ToList();
                return result;
            }
            catch (Exception e)
            {
                _logger.Debug(e.InnerException ?? e);
                throw e.InnerException ?? e;
            }
        }
    }
}
