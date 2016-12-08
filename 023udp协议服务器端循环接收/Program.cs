using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _023udp协议服务器端循环接收
{
    class Program
    {
        //静态socket
        private static Socket udpServer;
        static void Main(string[] args)

        { 
            
           
            //1创建Socket
            udpServer = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //2绑定ip跟端口号
            udpServer.Bind(new IPEndPoint(IPAddress.Parse("149.54.103.2"), 7788));

            //3接收数据
           
            new Thread(ReciveMessage){IsBackground = true}.Start();//设置为后台线程,应用程序关闭就不用继续运行了


            //udpServer.Close();//服务器端关闭就没法接收数据了
            Console.ReadKey();
        }

        static void ReciveMessage()
        {
            while (true)
            {
                
                EndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
                byte[] data = new byte[1024];
                int length = udpServer.ReceiveFrom(data, ref remoteEndPoint); //这个方法会把数据的来源(ip:port)放到第二个参数上

                string message = Encoding.UTF8.GetString(data, 0, length);
                Console.WriteLine("从ip:" + (remoteEndPoint as IPEndPoint).Address.ToString() + ":" + (remoteEndPoint as IPEndPoint).Port + "收到了数据" + message);
            }
           
        }
    }
}
