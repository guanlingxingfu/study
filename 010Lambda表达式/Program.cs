using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010Lambda表达式
{
    class Program
    {
      

        static void Main(string[] args)
        {
            // Func<int, int, int> plus = Test1;
            //修改成匿名方法
            //Func<int, int, int> plus = delegate (int arg1, int arg2)
            //{
            //    return arg1 + arg2;
            //};
            //lambda表达式用来代替匿名方法，所以一个lambda表达式也是定义了一个方法
            //Func<int, int, int> plus = (arg1, arg2) =>//lambda表达式的参数不需要声明类型
            //  {
            //      return arg1 + arg2;
            //  };
            //Console.WriteLine(plus(90, 60));
            Func<int, int> Test2 = a => a+1;//lambda表示的参数只有一个的时候，可以不加上括号，当函数体的语句只有一句的时候，我们可以不加上大括号，也可以不加return语句
            Func<int, int> Test3 = (a) =>
              {
                  return a + 1;
              };
            Console.WriteLine(Test2(34));

            Console.ReadKey();
        }
    }
}