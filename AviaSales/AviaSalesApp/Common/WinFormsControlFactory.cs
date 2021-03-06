﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AviaSalesApp.Controllers;
using AviaSalesApp.View;

namespace AviaSalesApp.Common
{
    class WinFormsControlFactory : IControlFactory
    {
        static WinFormsControlFactory()
        {
            Instance = new WinFormsControlFactory();
        }

        public static IControlFactory Instance { get; }

        private WinFormsControlFactory() { }

        public IScheduleView CreateScheduleView(AviaSalesConnectionProvider provider, IAviaSalesView parent)
        {
            return new ScheduleForm(provider, parent);
        }

        public IBuyTicketView CreateBuyTicketView(AviaSalesConnectionProvider provider, IAviaSalesView parent)
        {
            return new BuyTicketForm(provider, parent);
        }

        public IRegisterView CreateRegisterView(AviaSalesConnectionProvider provider, IAviaSalesView parent)
        {
            return new RegisterForm(provider, parent);
        }

        public ILoginView CreateLoginView()
        {
            return new LoginForm();
        }
    }
}
