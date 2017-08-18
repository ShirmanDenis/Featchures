using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Server.Core
{
    public class ContextHandlerBase : IContextHandler
    {
        private HttpListenerContext _context;

        public async Task HandleInputContext(HttpListenerContext context)
        {
            _context = context;
            string result;
            using (var reader = new StreamReader(context.Request.InputStream))
            {
                result = await reader.ReadToEndAsync();
            }
            using (var writer = new StreamWriter(context.Response.OutputStream))
            {
                await writer.WriteLineAsync(!string.IsNullOrEmpty(result) ? result : "No data");
            }
        }

        public void Dispose()
        {
            _context.Response.Close();
        }
    }
}
