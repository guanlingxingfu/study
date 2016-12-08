using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026文件操作察看文件和文件夹信息
{
    class Program
    {
        static void Main(string[] args)
        {
            //相对路径:就是找当前程序所在的路径
          //  FileInfo fileinfo = new FileInfo("TextFile1.txt");
          //绝对路径:加上文件完整的路径名
            //FileInfo fileinfo = new FileInfo(@"F:\study\026文件操作察看文件和文件夹信息\bin\Debug\TextFile1.txt");
            //Console.WriteLine(fileinfo.Exists);
            //Console.WriteLine(fileinfo.Name);//文件名加后缀
            //Console.WriteLine(fileinfo.Directory);//取得文件所在路径
            //Console.WriteLine(fileinfo.Length);//字节大小
            //Console.WriteLine(fileinfo.IsReadOnly);
            //fileinfo.Delete();//删除了输出目录的文件，工程下的文件还是存在的
            //fileinfo.CopyTo("tt.text");

            FileInfo fileinfo = new FileInfo("siki.txt");
            //if (fileinfo.Exists == false) //如果当前文件不存在
            //{
            //    fileinfo.Create();//创建当前文件
            //}

            //fileinfo.MoveTo("siki2.txt");//重命名操作
            //DirectoryInfo dirInfo = new DirectoryInfo(@"F:\study\026文件操作察看文件和文件夹信息\bin\Debug");//察看Debug文件夹的信息

            //Console.WriteLine(dirInfo.Exists);
            //Console.WriteLine(dirInfo.Name);
            //Console.WriteLine(dirInfo.Parent);
            //Console.WriteLine(dirInfo.Root);
            //Console.WriteLine(dirInfo.CreationTime);
            //dirInfo.CreateSubdirectory("siki");
            
            DirectoryInfo dirInfo = new DirectoryInfo("test");
            if(dirInfo.Exists == false)
            {
                dirInfo.Create();
            }


            Console.ReadKey();

        }
    }
}
