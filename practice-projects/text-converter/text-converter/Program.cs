using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace text_converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "";
            string logEntry = File.ReadAllText(filePath);
            string l = HexToString(logEntry);

            string[] lines = logEntry.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            foreach (string line in lines)
            {
                Console.WriteLine(HexToString(line));
            }

            //Console.WriteLine(l);
        }

        public static string HexToString(string hex)
        {
            // Remove spaces or newlines between bytes if any
            hex = hex.Replace(" ", "").Replace("\r", "").Replace("\n", "");

            // Convert pairs of hex characters into bytes
            byte[] bytes = Enumerable.Range(0, hex.Length / 2)
                                     .Select(i => Convert.ToByte(hex.Substring(i * 2, 2), 16))
                                     .ToArray();

            // Decode as UTF-8 text
            return Encoding.UTF8.GetString(bytes);
        }
    }
}
