using AviaSalesApp.Common;

namespace AviaSalesApp
{
    public interface IBuyTicketView
    {
        void Show();
        void SetFlightInfo(Flight findFlightBuyName, GetSchedule_Result scheduleResult, GeoPath viewPathFrom, GeoPath viewPathTo);
    }
}