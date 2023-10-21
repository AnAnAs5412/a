using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            while (a <= i)
            {
                Console.WriteLine(a);
                a *= 2; ;
            }
            Console.ReadKey();
        }
    }
}
