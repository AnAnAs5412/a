using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество чисел: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 0;
            Console.WriteLine(b);
            int c = 1;
            Console.WriteLine(c);
            int e = a - 2;
            while (e > 0)
            {
                int d = b + c;
                Console.WriteLine(d);
                b = c;
                c = d;
                e--;
            }
            Console.ReadKey();
        }
    }
}
