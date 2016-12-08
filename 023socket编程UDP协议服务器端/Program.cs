using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _023socket编程UDP协议服务器端
{
    class Program
    {
        static void Main(string[] args)
        {
            //1创建Socket
            Socket udpServer = new Socket(AddressFamily.InterNetwork,SocketType.Dgram,ProtocolType.Udp);
            //2绑定ip跟端口号
            udpServer.Bind(new IPEndPoint(IPAddress.Parse("149.54.103.2"), 7788));

            //3接收数据
            EndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any,0);
            byte[] data = new byte[1024];
            int length = udpServer.ReceiveFrom(data,ref remoteEndPoint); //这个方法会把数据的来源(ip:port)放到第二个参数上

            string message = Encoding.UTF8.GetString(data, 0, length);
            Console.WriteLine("从ip:"+ (remoteEndPoint as IPEndPoint).Address.ToString()+":"+(remoteEndPoint as IPEndPoint).Port+"收到了数据"+message);

            udpServer.Close();
            Console.ReadKey();

        }


    }

}
