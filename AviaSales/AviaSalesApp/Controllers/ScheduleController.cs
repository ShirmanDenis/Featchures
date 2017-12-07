using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
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

        public BindingList<Schedule> GetSchedule()
        {
            _provider.AviaSalesConnection.Schedules.Load();

            return _provider.AviaSalesConnection.Schedules.Local.ToBindingList();
        }
    }
}