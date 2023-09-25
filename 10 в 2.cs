using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число в десятичной системе счисления: ");
            int a = Convert.ToInt32(Console.ReadLine());
            string b = Convert.ToString(a, 2);
            Console.Write("Число в двоичной системе счисления: " + b);
            Console.ReadKey();
        }
    }
}
