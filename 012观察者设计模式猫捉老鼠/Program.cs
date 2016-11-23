using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012观察者设计模式猫捉老鼠
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("加菲猫","黄色");
            Mouse mouse1 = new Mouse("米奇", "黑色");
            Mouse mouse2 = new Mouse("唐老鸭", "红色");
            Mouse mouse3 = new Mouse("xxx老鼠", "黑色");

            cat.CatComing(mouse1,mouse2);//猫的状态发生改变

            Console.ReadKey();

        }
    }
}
