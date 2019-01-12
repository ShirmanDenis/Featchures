using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace PoluPoker
{
    class Timer
    {
        private readonly Stopwatch _real;
        private readonly System.Timers.Timer _updateTimer = new System.Timers.Timer();
        public Timer()
        {
            _real = new Stopwatch();
            _updateTimer.Interval = 150;
            _updateTimer.AutoReset = true;
        }
        public event ElapsedEventHandler Updated
        {
            add { _updateTimer.Elapsed += value; }
            remove { _updateTimer.Elapsed -= value; }
        }

        public event EventHandler Ended;

        public ISynchronizeInvoke SynchronizingObject
        {
            get { return _updateTimer.SynchronizingObject; }
            set { _updateTimer.SynchronizingObject = value; }
        }
        public TimeSpan Time { get; set; } = new TimeSpan(0,0,0, 20);

        public TimeSpan Remaining => Time - _real.Elapsed;

        public bool IsStarted => _real.IsRunning;

        public void Start()
        {
            if (_real.IsRunning) return;

            _real.Start();
            _updateTimer.Start();
            Task.Run(() =>
            {
                while (_real.IsRunning)
                {
                    if (Time - _real.Elapsed <= new TimeSpan(0, 0, 0, 0))
                        break;
                    Thread.Sleep(150);
                }

                if (Time - _real.Elapsed <= new TimeSpan(0, 0, 0, 0))
                {
                    Stop();
                    Reset();
                    Ended?.Invoke(this, null);
                }
            });
        }

        public void Stop()
        {
            _real.Stop();
            _updateTimer.Stop();
        }

        public void Reset()
        {
            _real.Reset();
            _updateTimer.Stop();
        }
    }
}
