using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _016线程委托方式发起线程
{
    class Program
    {
        //一般我们会为比较耗时的操作开启单独的线程去执行，比如下载操作
        static int Test(int i,string str)
        {
            Console.WriteLine("test"+i+str);
            Thread.Sleep(100);//当让亲线程休眠(暂停线程的执行) 单位是ms
            return 100;
        }
        
        static void Main(string[] args)
        {//在main线程中执行一个线程里面语句的执行，是从上到下的
            //下载文件code

            //移动文件code


            //Func<int,string,int> a = Test;
            //IAsyncResult ar = a.BeginInvoke(100,"siki",null,null);//开启一个新的线程去执行a所引用的方法
             //可以取得当前线程的状态
            //可以认为线程是同时执行的，也叫异步执行
            Console.WriteLine("main");
            //while (ar.IsCompleted == false)//如果当前线程没有执行完毕
            //{
            //    Console.Write(".");
            //    Thread.Sleep(10);//控制线程的检测频率
            //}
            //int res = a.EndInvoke(ar);//取得异步线程的返回值
            //Console.WriteLine(res);

            //bool isEnd = ar.AsyncWaitHandle.WaitOne(1000);//1000毫秒表示超时时间，如果等待线程还没有结束的话，那么这个方法会返回false，如果在1000毫秒内线程结束了，就会返回true

            //if (isEnd)
            //{
            //    int res = a.EndInvoke(ar);
            //    Console.WriteLine(res);
            //}


            //通过回调 检测线程结束
            Func<int, string, int> a = Test;
            //倒数第二个参数是一个委托类型的参数，表示回调函数，就是当线程结束的时候会调用这个委托指向的方法
            //IAsyncResult ar = a.BeginInvoke(100, "siki",OnCallBack, a);//开启一个新的线程去执行a所引用的方法
            //倒数第一个参数用来给回调函数传递数据
            a.BeginInvoke(100, "siki", ar =>
            {
                int res = a.EndInvoke(ar);
                Console.WriteLine(res + "在lambda表达式中取得");
            }, null);


            Console.ReadKey();

        }

        static void OnCallBack(IAsyncResult ar)
        {
           Func<int,string,int> a = ar.AsyncState as Func<int, string, int>;
            int res = a.EndInvoke(ar);
            Console.WriteLine(res+"在回调函数中取得结果");
        }
    }
}
