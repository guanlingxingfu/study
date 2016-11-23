using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012观察者设计模式猫捉老鼠
{


    class Mouse
    {
        private string name;
        private string color;
        public Mouse(string name,string color)
        {
            this.name = name;
            this.color = color;
        }
        public void RunAway()
        {
            Console.WriteLine(color+"的老鼠"+name+"说:老猫来，赶紧跑");
        }
    }
}
