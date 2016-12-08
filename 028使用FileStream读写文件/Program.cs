using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028使用FileStream读写文件
{
    class Program
    {
        static void Main(string[] args)
        {
            //1,创建文件流，用来操作文件
           //FileStream stream = new FileStream("TextFile1.txt",FileMode.Open);

           // //2.读取或者写入数据
           // byte[] data = new byte[1024];//数据容器
           // //1byte = 1字节 1024 byte = 1KB 1024KB = 1MB 1024MB = 1GB

           // while (true)
           // {
           //     int length = stream.Read(data, 0, data.Length);
           //     if (length == 0)
           //     {
           //         Console.WriteLine("读取结束");
           //         break;
           //     }
           //     for (int i = 0; i < length; i++)
           //     {
           //         Console.Write(data[i] + " ");
           //     }
           // }

            //使用filestream完成文件复制
            FileStream readStream = new FileStream("IMG_1023.JPG",FileMode.Open);

            FileStream writeStream = new FileStream("副本.JPG",FileMode.Create);

            byte[]data = new byte[1024];
            
            while (true)
            {
               int length = readStream.Read(data, 0, data.Length);
                if (length == 0)
                {
                    Console.WriteLine("读取结束");
                    break;
                }
                else
                {
                    writeStream.Write(data,0,length);
                }


            }
            writeStream.Close();
            readStream.Close();

            Console.ReadKey();

        }
    }
}
