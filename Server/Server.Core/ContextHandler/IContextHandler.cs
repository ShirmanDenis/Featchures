using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Server.Core
{
    interface IContextHandler : IDisposable
    {
        Task HandleInputContext(HttpListenerContext context);
    }
}
