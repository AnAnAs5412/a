using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string c = Console.ReadLine();
            string d = ChangeCase(c);
            Console.WriteLine("Результат: " + d);
            Console.ReadKey();
        }
        static string ChangeCase(string a)
        {
            string b = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0)
                {
                    b += char.ToUpper(a[i]);
                }
                else
                {
                    b += char.ToLower(a[i]);
                }
            }
            return b;
        }
    }
}
