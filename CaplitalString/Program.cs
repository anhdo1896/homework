using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaplitalString
{
    class Program
    {
        static void Main(string[] args)
        {
            String str= "toi la do ngoc anh";
            Console.WriteLine("Nhap chuoi vao:");
            str = Console.ReadLine();
            String[] a = str.Split(' ');
            char b ;
            String c="" ;
            char d ;
            for(int i = 0; i < a.Length; i++)
            {
                b = Char.ToUpper(a[i][0]);
                
                c += b + a[i].Substring(1) + " ";
            }
            Console.WriteLine(c);
            Console.ReadKey();

        }
    }
}
