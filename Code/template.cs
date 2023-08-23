using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using DiscordRPC;
using DiscordRPC.Logging;
using System.Threading;

namespace template
{
    class Program
    {
        private static DiscordRpcClient client;
        static void Main(string[] args)
        {
            bool drpc = false;
            string procbyme = ("ProcessName");
            //Checks if process is running

            Process[] processes = Process.GetProcessesByName(procbyme);

            if (processes.Length == 0)
            {
                Console.WriteLine(procbyme + " is Not running...");
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine(procbyme + " is Running...");
                Thread.Sleep(1000);
                drpc = true;
            }

            //////////////////////////////////
            if (drpc == true)
            {
                Console.WriteLine("Drpc Starting...");
                Initialize();
            }
            else
            {
                Console.WriteLine("Drpc failed to start...");
                Thread.Sleep(2000);
                Console.WriteLine("Exiting...");
                Thread.Sleep(1000);
                return;
            }
            Thread.Sleep(1000);
            Console.ReadLine();
            ///////////////////////////
        }
        private static void Initialize()
        {
            client = new DiscordRpcClient("1123875083971219520");
            //Set the logger
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            //Subscribe to events
            client.OnReady += (sender, e) =>
            {
                Console.WriteLine("Received Ready from user {0}", e.User.Username);
            };
            client.OnPresenceUpdate += (sender, e) =>
            {
                Console.WriteLine("Received Update! {0}", e.Presence);
                Console.WriteLine("________________________________________");
                Console.WriteLine("  Keep this window running");
                Console.WriteLine(new string('\n', 7));
                Console.WriteLine("Ctrl + C to close this program");
            };
            client.Initialize();
            client.SetPresence(new RichPresence()
            {
                //Details = "Details test",
                State = " Stating...",
                Timestamps = Timestamps.Now,
                Buttons = new Button[]
                {
                    new Button() { Label = "‎ ", Url = "https://github.com/v4ish/RPC" }
                },
                Assets = new Assets()
                {
                    LargeImageKey = "logo",
                    LargeImageText = "Large-image",
                    SmallImageKey = "logo-new",
                    SmallImageText = "Small-image"
                    //logo, logo-new
                }
            });
        }
    }
}
