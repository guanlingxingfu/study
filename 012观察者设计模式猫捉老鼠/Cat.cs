using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012观察者设计模式猫捉老鼠
{
    class Cat
    {
        private string name;
        private string color;

        public Cat(string name,string color)
        {
            this.name = name;
            this.color = color;
        }
        //猫的状态发生改变
        public void CatComing(Mouse mouse1,Mouse mouse2)
        {
            Console.WriteLine(color + "的猫" + name+"过来了，喵喵喵");

            mouse1.RunAway();
            mouse2.RunAway();
        }
    }
}
