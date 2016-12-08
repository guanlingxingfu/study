using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _027使用File读写文件
{
    class Program
    {
        static void Main(string[] args)
        {
            //读取文件，把每一个行文本读取成一个字符串，最后组成一个字符串的数组
            //string[] strArray = File.ReadAllLines("TextFile1.txt");

            //foreach (var s in strArray)
            //{
            //    Console.WriteLine(s);   
            //}

            //string s = File.ReadAllText("TextFile1.txt");//把所有文本读取成一个字符串
            //Console.WriteLine(s);

            


            //byte[] byteArray = File.ReadAllBytes("3.LINQ.png");
            //foreach (var b in byteArray)
            //{
            //    Console.Write(b);
            //}

            //File.WriteAllText("textfile2.txt","你好中国 不好");


            //File.WriteAllLines("textfile3.txt",new string[] {"fdsfdsf","fdsf2131","范德萨发的说法"});
            byte[] data = File.ReadAllBytes("3.LINQ.png");

            File.WriteAllBytes("4.png",data);

            Console.ReadKey();

        }
    }
}
