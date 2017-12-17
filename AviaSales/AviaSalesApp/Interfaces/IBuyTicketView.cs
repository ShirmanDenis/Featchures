using System;
using AviaSalesApp.Common;

namespace AviaSalesApp
{
    public interface IBuyTicketView : IAviaSalesView
    {
        Flight Flight { get; set; }
        GetSchedule_Result ScheduleResult { get; set; }
        GeoPath From { get; set; }
        GeoPath To { get; set; }
        SeatClass SeatClass { get; set; }
        decimal Price { get; }

        string PassangerName { get;}
        string SurName { get;}
        string Patronymic { get;}
        int Passport { get;}

        void SetFlightInfo(Flight findFlightBuyName, GetSchedule_Result scheduleResult, GeoPath viewPathFrom, GeoPath viewPathTo);
    }
}