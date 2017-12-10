using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using AviaSalesApp.Common;

namespace AviaSalesApp
{
    public interface IScheduleView : IAviaSalesView
    {
        void Show();

        DateTime DateFrom { get; set; }
        DateTime DateTo { get; set; }
        
        GeoPath PathFrom { get; set; }
        GeoPath PathTo { get; set; }

        GetSchedule_Result CurrentScheduleResult { get; }

        event EventHandler TicketBuy;
    }
}