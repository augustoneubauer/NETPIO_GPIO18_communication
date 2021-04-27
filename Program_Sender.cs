using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;

namespace Mssc.Services.ConnectionManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setting Default status for Ports

            //string txdata = "TXDATA";       //01010100 01011000 01000100 01000001 01010100 01000001
            uint T = 0b_01010100;
            uint X = 0b_01011000;
            uint D = 0b_01000100;
            uint A = 0b_01000001;
            uint ADC = 0b_00000000;
            uint DRB = 0b_11111111;
            uint DRC = 0b_11111111;
            uint DRD = 0b_11111111;
            uint PORTB = 0b_00000000;
            uint PORTC = 0b_00000000;
            uint PORTD = 0b_00000000;
            uint ResLen = 0b_11111111;
            uint Sync = 0b_00000000;

            if (args.Length > 0)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i] == "B0_ON")
                    {
                        int bitInByteIndex = 0 % 8;
                        uint mask = (uint)(1 << bitInByteIndex);
                        bool isSet = (PORTB & mask) != 0;

                        PORTB |= mask;
                    }

                    if (args[i] == "B0_OFF")
                    {
                        int bitInByteIndex = 0 % 8;
                        uint mask = (uint)(1 << bitInByteIndex);
                        bool isSet = (PORTB & mask) != 0;

                        PORTB &= ~mask;
                    }
                    if (args[i] == "B1_ON")
                    {
                        int bitInByteIndex = 1 % 8;
                        uint mask = (uint)(1 << bitInByteIndex);
                        bool isSet = (PORTB & mask) != 0;

                        PORTB |= mask;
                    }
                    if (args[i] == "B1_OFF")
                    {
                        int bitInByteIndex = 0 % 8;
                        uint mask = (uint)(1 << bitInByteIndex);
                        bool isSet = (PORTB & mask) != 0;

                        PORTB &= ~mask;
                    }
                    if (args[i] == "B2_ON")
                    {
                        int bitInByteIndex = 2 % 8;
                        uint mask = (uint)(1 << bitInByteIndex);
                        bool isSet = (PORTB & mask) != 0;

                        PORTB |= mask;
                    }
                    if (args[i] == "B2_OFF")
                    {
                        int bitInByteIndex = 2 % 8;
                        uint mask = (uint)(1 << bitInByteIndex);
                        bool isSet = (PORTB & mask) != 0;

                        PORTB &= ~mask;
                    }
                    if (args[i] == "B3_ON")
                    {
                        int bitInByteIndex = 3 % 8;
                        uint mask = (uint)(1 << bitInByteIndex);
                        bool isSet = (PORTB & mask) != 0;

                        PORTB |= mask;
                    }
                    if (args[i] == "B3_OFF")
                    {
                        int bitInByteIndex = 3 % 8;
                        uint mask = (uint)(1 << bitInByteIndex);
                        bool isSet = (PORTB & mask) != 0;

                        PORTB &= ~mask;
                    }
                    if (args[i] == "B4_ON")
                    {
                        int bitInByteIndex = 4 % 8;
                        uint mask = (uint)(1 << bitInByteIndex);
                        bool isSet = (PORTB & mask) != 0;

                        PORTB |= mask;
                    }
                    if (args[i] == "B4_OFF")
                    {
                        int bitInByteIndex = 4 % 8;
                        uint mask = (uint)(1 << bitInByteIndex);
                        bool isSet = (PORTB & mask) != 0;

                        PORTB &= ~mask;
                    }
                    if (args[i] == "B5_ON")
                    {
                        int bitInByteIndex = 5 % 8;
                        uint mask = (uint)(1 << bitInByteIndex);
                        bool isSet = (PORTB & mask) != 0;

                        PORTB |= mask;
                    }
                    if (args[i] == "B5_OFF")
                    {
                        int bitInByteIndex = 5 % 8;
                        uint mask = (uint)(1 << bitInByteIndex);
                        bool isSet = (PORTB & mask) != 0;

                        PORTB &= ~mask;
                    }
                    if (args[i] == "D2_ON")
                    {
                        int bitInByteIndex = 2 % 8;
                        uint mask = (uint)(1 << bitInByteIndex);
                        bool isSet = (PORTD & mask) != 0;

                        PORTD |= mask;
                    }
                    if (args[i] == "D2_OFF")
                    {
                        int bitInByteIndex = 2 % 8;
                        uint mask = (uint)(1 << bitInByteIndex);
                        bool isSet = (PORTD & mask) != 0;

                        PORTD &= ~mask;
                    }
                    if (args[i] == "D3_ON")
                    {
                        int bitInByteIndex = 3 % 8;
                        uint mask = (uint)(1 << bitInByteIndex);
                        bool isSet = (PORTD & mask) != 0;

                        PORTD |= mask;
                    }
                    if (args[i] == "D3_OFF")
                    {
                        int bitInByteIndex = 3 % 8;
                        uint mask = (uint)(1 << bitInByteIndex);
                        bool isSet = (PORTD & mask) != 0;

                        PORTD &= ~mask;
                    }
                    if (args[i] == "D4_ON")
                    {
                        int bitInByteIndex = 4 % 8;
                        uint mask = (uint)(1 << bitInByteIndex);
                        bool isSet = (PORTD & mask) != 0;

                        PORTD |= mask;
                    }
                    if (args[i] == "D4_OFF")
                    {
                        int bitInByteIndex = 4 % 8;
                        uint mask = (uint)(1 << bitInByteIndex);
                        bool isSet = (PORTD & mask) != 0;

                        PORTD &= ~mask;
                    }
                    if (args[i] == "D5_ON")
                    {
                        int bitInByteIndex = 5 % 8;
                        uint mask = (uint)(1 << bitInByteIndex);
                        bool isSet = (PORTD & mask) != 0;

                        PORTD |= mask;
                    }
                    if (args[i] == "D5_OFF")
                    {
                        int bitInByteIndex = 5 % 8;
                        uint mask = (uint)(1 << bitInByteIndex);
                        bool isSet = (PORTD & mask) != 0;

                        PORTD &= ~mask;
                    }
                }

                byte new_T = (byte)T;
                byte new_X = (byte)X;
                byte new_D = (byte)D;
                byte new_A = (byte)A;
                byte new_ADC = (byte)ADC;
                byte new_PORTB = (byte)PORTB;
                byte new_PORTC = (byte)PORTC;
                byte new_PORTD = (byte)PORTD;
                byte new_DRB = (byte)DRB;
                byte new_DRC = (byte)DRC;
                byte new_DRD = (byte)DRD;
                byte new_ResLen = (byte)ResLen;
                byte new_Sync = (byte)Sync;

                byte[] sendbuf = new byte[15] { new_T, new_X, new_D, new_A, new_T, new_A, new_ADC, new_DRB, new_DRC, new_DRD, new_PORTB, new_PORTC, new_PORTD, new_ResLen, new_Sync };

                Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram,
            ProtocolType.Udp);

                IPAddress broadcast = IPAddress.Parse("172.30.2.20");
                //byte[] sendbuf = Encoding.ASCII.GetBytes(txdata);
                IPEndPoint ep = new IPEndPoint(broadcast, 37155);

                s.SendTo(sendbuf, ep);

                /*/
                Console.WriteLine(Convert.ToString(new_T, toBase: 2));
                Console.WriteLine(Convert.ToString(new_PORTB, toBase: 2));
                Console.WriteLine(Convert.ToString(new_PORTC, toBase: 2));
                Console.WriteLine(Convert.ToString(new_PORTD, toBase: 2));
                /*/
            }
            else
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("Arndt Power Unit CLI");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("To 'Turn ON or OFF' a Port provide the port name + underline + desired status");
                Console.WriteLine("For example to turn o ports B1 and D2 provide as arguments 'B1_ON D2_ON'");

            }
        }
    }
}
