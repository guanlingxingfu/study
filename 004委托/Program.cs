using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004委托
{
    class Program
    {

        private delegate string GetAString();//定义了一个委托类型,这个委托类型的名字叫做GetAString
        static void Main(string[] args)
        {
            //int x = 40;
            ////string s = x.ToString();//tostring 方法用来把数据转换成字符串
            ////Console.WriteLine(s);
            ////使用委托类型，创建实例
            ////GetAString a = new GetAString(x.ToString);//a指向了x中的tostring方法
            //GetAString a = x.ToString;

            ////string s = a();//通过委托实例去调用x中的tostring方法

            //string s = a.Invoke();//通过invoke方法调用a所引用的方法
            //Console.WriteLine(s);

            //Console.ReadKey();


            //实例2 使用委托类型作为方法的参数
            PrintString method = Method1;
            printStr(method);
            method = Method2;
            printStr(method);
            Console.ReadKey();

        }
        private delegate void PrintString();


        static void printStr(PrintString print)
        {
            print();
        }

        static void Method1()
        {
            Console.WriteLine("method1");
        }
        static void Method2()
        {
            Console.WriteLine("method2");
        }
    }
}
