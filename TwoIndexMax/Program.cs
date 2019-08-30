using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoIndexMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[20];
            int n;
            Console.WriteLine("So phan tu trong mang:");
            n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                
            }
            int max=a[0];
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }
            a = a.Where(val => val != max).ToArray();
            int max2 = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max2)
                    max2 = a[i];
            }
            Console.WriteLine("Phan max 2 : "+ max2);
            Console.ReadKey();
        }
    }
}
