using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_dlms
{
    internal class Program
    {
        static SerialPort _serial;

        static void Main(string[] args)
        {
            // Configure serial port
            _serial = new SerialPort("COM3", 115600, Parity.None, 8, StopBits.One);
            _serial.DataReceived += Serial_DataReceived;
            _serial.Open();

            Console.WriteLine("Connected to " + _serial.PortName);
            Console.WriteLine("Press Enter to send DLMS frame...");
            Console.ReadLine();

            //    // Example DLMS frame (as hex string)
            //    List<string> frames = new List<string>
            //    {
            //        /* SNRM */ "7E A0 07 03 21 93 0F 01 7E",
            //        /* AARQ */ "7E A0 4C 03 21 10 3E 61 E6 E6 00 60 3E A1 09 06 07 60 85 74 05 08 01 01 8A 02 07 80 8B 07 60 85 74 05 08 02 02 AC 12 80 10 64 03 2A 12 47 16 18 2B 59 61 19 5A 0D 09 2E 73 BE 10 04 0E 01 00 00 00 06 5F 1F 04 00 62 1E 5D FF FF 36 26 7E",
            //        /* AARE */ "7E A0 2B 03 21 32 EB AD E6 E6 00 C3 01 C1 00 0F 00 00 28 00 00 FF 01 01 09 10 6E 40 78 64 A2 F5 FA 45 A6 8F 8C 6D EF 93 C7 03 CB 9F 7E",

            // /* Collecting objects */ "7E A0 19 03 21 54 5F DE E6 E6 00 C0 01 C1 00 0F 00 00 28 00 00 FF 02 00 91 53 7E",
            //        /* next frame */ "7E A0 07 03 21 71 13 C5 7E",
            //        /* next frame */ "7E A0 07 03 21 91 1D 22 7E",
            //        /* next frame */ "7E A0 07 03 21 B1 1F 03 7E",
            //        /* next frame */ "7E A0 13 03 21 D6 EB A5 E6 E6 00 C0 02 C1 00 00 00 01 51 BE 7E",
            //        /* next frame */ "7E A0 07 03 21 F1 1B 41 7E",
            //        /* next frame */ "7E A0 07 03 21 11 15 A6 7E",
            //        /* next frame */ "7E A0 07 03 21 31 17 87 7E",
            //        /* next frame */ "7E A0 13 03 21 58 9D C8 E6 E6 00 C0 02 C1 00 00 00 02 CA 8C 7E",
            //        /* next frame */ "7E A0 07 03 21 71 13 C5 7E",
            //        /* next frame */ "7E A0 07 03 21 91 1D 22 7E",
            //        /* next frame */ "7E A0 07 03 21 B1 1F 03 7E",
            //    };

            //    foreach (var frame in frames)
            //    {
            //        byte[] hexFrame = HexStringToBytes(frame);
            //        _serial.Write(hexFrame, 0, hexFrame.Length);
            //        Console.WriteLine($"TX: [{hexFrame.Length} bytes]: {BitConverter.ToString(hexFrame).Replace('-',' ')}");
            //        Task.Delay(1000).Wait(); // Wait a bit between frames
            //    }

            var session = new HDLCSession(0x03, 0x21);

            byte[] snrm = session.BuildSnrm();
            byte[] aarq = session.BuildAarq();

            string hexFrame = "7E A0 07 03 21 93 0F 01 7E";
            byte[] frameBytes = HexStringToBytes(hexFrame);
            // Send the frame
            _serial.Write(frameBytes, 0, frameBytes.Length);
            Console.WriteLine($"Sent: {BitConverter.ToString(frameBytes).Replace('-', ' ')}");
            Task.Delay(1000).Wait(); // Wait a bit between frames

            // Send the frame
            _serial.Write(snrm, 0, snrm.Length);
            Console.WriteLine($"Sent: {BitConverter.ToString(snrm).Replace('-', ' ')}");
            Task.Delay(1000).Wait(); // Wait a bit between frames

            // Send the frame
            _serial.Write(aarq, 0, aarq.Length);
            Console.WriteLine($"Sent: {BitConverter.ToString(aarq).Replace('-', ' ')}");

            Console.WriteLine("Listening for response... (press any key to exit)");
            Console.ReadKey();
            _serial.Close();
        }

        private static void Serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //var sp = (SerialPort)sender;
            //int bytesToRead = sp.BytesToRead;
            //byte[] buffer = new byte[bytesToRead];
            //sp.Read(buffer, 0, bytesToRead);

            //// Print received bytes as HEX
            //Console.WriteLine("Received: " + BitConverter.ToString(buffer));

            var sp = (SerialPort)sender;
            var data = new List<byte>();
            while (sp.BytesToRead > 0)
                data.Add((byte)sp.ReadByte());
            Console.WriteLine($"RX [{data.Count} bytes]: {BitConverter.ToString(data.ToArray()).Replace('-', ' ')}" + Environment.NewLine);
        }

        private static byte[] HexStringToBytes(string hex)
        {
            return hex.Split(' ')
                      .Select(b => Convert.ToByte(b, 16))
                      .ToArray();
        }
    }
}
