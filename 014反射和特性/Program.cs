using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014反射和特性
{
    class Program
    {
        static void Main(string[] args)
        {
            //每一个类对应一个type对象，这个type对象储存了这个类，有哪些方法跟那些数据，那些成员

            MyClass my = new MyClass();//一个类中的数据，是储存在对象中的，但是type对象只储存类的成员
            Type type = my.GetType();//通过对象获取这个对象所属类的Type对象
            Console.WriteLine(type.Name);//获取类的名字
            Console.WriteLine(type.Namespace);//获取所在的命名空间
            Console.WriteLine(type.Assembly);//类的程序集
            type.GetFields();

            Console.ReadKey();
        }
    }
}
