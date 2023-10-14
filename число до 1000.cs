using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число до 1000: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a <= 1000)
            {
                for (int i = 0; i <= a; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Введено число больше 1000");
            }
            Console.ReadKey();
        }
    }
}
