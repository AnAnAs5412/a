using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] b = new int[a];
            for (int i = 0; i < b.Length; i++) 
            {
                Console.Write($"Элемент массива {i}: ");
                b[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Ваш массив: ");
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
    