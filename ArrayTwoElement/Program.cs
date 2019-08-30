using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTwoElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int m = 7;
            Console.WriteLine("So thu 1:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("So thu 2:");
            m = int.Parse(Console.ReadLine());
            int k = m - n;
            int[] a = new int[k+1];
            Console.WriteLine("So phan tu trong mang co:"+a.Length);
            for (int i = 1; i < a.Length; i++)
            {
                a[0] = n;
                a[a.Length-1] = m;
                a[i] = n+i;
            }

            for(int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
                
            }
            Console.ReadKey();
        }
    }
}
