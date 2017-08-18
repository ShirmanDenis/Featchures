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
            using (var server = new Server())
            {
                server.Start("http://+:8080/");

                Console.Write("Send to server: ");
                var data = Console.ReadLine();

                const string baseAdress = "http://localhost:8080/";
                var uri = new Uri(baseAdress);
                var webClient = new WebClient { BaseAddress = baseAdress };

                webClient.UploadString(uri, data);

                Console.Write("Sending..");
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
