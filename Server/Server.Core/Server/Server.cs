using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NLog;
using NLog.Config;
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
        private Logger _logger = LogManager.GetCurrentClassLogger();

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
                _listenerThread.Start();

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

                _logger.Info("Server stopped");
            }
        }

        public void Listen()
        {
            _logger.Info("Server start listen");
            while (true)
            {
                try
                {
                    if (_httpListener.IsListening)
                    {
                       var context = _httpListener.GetContext();
                       Task.Factory.StartNew(() => HandleInputContextAsync(context));
                    }
                    else
                    {
                        Thread.Sleep(0);
                    }
                }
                catch (Exception error)
                {
                    _logger.Error("Error: " + error.Message);
                    _logger.Error("Object: " + error.Source);
                    _logger.Error("Мethod: " + error.TargetSite);
                    _logger.Error("StackTrace: " + error.StackTrace);
                    _logger.Error("=================================================");
                }
            }
        }

        private async void HandleInputContextAsync(HttpListenerContext context)
        {
            _logger.Info("In HandleInputContext()");

            var request = context.Request;
            string result;
            using (var reader = new StreamReader(request.InputStream))
            {
               result = await reader.ReadToEndAsync();
            }

            using (var writer = new StreamWriter(context.Response.OutputStream))
            {
                var wtf = "wtf";
                await writer.WriteLineAsync($"Result {(string.IsNullOrEmpty(result) ? result : wtf)}");
            }
            context.Response.Close();
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
