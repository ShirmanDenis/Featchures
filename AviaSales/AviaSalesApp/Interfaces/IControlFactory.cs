using AviaSalesApp.Common;
using AviaSalesApp.Controllers;

namespace AviaSalesApp
{
    public interface IControlFactory
    {
        ILoginView CreateLoginView();
        IScheduleView CreateScheduleView(AviaSalesConnectionProvider provider);
        IBuyTicketView CreateBuyTicketView(AviaSalesConnectionProvider provider);
    }
}