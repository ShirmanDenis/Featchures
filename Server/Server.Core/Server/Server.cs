using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SQLite;

namespace Server.Core
{
    class Server : IDisposable
    {
        public int Port { get; }
        public bool IsRunning { get; private set; }
        public IList<int> Prefixes { get; }
        public bool IsDisposed { get; private set; }
        public int Count => _threadsReg.Count;

        private readonly HttpListener _httpListener = new HttpListener();
        private Thread _listenerThread;
        private readonly Dictionary<string, int> _threadsReg = new Dictionary<string, int>();
        private int currentId = 0;

        public void Start(string prefix)
        {
            lock (_httpListener)
            {
                _httpListener.Prefixes.Clear();
                _httpListener.Prefixes.Add(prefix);
                _httpListener.Start();

                // add thread in registry
                _threadsReg.Add(currentId.ToString(), currentId);

                _listenerThread = new Thread(Listen)
                {
                    Name = currentId++.ToString(),
                    IsBackground = true,
                    Priority = ThreadPriority.Highest
                };

                IsRunning = true;
            }
        }

        public void Stop()
        {
            lock (_httpListener)
            {
                if (!IsRunning)
                    return;

                _httpListener.Stop();

                _threadsReg.Remove(_listenerThread.Name);
                _listenerThread.Abort();
                _listenerThread.Join();

                IsRunning = false;
            }
        }

        public void Listen()
        {
            while (true)
            {
                try
                {
                    if (_httpListener.IsListening)
                    {
                        // What should I do??
                    }
                    else
                    {
                        Thread.Sleep(0);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

        public void Dispose()
        {
            if (IsDisposed)
                return;

            IsDisposed = true;

            Stop();

            _httpListener.Close();
            _threadsReg.Clear();
            currentId = 0;
        }
    }
}
