using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029使用StreamReader和StreamWriter读写文件文本
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("TextFile1.txt");

            //while (true)
            //{
            //    string str = reader.ReadLine();
            //    if (str == null) break;
            //    Console.WriteLine(str);
            //}


            //string str = reader.ReadToEnd();//读取到文本的结尾(读取文本中所有的字符)
            //Console.WriteLine(str);

            //while (true)
            //{
            //    int res = reader.Read();
            //    if (res == -1)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine((char)res);
            //    }
            //    char c = (char)reader.Read();//读取

               
            //}
            //reader.Close();
            
            //文本文件写入流
            StreamWriter writer = new StreamWriter("textfile2.txt");

            while (true)
            {
                string message = Console.ReadLine();
                if (message == "q")
                    break;

                //writer.Write(message);//写入一个字符串
                writer.WriteLine(message);//写入一个字符串并换行
            }
            writer.Close();

          //  Console.ReadKey();

        }
    }
}
