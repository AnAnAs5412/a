using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[10, 10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int d = 0; d < 10; d++)
                {
                    a[i,d] = random.Next(1,10);
                    Console.Write(a[i, d] + "\t");
                }
                Console.WriteLine();
            }
            int[] sum = new int[10];
            int[] pr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                sum[i] = 0;
                for (int d = 0; d < 10; d++)
                {
                    sum[i] += a[i,d];
                    if (i == 0)
                    {
                        pr[d] = 1;
                    }
                    pr[d] *= a[i, d];
                }
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Сумма элементов строки {i + 1}: {sum[i]} ");
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Произведение элементов столбца {i + 1}: {pr[i]} ");
            }
            int maxs = sum[0];
            int maxp = pr[0];
            foreach (int s in sum)
            {
                if (s > maxs)
                {
                    maxs = s;
                }
            }
            foreach (int p in pr)
            {
                if (p > maxp)
                {
                    maxp = p;
                }
            }
            Console.WriteLine("Наибольшая сумма элементов строки: " + maxs);
            Console.WriteLine("Наибольшее произведение элементов столбца: " + maxp);
            Console.ReadKey();
        }
    }
}
