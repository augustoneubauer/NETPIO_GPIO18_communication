using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;

public class UDPListener
{
   
    private static void StartListener()
    {
        UdpClient udpServer = new UdpClient(37155);

        try
        {
            while (true)
            {
                var remoteEP = new IPEndPoint(IPAddress.Any, 37155);
                var data = udpServer.Receive(ref remoteEP); // listen on port 11000
                Console.Write("receive data from " + remoteEP.ToString());
                udpServer.Send(new byte[] { 1 }, 1, remoteEP); // reply back
            }
        }

        catch (SocketException e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            udpServer.Close();
        }



    }
    public static void Main()
    {
        StartListener();
    }
}
