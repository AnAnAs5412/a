﻿using System;
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

            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int t = Convert.ToInt32(Console.ReadLine());
            if (n < 24 && n >= 0 && m < 60 && n >= 0 && t < Math.Pow(10, 9) && t >= 30)
            {
                int c = n + t / 60;
                while (c >= 24)
                {
                    c = c % 24;
                }
                int d = m + t % 60;
                while (d >= 60)
                {
                    d = d - 60;
                    c = c + 1;
                }
                while (d < 10)
                {
                    Console.WriteLine($"Время доставки {c}:0{d}");
                    Console.ReadKey();
                }
                Console.WriteLine($"Время доставки {c}:{d}");
            }
            else
            {
                Console.Write("Ошибка");
            }
            Console.ReadKey();

        }
    }
}