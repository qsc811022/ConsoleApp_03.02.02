using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_03._02._02
{
    class Program
    {
        static void Main(string[] args)
        {

            //string sentence = "商品     數量     單價";
            //string sentence2 = "印表機     1     3,500";
            //Console.WriteLine(sentence);
            //Console.WriteLine(sentence2);
            //string sentence = "商品\t數量\t單價";
            //string sentence2 = "印表機\t1\t3,500";
            //Console.WriteLine(sentence);
            //Console.WriteLine(sentence2);
            string path = @"d:\mydocument\file.txt"; // 字串裡有反斜線, 是錯的寫法
            string path2 = "d:\\mydocument\\file.txt"; // 加上逸出字元才是正確寫法
            Console.WriteLine(path);
            Console.WriteLine(path2);


        }
    }
}
