﻿using System;
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

            Mouse mouse1 = new Mouse("米奇", "黑色",cat);
            //cat.catCome += mouse1.RunAway;
            Mouse mouse2 = new Mouse("唐老鸭", "红色",cat);
           // cat.catCome += mouse2.RunAway;
            Mouse mouse3 = new Mouse("xxx老鼠", "黑色",cat);
           // cat.catCome += mouse3.RunAway;

            /*   cat.CatComing(mouse1,mouse2,mouse3);*///猫的状态发生改变，在cat中调用了观察者的方法，当观察者发生改变的时候，需要同时修改被观察者的代码
            cat.CatComing();
            cat.catCome();
            Console.ReadKey();

        }
    }
}
