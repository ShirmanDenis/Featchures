using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Server.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var server = new Server(new ContextHandlerBase()))
            {
                server.Start("http://+:8080/");

                Console.Write("Send to server: ");
                var data = Console.ReadLine();
            }
        }

        private static async void SendData()
        {
            await Task.Run(() =>
            {

            });
        }
    }
}
