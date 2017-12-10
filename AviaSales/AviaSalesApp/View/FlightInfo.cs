using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AviaSalesApp.Common;

namespace AviaSalesApp.View
{
    public partial class FlightInfo : UserControl
    {
        public FlightInfo()
        {
            InitializeComponent();
        }

        private void FlightInfo_Load(object sender, EventArgs e)
        {

        }

        public void SetFlight(Flight flight, GetSchedule_Result scheduleResult, GeoPath from, GeoPath to)
        {
            txBxFlightName.Text = flight.FlightName;
            txBxCompanyName.Text = scheduleResult.CompanyName;
            txBxDepartureDate.Text = flight.FlightDate.ToShortDateString() + @" " + scheduleResult.DepartureTime;
            txBxArrivalDate.Text = scheduleResult.ArrivalDate.Date.ToShortDateString() + @" " + scheduleResult.ArrivalDate.TimeOfDay;
            txBxFrom.Text = from.ToString();
            txBxTo.Text = to.ToString();
            txBxPlaneType.Text = scheduleResult.PlaneTypeName;
        }
    }
}
