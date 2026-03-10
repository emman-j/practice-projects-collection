// See https://aka.ms/new-console-template for more information
using modbus_crc_lookuptable;



// Example input data (Modbus frame: Slave ID, Function Code, Register Address, Data)
byte[] data = { 0x01, 0x06, 0x01, 0xF4, 0x00, 0x01 };

// Calculate CRC
ushort crc = CRC16Modbus.CalculateCRC(data);

// Output the result
Console.WriteLine("CRC: " + crc.ToString("X4"));