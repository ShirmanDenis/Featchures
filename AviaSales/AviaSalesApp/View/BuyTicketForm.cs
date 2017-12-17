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
        public IAviaSalesView Parent { get; set; }
        public IControlFactory Factory => WinFormsControlFactory.Instance;

        private readonly BuyTicketController _controller;

        public BuyTicketForm(AviaSalesConnectionProvider provider, IAviaSalesView parent)
        {
            InitializeComponent();
            Parent = parent;
            _controller = new BuyTicketController(provider, this);
        }

        public void SetFlightInfo(Flight flight, GetSchedule_Result scheduleResult, GeoPath from, GeoPath to)
        {
            Flight = flight;
            From = from;
            ScheduleResult = scheduleResult;
            To = to;

            flightInfo1.SetFlight(flight, scheduleResult, from, to);
        }

        public Flight Flight { get; set; }
        public GetSchedule_Result ScheduleResult { get; set; }
        public GeoPath From { get; set; }
        public GeoPath To { get; set; }

        public string PassangerName => passangerInfoView1.PassangerName;
        public string SurName => passangerInfoView1.Surname;
        public string Patronymic => passangerInfoView1.Patronymic;
        public int Passport => passangerInfoView1.Passport;

        public new void Show()
        {
            base.ShowDialog();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Parent.Show();

            Close();
        }

        private void buttonBuyTicket_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PassangerName) ||
                string.IsNullOrEmpty(SurName) ||
                string.IsNullOrEmpty(Patronymic) ||
                string.IsNullOrEmpty(Passport.ToString()))
            {
                MessageBox.Show("All fields in \"PassangerInfo\" must be filled!");
                return;
            }

            var fullNameBuilder = new StringBuilder();

            fullNameBuilder
                .Append(PassangerName)
                .Append(" ")
                .Append(SurName)
                .Append(" ")
                .Append(Patronymic);

            try
            {
                _controller.BuyTicket(Flight, fullNameBuilder.ToString(), Passport.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show("Ticket bought!");
        }
    }
}
