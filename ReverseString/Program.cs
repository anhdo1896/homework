using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            String str="32243";
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mời bạn nhập số: ");
            str = Console.ReadLine();
            String b = "";
            for(int i=str.Length-1; i >=0; i--)
            {
                b += str[i];
            }
            Console.WriteLine(b);
            Console.ReadKey();

        }
    }
}
