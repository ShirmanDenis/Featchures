using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using AviaSalesApp.Common;
using NLog;
using AppContext = AviaSalesApp.Common.AppContext;

namespace AviaSalesApp.Controllers
{
    public class ScheduleController
    {
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();
        private readonly AviaSalesConnectionProvider _provider;
        private IScheduleView _view;

        public ScheduleController(AviaSalesConnectionProvider provider, IScheduleView scheduleView)
        {
            _provider = provider;
            _view = scheduleView;
            _provider.AviaSalesConnection.Schedules.Load();
        }

        public List<GetSchedule_Result> GetSchedule(GeoPath from, GeoPath to, DateTime dateFrom, DateTime dateTo)
        {
            if (from == null) throw new ArgumentNullException(nameof(from));
            if (to == null) throw new ArgumentNullException(nameof(to));
            if (dateFrom == null) throw new ArgumentNullException(nameof(dateFrom));
            if (dateTo == null) throw new ArgumentNullException(nameof(dateTo));
            try
            {
                _provider.AviaSalesConnection.Airports.Load();

                var airportFromId =
                    _provider
                        .AviaSalesConnection
                        .Airports
                        .Local.Where(airport => airport.AirportName == from.Airport &&
                                                airport.City.CityName == from.City).Select(i => i.Airport_ID)
                        .FirstOrDefault();

                var airportToId = _provider
                    .AviaSalesConnection
                    .Airports
                    .Local.Where(airport => airport.AirportName == to.Airport &&
                                            airport.City.CityName == to.City).Select(i => i.Airport_ID)
                    .FirstOrDefault();

                return _provider.AviaSalesConnection.GetSchedule(airportFromId, airportToId, dateFrom, dateTo).ToList();
            }
            catch (Exception ex)
            {
                _logger.Debug(ex.InnerException ?? ex);
                throw ex.InnerException ?? ex;
            }
        }

        public List<GeoPath> GetAirplanesPath()
        {
            var resultPaths = new List<GeoPath>();
            _provider.AviaSalesConnection.Airports.Load();
            var localAirports = _provider.AviaSalesConnection.Airports.Local;
            try
            {
                foreach (var airport in localAirports)
                {
                    _provider.AviaSalesConnection.Countries.Load();
                    var country = _provider
                        .AviaSalesConnection
                        .Countries
                        .Local
                        .FirstOrDefault(c => c.Cities.Contains(airport.City));

                    Debug.Assert(country != null);

                    resultPaths.Add(
                        new GeoPath(airport.AirportName,
                            airport.City.CityName,
                            country.CountryName)
                    );
                }
                return resultPaths;
            }
            catch (Exception ex)
            {
                _logger.ConditionalDebug(ex.InnerException ?? ex);
                throw ex.InnerException ?? ex;
            }
        }

        public Flight FindFlightBuyName(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name));

            _provider.AviaSalesConnection.Flights.Load();

            return _provider.AviaSalesConnection.Flights.Local.First(f => f.FlightName == name);
        }

        public void BuyTicket(GetSchedule_Result scheduleResult)
        {
            var buyTicketForm = _view.Factory.CreateBuyTicketView(_provider, _view);
            buyTicketForm.SetFlightInfo(FindFlightBuyName(scheduleResult.FlightName), scheduleResult, _view.PathFrom, _view.PathTo);
            buyTicketForm.Show();
        }
    }
}