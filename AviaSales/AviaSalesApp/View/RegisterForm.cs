using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AviaSalesApp.Common;
using AviaSalesApp.Controllers;

namespace AviaSalesApp.View
{
    public partial class RegisterForm : Form, IRegisterView
    {
        private readonly RegisterController _controller;

        public RegisterForm(AviaSalesConnectionProvider provider, IAviaSalesView parent)
        {
            InitializeComponent();
            Parent = parent;
            _controller = new RegisterController(provider, this);

            Closing += RegisterForm_Closing;
        }

        public new IAviaSalesView Parent { get; set; }
        public IControlFactory Factory => WinFormsControlFactory.Instance;
        public long TicketId
        {
            get => GetTicketId();
            set => txBxTicketId.Text = value.ToString();
        }

        private long GetTicketId()
        {
            if (long.TryParse(txBxTicketId.Text, out long ticketId)) return ticketId;

            MessageBox.Show("Must be an number");

            txBxTicketId.Text = "";

            return 0;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.Save();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
            MessageBox.Show("Saved!");
        }

        private void txBxTicketId_Validating(object sender, CancelEventArgs e)
        {
            var regex = new Regex(@"\D");
            if (regex.IsMatch(txBxTicketId.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Only numbers is valid");
            }
        }

        private void RegisterForm_Closing(object sender, CancelEventArgs e)
        {
            Parent.Show();
        }

        private void buttonFindTicket_Click(object sender, EventArgs e)
        {
            var ticket = _controller.FindTicket(TicketId);

            if (ticket == null)
            {
                MessageBox.Show("Такого билета не существует");
                return;
            }
            ticketBindingSource.Clear();
            passengerBindingSource.Clear();
            passengerBindingSource.Clear();
            ticketBindingSource.Add(ticket);
            passengerBindingSource.Add(ticket.Passenger);
            try
            {
                var planeSeats = _controller.FindPlaneSeats(ticket.Price.PlaneType_ID, ticket.Price.SeatClass_ID);
                foreach (var planeSeat in planeSeats)
                {
                    planeSeatBindingSource.Add(planeSeat);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
