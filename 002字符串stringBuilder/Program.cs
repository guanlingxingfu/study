using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002字符串stringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {//1
            //StringBuilder sb = new StringBuilder("www.devsiki.com");//利用构造函数创建构造函数
            //2
            //StringBuilder sb = new StringBuilder(20);//初始一个空的stringbuilder对象，占有20个字符的大小
            ////3
            StringBuilder sb = new StringBuilder("www.devsiki.com", 100);

            //sb.Append("/xxx.html");
            //当我们需要对一个字符串进行频繁的删除添加操作的时候，使用stringbuider的效率比较高
            //Console.WriteLine(sb.ToString());

            //string s = "www.devsiki.com";
            //s = s + "/xxx.html";
            //Console.WriteLine(s);

            //sb.Insert(0, "http://");
            //sb.Remove(0, 3);
            //sb.Replace(".", "-");
            //sb.ToString();

            Console.WriteLine(sb);

            Console.ReadKey();

        }
    }
}
