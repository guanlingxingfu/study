using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _003正则表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "I am blue cat";
            ////string res = Regex.Replace(s, "^","开始:");//搜索字符串符合正则表达式的情况，然后把所有符合的位置，替换成后面的字符串
            ////Console.WriteLine(res);

            //string res = Regex.Replace(s, "$", "结束");
            //Console.WriteLine(res);

            //string s = Console.ReadLine();
            //bool isMatch = true;//默认标志位，表示S是一个合法密码（全部是数字）
            //for(int i = 0; i < s.Length; i++)
            //{
            //    if(s[i] < '0'||s[i]>'9')//当前字符如果不是数字字符
            //    {
            //        isMatch = false;
            //        break;
            //    }
            //}
            //if(isMatch)
            //{
            //    Console.WriteLine("是一个合法的密码");
            //}
            //else
            //{
            //    Console.WriteLine("不是一个合法的密码");
            //}

            //string pattern = @"^\d*$";//正则表达式
            //bool isMatch = Regex.IsMatch(s, pattern);
            //string pattern1 = @"a*";//任意有a的字符串都是成立的

            //Console.WriteLine(isMatch);

            //string pattern = @"^\W*$";

            //string str = "I am a cat";
            //string pattern = @"[^ahou]";
            //string s = Regex.Replace(str, pattern, "*");
            //Console.WriteLine(s);

            //string qq = "234234";
            //string qq1 = "1234234234234234";
            //string qq2 = "2342423534543";

            //string pattern = @"^\d{5,12}$";

            //Console.WriteLine(Regex.IsMatch(qq, pattern));
            //Console.WriteLine(Regex.IsMatch(qq1, pattern));
            //Console.WriteLine(Regex.IsMatch(qq2, pattern));

            //string s = "34((^&^$&fdgfds反对书法";
            //string pattern = @"\d|[a-z]";
            //MatchCollection col = Regex.Matches(s, pattern);

            //foreach(Match match in col)
            //{
            //    Console.WriteLine(match);//调用tostring方法，会输出match所匹配的方法
            //}

            //string s = "zhangsan:fe,fsdfsdf.fdsf";
            //string pattern = @"[:;,.]";
            //string[] resArray = Regex.Split(s, pattern);
            //foreach(var s1 in resArray)
            //{
            //    Console.WriteLine(s1);
            //}

            string inputStr = Console.ReadLine();
            string strGroup2 = @"(ab\w{2}){2}";
            Console.WriteLine("分组字符重复2次替换为5555，结果为：" + Regex.Replace(inputStr, strGroup2, "55555"));


            Console.ReadKey();
        }
    }
}
