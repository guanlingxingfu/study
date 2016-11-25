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
        //public void CatComing(Mouse mouse1,Mouse mouse2)
        //public void CatComing(Mouse mouse1, Mouse mouse2, Mouse mouse3)
        public void CatComing()
        {
            Console.WriteLine(color + "的猫" + name+"过来了，喵喵喵");

            //mouse1.RunAway();
            //mouse2.RunAway();
            //mouse3.RunAway();
            if(catCome!=null)
            catCome();
        }
        public Action catCome;//声明一个事件,发布了一个消息,特殊签名的委托
    }
}
