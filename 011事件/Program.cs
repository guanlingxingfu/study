using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011事件
{
    class Program
    {
        public delegate void MyDelegate();


        public event MyDelegate mydelegate;//使命一个委托类型的变量，作为类的成员

        static void Main(string[] args)
        {

            Program p = new Program();
            p.mydelegate = Test1;
            p.mydelegate();
            Console.ReadKey();
        }

        static void Test1()
        {
            Console.WriteLine("test1");
        }
    }
}
