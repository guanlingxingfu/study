using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _020线程争用问题
{
    class Program
    {
        static void ChangeState(object o)
        {
            MyThreadObject m = o as MyThreadObject;
            while (true)
            {
            //    lock (m)//向系统申请可不可以 锁定m对象 如何m对象没有被锁定，那么可以，如果m对象被锁定了，那么这个语句会暂停，直到申请到m对象
            //    {
                    m.ChangeState();//在同一时刻只有一个线程在执行这个方法
            //    }//释放m的锁定
            }
        }
        static void Main(string[] args)
        {
            

            MyThreadObject m = new MyThreadObject();
            Thread t = new Thread(ChangeState);
            t.Start(m);

            new Thread(ChangeState).Start(m);

            Console.ReadKey();
        }
    }
}
