using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AviaSalesApp.Controllers;

namespace AviaSalesApp.View
{
    public partial class ScheduleForm : Form, IScheduleView
    {
        private ScheduleController _controller;

        public ScheduleForm(AviaSalesConnectionProvider provider)
        {
            InitializeComponent();

            _controller = new ScheduleController(provider, this);

            dataView.DataSource = _controller.GetSchedule();
        }

        public new void Show()
        {
            base.Show();
        }
    }
}
