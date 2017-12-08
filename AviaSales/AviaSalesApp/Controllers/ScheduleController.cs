using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using AviaSalesApp.Common;
using AppContext = AviaSalesApp.Common.AppContext;

namespace AviaSalesApp.Controllers
{
    public class ScheduleController
    {
        private readonly AviaSalesConnectionProvider _provider;
        private IScheduleView _view;

        public ScheduleController(AviaSalesConnectionProvider provider, IScheduleView scheduleView)
        {
            _provider = provider;
            _view = scheduleView;
            _provider.AviaSalesConnection.Schedules.Load();
            _provider.AviaSalesConnection.ScheduleViews.Load();
        }

        public BindingList<ScheduleView> GetSchedule()
        {
            return _provider.AviaSalesConnection.ScheduleViews.Local.ToBindingList();
        }

        public List<Schedule> GetSchedule(GeoPath from, GeoPath to, DateTime dateFrom, DateTime dateTo)
        {
            var localCollection = _provider
                .AviaSalesConnection
                .Schedules
                .Local.Where(schedule =>
                                schedule.Flight.FlightDate.Between(dateFrom, dateTo) &&
                                schedule.Rout.AirportFrom.AirportName == from.Airport &&
                                schedule.Rout.AirportTo.AirportName == to.Airport
                            ).ToList();

            return localCollection;
        }

        public List<GeoPath> GetAirplanesPath()
        {
            var resultPaths = new List<GeoPath>();
            _provider.AviaSalesConnection.Airports.Load();
            var localAirports = _provider.AviaSalesConnection.Airports.Local;
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
    }
}