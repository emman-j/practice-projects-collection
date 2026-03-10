using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modbus_crc_lookuptable
{
    public class CRC16Modbus
    {
        // Modbus CRC-16 polynomial (reflected)
        private static readonly ushort POLYNOMIAL = 0xA001;

        // Precomputed CRC-16 lookup table
        private static readonly ushort[] CRC16Table = new ushort[256];

        static CRC16Modbus()
        {
            // Initialize the lookup table
            for (ushort i = 0; i < 256; i++)
            {
                ushort crc = i;
                for (ushort j = 8; j > 0; j--)
                {
                    if ((crc & 0x0001) != 0)
                    {
                        crc >>= 1;
                        crc ^= POLYNOMIAL;
                    }
                    else
                    {
                        crc >>= 1;
                    }
                }
                CRC16Table[i] = crc;
            }
        }

        public static ushort CalculateCRC(byte[] data)
        {
            ushort crc = 0xFFFF;  // Initial value
            foreach (byte b in data)
            {
                byte tableIndex = (byte)(((crc) & 0xFF) ^ b);  // Get the lower byte of the current CRC and XOR with current byte
                crc = (ushort)((crc >> 8) ^ CRC16Table[tableIndex]);  // Update CRC using the lookup table
            }
            return crc;
        }
        public static byte[] CalculateCRCByte(byte[] data)
        {
            ushort crc = CalculateCRC(data);

            byte lowByte = (byte)(crc & 0xFF); 
            byte highByte = (byte)((crc >> 8) & 0xFF); 
            return new byte[] { highByte, lowByte };  
        }

        // Swap the CRC bytes (Modbus format is low byte first)
        public static byte[] SwapCRCBytes(ushort crc)
        {
            byte highByte = (byte)(crc >> 8);  // Extract high byte
            byte lowByte = (byte)(crc & 0xFF); // Extract low byte

            return new byte[] { lowByte, highByte };  // Return as low byte first, then high byte
        }
        public static byte[] SwapCRCBytes(byte[] data)
        {
            byte highByte = data[0]; 
            byte lowByte = data[1];

            return new byte[] { lowByte, highByte };
        }

    }
}
