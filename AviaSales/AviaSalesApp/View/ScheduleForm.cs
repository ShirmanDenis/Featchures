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

namespace AviaSalesApp.View
{
    public partial class ScheduleForm : Form, IScheduleView
    {
        private readonly ScheduleController _controller;

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

        public ScheduleForm(AviaSalesConnectionProvider provider)
        {
            InitializeComponent();

            _controller = new ScheduleController(provider, this);

            //dataView.DataSource = _controller.GetSchedule();

            InitToFromCollections();          
        }

        private void InitToFromCollections()
        {
            var localCollections = _controller.GetAirplanesPath().Select(i => (object)i).ToArray();
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

        private void button2_Click(object sender, EventArgs e)
        {
            var s = _controller.GetSchedule(PathFrom, PathTo, DateFrom, DateTo);
        }
    }
}
