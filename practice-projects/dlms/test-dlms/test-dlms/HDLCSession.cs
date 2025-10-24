using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_dlms
{
    public class HDLCSession
    {
        public byte DestAddr { get; }
        public byte SrcAddr { get; }
        public byte SendSeq { get; private set; }
        public byte RecvSeq { get; private set; }

        public HDLCSession(byte destAddr, byte srcAddr)
        {
            DestAddr = destAddr;
            SrcAddr = srcAddr;
            Reset();
        }

        private static ushort Crc16(byte[] data, int offset, int length)
        {
            const ushort POLY = 0x1021;
            ushort crc = 0xFFFF;

            for (int i = offset; i < offset + length; i++)
            {
                crc ^= (ushort)(data[i] << 8);
                for (int j = 0; j < 8; j++)
                {
                    crc = (ushort)((crc & 0x8000) != 0 ? (crc << 1) ^ POLY : (crc << 1));
                }
            }
            return crc;
        }
        private static void AppendCrc16(List<byte> buffer, int start, int count)
        {
            ushort crc = Crc16(buffer.ToArray(), start, count);
            buffer.Add((byte)(crc >> 8));
            buffer.Add((byte)(crc & 0xFF));
        }

        public void Reset() => SendSeq = RecvSeq = 0;
        public byte[] BuildSnrm()
        {
            // SNRM information field (negotiation parameters)
            byte[] info = new byte[]
            {
                0x81, 0x80, // HDLC parameters tag
                0x14,       // Length
                0x05, 0x01, 0x80, // Maximum frame size transmit
                0x06, 0x04, 0x00, 0x00, 0x05, 0xDC, // Window size
                0x07, 0x04, 0x00, 0x00, 0x05, 0xDC  // Window size receive
            };

            // Build frame
            List<byte> frame = new List<byte>();
            frame.Add(0x7E); // Start flag

            // Calculate frame length (address + control + HCS + info + FCS)
            int length = 1 + 1 + 1 + 2 + info.Length + 2;

            frame.Add(0xA0);
            frame.Add((byte)length);

            frame.Add(DestAddr);
            frame.Add(SrcAddr);
            frame.Add(0x93); // Control field (SNRM)

            // Add HCS (CRC for header)
            AppendCrc16(frame, 2, 3);

            // Add information field
            frame.AddRange(info);

            // Add FCS (CRC for whole frame except starting flag)
            AppendCrc16(frame, 2, frame.Count - 2);

            frame.Add(0x7E); // End flag

            return frame.ToArray();
        }
        public byte[] BuildAarq()
        {
            // -------------------- AARQ APDU --------------------
            List<byte> apdu = new List<byte>();

            // Application context name (LN referencing)
            byte[] appContext = { 0xA1, 0x09, 0x06, 0x07, 0x60, 0x85, 0x74, 0x05, 0x08, 0x01, 0x01 };
            apdu.AddRange(appContext);

            // Mechanism name (low-level security)
            byte[] mechName = { 0x8A, 0x02, 0x07, 0x80 };
            apdu.AddRange(mechName);

            // Calling AP title (client ID)
            byte[] callingApTitle = { 0xA6, 0x06, 0x04, 0x04, 0x00, 0x00, 0x00, 0x01 };
            apdu.AddRange(callingApTitle);

            // User information (xDLMS InitiateRequest)
            List<byte> userInfo = new List<byte>()
            {
                0xBE, 0x10, // Tag + length
                0x04, 0x0E, // Octet string tag + length
                0x01, 0x00, 0x00, 0x00, // DLMS version + conformance block start
                0x06, 0x5F, 0x1F, 0x04, // Conformance block (LN)
                0x00, 0x62, 0x1E, 0x5D, // Max PDU size (0x1E5D = 7773)
                0xFF, 0xFF // Max info field (placeholder)
            };
            apdu.AddRange(userInfo);

            // Wrap in AARQ [APPLICATION 0] (Tag 0x60)
            List<byte> aarq = new List<byte>() { 0x60, (byte)apdu.Count };
            aarq.AddRange(apdu);

            // -------------------- HDLC Wrapper --------------------
            List<byte> frame = new List<byte>() { 0x7E, 0xA0 };
            int frameLen = 1 + 1 + 1 + 2 + aarq.Count + 2;
            frame.Add((byte)frameLen);

            frame.Add(DestAddr);
            frame.Add(SrcAddr);
            frame.Add(0x10); // Control: I-frame, SendSeq=0, RecvSeq=0
            AppendCrc16(frame, 2, 3);

            frame.AddRange(aarq);
            AppendCrc16(frame, 2, frame.Count - 2);
            frame.Add(0x7E);

            return frame.ToArray();
        }

        // ===================== Build GET-Request placeholder =====================
        public byte[] BuildGetRequest(byte[] obis)
        {
            // Later you’ll encode the COSEM GET-Request APDU dynamically.
            // Placeholder for now.
            return Array.Empty<byte>();
        }

        // ===================== Helper =====================
        public static string ToHex(byte[] data) => BitConverter.ToString(data).Replace("-", " ");
        private static byte[] HexToBytes(string hex)
        {
            return hex.Split(' ')
                      .Select(b => Convert.ToByte(b, 16))
                      .ToArray();
        }
    }

}
