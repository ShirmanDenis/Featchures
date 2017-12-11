using System;
using AviaSalesApp.Common;

namespace AviaSalesApp
{
    public interface IBuyTicketView
    {
        Flight Flight { get; set; }
        GetSchedule_Result ScheduleResult { get; set; }
        GeoPath From { get; set; }
        GeoPath To { get; set; }

        string PassangerName { get;}
        string SurName { get;}
        string Patronymic { get;}
        int Passport { get;}

        void Show();
        void SetFlightInfo(Flight findFlightBuyName, GetSchedule_Result scheduleResult, GeoPath viewPathFrom, GeoPath viewPathTo);
    }
}