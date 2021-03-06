﻿using AviaSalesApp.Common;
using AviaSalesApp.Controllers;

namespace AviaSalesApp
{
    public interface IControlFactory
    {
        ILoginView CreateLoginView();
        IScheduleView CreateScheduleView(AviaSalesConnectionProvider provider, IAviaSalesView parent);
        IBuyTicketView CreateBuyTicketView(AviaSalesConnectionProvider provider, IAviaSalesView parent);
        IRegisterView CreateRegisterView(AviaSalesConnectionProvider provider, IAviaSalesView parent);
    }
}