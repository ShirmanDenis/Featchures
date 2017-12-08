using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using AviaSalesApp.Common;

namespace AviaSalesApp
{
    public interface IScheduleView
    {
        void Show();

        DateTime DateFrom { get; set; }
        DateTime DateTo { get; set; }
        
        GeoPath PathFrom { get; set; }
        GeoPath PathTo { get; set; }

        event EventHandler TicketBuy;
    }
}