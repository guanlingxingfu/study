using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _025udpclient
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建udpclient
            UdpClient udpClient = new UdpClient(new IPEndPoint(IPAddress.Parse("149.54.103.2"), 7788));

            //接收数据
            while (true)
            {
            
            IPEndPoint point = new IPEndPoint(IPAddress.Any, 0);
            byte[] data = udpClient.Receive(ref point); //通过point确定数据来自哪个ip的哪个端口，返回值是一个字节数组，就是我们的数据
            string message = Encoding.UTF8.GetString(data);
            Console.WriteLine("收到了消息:" + message);
        }

        udpClient.Close();
            Console.ReadKey();

        }
    }
}
