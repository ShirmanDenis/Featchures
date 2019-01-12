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
        private Color _default;
        private Timer _timer = new Timer();
        private bool signalFlag;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Browsable(true)]
        public string TableText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public TimeSpan SignalTime { get; set; } = new TimeSpan(0, 0,5);
        public GameTable()
        {
            InitializeComponent();
            _timer.Updated += _timer_Updated;
            _timer.SynchronizingObject = textBox1;
            _timer.Ended += _timer_Ended;
            _default = BackColor;
        }

        private void _timer_Ended(object sender, EventArgs e)
        {
            btnStartStop.Invoke((MethodInvoker)(() => btnStartStop.Text = "Start"));
            textBox1.Invoke((MethodInvoker) (() => textBox1.Text = _timer.Time.ToString(@"hh\:mm\:ss\.ff")));
        }

        private void _timer_Updated(object sender, System.Timers.ElapsedEventArgs e)
        {
            textBox1.Text = _timer.Remaining.ToString(@"hh\:mm\:ss\.ff");
            if (_timer.Remaining <= SignalTime)
            {
                //var bounds = Bounds;
                //using (var g = CreateGraphics())
                //{
                //    var pen = new Pen(new SolidBrush(signalFlag ? Color.Red : DefaultBackColor));
                //    signalFlag = !signalFlag;
                //    g.DrawRectangle(pen, bounds.X + 1, bounds.Y + 1, bounds.Width - 1, bounds.Height - 1);
                //    OnPaint(new PaintEventArgs(g, bounds));
                //}
                BackColor = signalFlag? Color.Red : _default;
                signalFlag = !signalFlag;
            }
            
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            var str = textBox1.Text;
            var regex = new Regex(@"^(?<h>\d{1,2}):(?<m>\d{1,2}):(?<s>\d{1,2})(.(\d+))?$");
            if (!regex.IsMatch(str)) 
                return;
            var match = regex.Match(str);
            var h = int.Parse(match.Groups["h"].Value);
            var m = int.Parse(match.Groups["m"].Value);
            var s = int.Parse(match.Groups["s"].Value);
            _timer.Time = new TimeSpan(0, h, m, s);
            if (_timer.IsStarted)
            {
                btnStartStop.Text = "Start";
                _timer.Stop();
                textBox1.ReadOnly = false;
            }
            else
            {
                btnStartStop.Text = "Stop";
                _timer.Start();
                textBox1.ReadOnly = true;
            }


        }

        private void GameTable_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
