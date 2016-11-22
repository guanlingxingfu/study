using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001字符串string类
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string s = "www.devsiki.com";*///我们使用string类型去存储字符串类型,字符串需要使用双引号引起来 空格也是一个字符
            //int length = s.Length;

            //if (s == "xxx")
            //{
            //    Console.Write("相同");
            //}
            //else
            //{
            //    Console.Write("不相同");
            //}

            //Console.WriteLine(length);

            //s = "http://" + s;
            //Console.Write(s);
            //char c = s[3];
            //Console.WriteLine(c);

            //for(int i = 0; i < s.Length; i++)
            //{
            //    Console.WriteLine(s[i]);
            //}

            string s = "www.devsiki.com";
            //int res = s.CompareTo("saki");//当两个字符串相等的时候，返回0，当s在字母表的排序考前的时候，返回-1，否则返回1


            //Console.WriteLine(res);
            //string newStr = s.Replace(".","'-___");//只能是指定的字符和字符，或者字符串和字符串
            //Console.WriteLine(s);
            //Console.WriteLine(newStr);

            //string[] strArray = s.Split('.');
            //foreach(var temp in strArray)
            //{
            //    Console.WriteLine(temp);
            //}

            //string str = s.Substring(4, 7);
            //Console.WriteLine(str);

            //string str = s.ToUpper();
            //Console.Write(str);
            //string str = s.Trim();
            //Console.WriteLine(str);


            int index = s.IndexOf("devsiki");//我们可以使用这个方法判断当前字符串是否包含一个子字符串如果
            //包含返回-1，，如果包含会返回第一个的索引
            Console.WriteLine(index);

            Console.ReadKey();




        }
    }
}
