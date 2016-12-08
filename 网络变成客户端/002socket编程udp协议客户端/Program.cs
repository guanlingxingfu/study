using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _002socket编程udp协议客户端
{
    class Program
    {
        static void Main(string[] args)
        {
            //1创建socket

            Socket udpClient = new Socket(AddressFamily.InterNetwork,SocketType.Dgram,ProtocolType.Udp);


            while (true)
            {
                //2发送数据

                EndPoint serverPoint = new IPEndPoint(IPAddress.Parse("149.54.103.2"), 7788);
                string message = Console.ReadLine();
                byte[] data = Encoding.UTF8.GetBytes(message);
                udpClient.SendTo(data, serverPoint);

            }


            udpClient.Close();
            Console.ReadKey();
        }
    }
}
