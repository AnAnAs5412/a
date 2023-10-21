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
            int[] a = new int[5];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("Введите число: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadKey();
        }
    }
}
