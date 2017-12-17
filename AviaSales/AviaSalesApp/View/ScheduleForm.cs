using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AviaSalesApp.Common;
using AviaSalesApp.Controllers;
using AviaSalesApp.Properties;

namespace AviaSalesApp.View
{
    public partial class ScheduleForm : Form, IScheduleView
    {
        private readonly ScheduleController _controller;

        public new IAviaSalesView Parent { get; set; }

        public IControlFactory Factory => WinFormsControlFactory.Instance;

        public DateTime DateFrom
        {
            get => dateTimeFrom.Value;
            set => dateTimeFrom.Value = value;
        }

        public DateTime DateTo
        {
            get => dateTimeTo.Value;
            set => dateTimeTo.Value = value;
        }

        public GeoPath PathFrom
        {
            get => (GeoPath)cmBxFrom.SelectedItem;
            set => cmBxFrom.SelectedItem = value;
        }

        public GeoPath PathTo
        {
            get => (GeoPath)cmBxTo.SelectedItem;
            set => cmBxTo.SelectedItem = value;
        }

        public GetSchedule_Result CurrentScheduleResult => GetCurrentScheduleResult();

        public event EventHandler TicketBuy
        {
            add => buttonBuy.Click += value;
            remove => buttonBuy.Click -= value;
        }

        public ScheduleForm(AviaSalesConnectionProvider provider, IAviaSalesView parent)
        {
            InitializeComponent();

            _controller = new ScheduleController(provider, this);
            Parent = parent;
            buttonSwap.BackgroundImage = Resources.SWAP;
            buttonSwap.BackgroundImageLayout = ImageLayout.Stretch;

            dataView.MultiSelect = false;
            dataView.SelectionChanged += DataView_SelectionChanged;
            Closing += ScheduleForm_Closing;
            InitToFromCollections();          
        }

        private void ScheduleForm_Closing(object sender, CancelEventArgs e)
        {
            Parent?.Show();
        }

        private void DataView_SelectionChanged(object sender, EventArgs e)
        {
            textBoxSelectedFlight.Text = CurrentScheduleResult?.FlightName;
        }

        private void InitToFromCollections()
        {
            object[] localCollections;
            try
            {
                localCollections = _controller.GetAirplanesPath().Select(i => (object) i).ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            cmBxFrom.Items.AddRange(localCollections);
            cmBxTo.Items.AddRange(localCollections);

            cmBxTo.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmBxTo.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmBxFrom.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmBxFrom.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        public new void Show()
        {
            base.Show();
        }

        private void buttonSwap_Click(object sender, EventArgs e)
        {
            var temp = PathFrom;
            PathFrom = PathTo;
            PathTo = temp;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            try
            {
                dataView.DataSource = _controller.GetSchedule(PathFrom, PathTo, DateFrom, DateTo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (CurrentScheduleResult == null)
            {
                MessageBox.Show("Select flight in grid");
                return;
            }

            _controller.BuyTicket(CurrentScheduleResult);
        }

        private GetSchedule_Result GetCurrentScheduleResult()
        {
            if (dataView.SelectedRows.Count == 0) return null;

            var selectedRow = dataView.SelectedRows[0];

            return (GetSchedule_Result) selectedRow?.DataBoundItem;
        }
    }
}
