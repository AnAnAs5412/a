using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string a = Console.ReadLine();
            Console.Write("Введите символ: ");
            char b = Convert.ToChar(Console.ReadLine());
            int d = 0;
            foreach(char c in a)
            {
                if (c == b)
                {
                    d++;
                }
            }
            Console.WriteLine($"Количество символов {b} в строке {a}: {d}");
            string e = b.ToString().ToUpper();
            a = a.Replace(b.ToString(), e);
            Console.WriteLine("Строка: " + a);
            Console.ReadKey();
        }
    }
}
