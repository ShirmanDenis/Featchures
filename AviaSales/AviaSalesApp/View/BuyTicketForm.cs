using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AviaSalesApp.Common;
using AviaSalesApp.Controllers;

namespace AviaSalesApp.View
{
    public partial class BuyTicketForm : Form, IBuyTicketView
    {
        public BuyTicketForm(AviaSalesConnectionProvider provider)
        {
            InitializeComponent();           
        }

        public void SetFlightInfo(Flight flight, GetSchedule_Result scheduleResult, GeoPath from, GeoPath to)
        {
            flightInfo1.SetFlight(flight, scheduleResult, from, to);
        }

        public new void Show()
        {
            base.Show();
        }
    }
}
