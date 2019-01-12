using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoluPoker.GameTable
{
    public partial class GameTable : UserControl
    {
        private INotifier _notifier;
        private bool f;
        private readonly Timer _timer = new Timer();
        private Settings _settings;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Browsable(true)]
        public string TableText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public GameTable(Settings settings, INotifier notifier)
        {
            _settings = settings;
            _notifier = notifier;
            InitializeComponent();
            _timer.Updated += _timer_Updated;
            _timer.SynchronizingObject = TextTime;
            _timer.Ended += _timer_Ended;
        }

        private void _timer_Ended(object sender, EventArgs e)
        {
            f = false;
            btnStartStop.Invoke((MethodInvoker)(() => btnStartStop.Text = "Start"));
            TextTime.Invoke((MethodInvoker) (() =>
            {
                TextTime.ReadOnly = false;
                TextTime.Text = new TimeSpan().ToString(@"hh\:mm\:ss\.ff");
            }));
        }

        private void _timer_Updated(object sender, System.Timers.ElapsedEventArgs e)
        {
            TextTime.Text = _timer.Remaining.ToString(@"hh\:mm\:ss\.ff");
            if (_timer.Remaining <= _settings.AlertTime && !f)
            {
                _notifier.Notify(TableText, $"Оставшееся время:{TextTime.Text}");
                f = !f;
            } 
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {

            if (_timer.IsStarted)
            {
                btnStartStop.Text = "Start";
                _timer.Stop();
                TextTime.ReadOnly = false;
            }
            else
            {
                var str = TextTime.Text;
                var regex = new Regex(@"^(?<h>\d{1,2}):(?<m>\d{1,2}):(?<s>\d{1,2})(.(\d+))?$");
                if (!regex.IsMatch(str))
                {
                    MessageBox.Show("Говно ты ввел, а не время");
                    return;
                }
                var match = regex.Match(str);
                var h = int.Parse(match.Groups["h"].Value);
                var m = int.Parse(match.Groups["m"].Value);
                var s = int.Parse(match.Groups["s"].Value);
                _timer.Time = new TimeSpan(0, h, m, s);
                _timer.Reset();
                btnStartStop.Text = "Stop";
                _timer.Start();
                TextTime.ReadOnly = true;
            }
        }
    }
}
