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
using PoluPoker.Properties;
using PoluPoker.Tools;

namespace PoluPoker.GameTable
{
    public partial class GameTable : UserControl
    {
        private Image _start = Resources.play;
        private Image _stop = Resources.stop;
        private INotifier _notifier;
        private bool f;
        private readonly Timer _timer = new Timer();
        private Settings _settings;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Browsable(true)]
        public string TableText
        {
            get { return label.Text; }
            set { label.Text = value; }
        }

        public GameTable(): this(new Settings(), new Notifier())
        {
        }

        public GameTable(Settings settings, INotifier notifier)
        {
            _settings = settings;
            _notifier = notifier;
            InitializeComponent();
            
            _timer.Updated += _timer_Updated;
            _timer.SynchronizingObject = labelTime;
            _timer.Ended += _timer_Ended;
            textBox1.KeyDown += TextBox1_KeyDown;
            panelStartStop.Click += btnStartStop_Click;
            panelStartStop.MouseEnter += PanelStartStop_MouseEnter;
            panelStartStop.MouseLeave += PanelStartStop_MouseLeave;
        }

        private void PanelStartStop_MouseLeave(object sender, EventArgs e)
        {
            var img = _timer.IsStarted ? _stop : _start;
            panelStartStop.BackgroundImage = Helpers.SetImageOpacity(img, 0.7f);
        }

        private void PanelStartStop_MouseEnter(object sender, EventArgs e)
        {
            var img = _timer.IsStarted ? _stop : _start;
            panelStartStop.BackgroundImage = Helpers.SetImageOpacity(img, 1f);
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TableText = textBox1.Text;
                textBox1.Hide();
            }

            if (e.KeyCode == Keys.Escape)
            {
                textBox1.Hide();
            }
        }

        private void _timer_Ended(object sender, EventArgs e)
        {
            f = false;
            panelStartStop.Invoke((MethodInvoker)(() => panelStartStop.BackgroundImage = Resources.play));
            labelTime.Invoke((MethodInvoker)(() =>
            {
                labelTime.Text = new TimeSpan().ToString(@"hh\:mm\:ss\.ff");
            }));
        }

        private void _timer_Updated(object sender, System.Timers.ElapsedEventArgs e)
        {
            labelTime.Text = _timer.Remaining.ToString(@"hh\:mm\:ss");
            if (_timer.Remaining <= _settings.AlertTime && !f)
            {
                _notifier.Notify(TableText, $"Оставшееся время:{labelTime.Text}");
                f = !f;
            } 
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (_timer.IsStarted)
            {
                panelStartStop.BackgroundImage = _start;
                _timer.Stop();
            }
            else
            {
                var str = labelTime.Text;
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
                panelStartStop.BackgroundImage = _stop;
                _timer.Start();
            }
        }

        private void label_MouseEnter(object sender, EventArgs e)
        {
            var color = BackColor;
            BackColor = Color.FromArgb(255, color.R, color.G, color.B);
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            var color = BackColor;
            BackColor = Color.FromArgb(150, color.R, color.G, color.B);
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void label_DoubleClick(object sender, EventArgs e)
        {
            var height = label.Font.Height;
            var width = TextRenderer.MeasureText(TableText, label.Font).Width;
            var x = (label.Width - width) / 2;
            var y = (label.Height - height) / 2;
            textBox1.Location = new Point(x, y);
            textBox1.Width = width;
            textBox1.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelEdit_MouseEnter(object sender, EventArgs e)
        {
            panelEdit.BackgroundImage.Dispose();
            panelEdit.BackgroundImage = Helpers.SetImageOpacity(Resources.edit, 1);
        }

        private void panelEdit_MouseLeave(object sender, EventArgs e)
        {
            panelEdit.BackgroundImage.Dispose();
            panelEdit.BackgroundImage = Helpers.SetImageOpacity(Resources.edit, 0.7f);
        }
    }
}
