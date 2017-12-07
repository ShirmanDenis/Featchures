using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public IScheduleView CreateScheduleView(AviaSalesConnectionProvider provider)
        {
            return new ScheduleForm(provider);
        }

        public ILoginView CreateLoginView()
        {
            return new LoginForm();
        }
    }
}
