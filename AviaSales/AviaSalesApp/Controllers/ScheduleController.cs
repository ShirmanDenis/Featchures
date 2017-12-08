﻿using System;
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
        }

        public BindingList<ScheduleView> GetSchedule()
        {
            _provider.AviaSalesConnection.ScheduleViews.Load();

            return _provider.AviaSalesConnection.ScheduleViews.Local.ToBindingList();
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