using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] b = new int[a];
            Console.WriteLine("Введите элементы массива: ");
            int c = a - 1;
            int d = 0;
            for (int i = 0; i < a; i++)
            {
                if (i % 2 == 0)
                {
                    b[c] = b[i];
                    b[c] = Convert.ToInt32(Console.ReadLine());
                    c--;
                }
                else
                {
                    b[d] = Convert.ToInt32(Console.ReadLine());
                    d++;
                }
            }
            Console.Write("Массив в правильном порядке: ");
            for (int i = 0; i < a; i++)
            {
                Console.Write(b[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
