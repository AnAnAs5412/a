using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace разбитие_строки_по_символам
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите символ: ");
            string a = Console.ReadLine();
            Console.Write("Введите строку: ");
            string b = Console.ReadLine();
            b = b.Replace(a, " ");
            Console.Write("Строка: " + b);
            Console.ReadKey();
        }
    }
}
