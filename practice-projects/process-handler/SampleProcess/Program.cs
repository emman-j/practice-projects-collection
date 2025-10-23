using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleProcess
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();

            // Start the periodic timestamp task
            //var periodicTask = Task.Run(() => PrintTimestampsAsync(cts.Token));
            Thread.Sleep(250);
            for (int i = 0; i < 10; i++)
            {
                string randomText = GenerateRandomText(12);
                Console.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] Loading: {randomText}");
                Thread.Sleep(150);
            }

            Console.WriteLine("Type commands below (type 'exit' to quit):");

            // Listen for user input in the main thread
            while (true)
            {
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    continue;

                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Exiting...");
                    cts.Cancel();
                    break;
                }


                if (input.Equals("TEST", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("TESTINGGGGGGG...");
                }
                if (input.Equals("GetExePath", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Path: " + AppDomain.CurrentDomain.BaseDirectory);
                }


                //Console.WriteLine($"[COMMAND RECEIVED] {input}");
            }

            //await periodicTask;
        }
        static string GenerateRandomText(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz"; // Start with lowercase only
            Random random = new Random();
            char[] text = new char[length];

            for (int i = 0; i < length; i++)
            {
                char c = chars[random.Next(chars.Length)];

                // Randomly make it uppercase or lowercase
                if (random.Next(2) == 0)
                    c = char.ToUpper(c);

                text[i] = c;
            }

            return new string(text);
        }

        static async Task PrintTimestampsAsync(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                Console.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] Tick...");
                await Task.Delay(2000, token); // print every 2 seconds
            }
        }
    }
}
