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
            Console.Write("Введите число в двоичной системе счисления: ");
            string a = Convert.ToString(Console.ReadLine());
            if(a.Length <= 8)
            {
                int b = Convert.ToInt32(a, 2);
                string c = Convert.ToString(b);
                int d = Convert.ToInt32(c,10);
                Console.Write("Число в десятичной системе счисления: " + d);
            }
            else
            {
                Console.WriteLine("Ввелось больше 8 знаков");
            }
            Console.ReadKey();
        }
    }
}
