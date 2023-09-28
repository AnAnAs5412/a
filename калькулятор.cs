using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Действие: ");
            string a = Convert.ToString(Console.ReadLine());
            switch (a)
            {
                case "сложение":
                    Console.Write("Введите первое слагаемое: ");
                    double sl1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите второе слагаемое: ");
                    double sl2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"Сумма = {sl1+sl2}");
                    break;
                case "вычитание":
                    Console.Write("Введите уменьшаемое: ");
                    double v1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите вычитаемое: ");
                    double v2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"Разность = {v1 - v2}");
                    break;
                case "деление":
                    Console.Write("Введите делимое: ");
                    double d1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите делитель: ");
                    double d2 = Convert.ToInt32(Console.ReadLine());
                    if (d2 == 0)
                    {
                        Console.WriteLine("На 0 делить нельзя");
                    }
                    else
                    {
                        Console.Write($"Частное = {d1/d2}");
                    }
                    break;
                case "умножение":
                    Console.Write("Введите первый множитель: ");
                    double m1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите второй множитель: ");
                    double m2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"Произведение = {m1*m2}");
                    break;
                case "степень":
                    Console.Write("Введите число: ");
                    double ch = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите степень: ");
                    double s = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"{ch} в {s} степени = {Math.Pow(ch,s)}");
                    break;
                case "корень":
                    Console.Write("Введите число: ");
                    double k = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"Корень из {k} = {Math.Sqrt(k)}");
                    break;
                case "остаток":
                    Console.Write("Введите делимое: ");
                    double del1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите делитель: ");
                    double del2 = Convert.ToInt32(Console.ReadLine());
                    if (del2 == 0)
                    {
                        Console.WriteLine("На 0 делить нельзя");
                    }
                    else
                    {
                        Console.Write($"Остаток от деления = {del1 % del2}");
                    }
                    break;
                case "квадратное уравнение":
                    Console.Write("Введите a: ");
                    double d = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите b: ");
                    double b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите c: ");
                    double c = Convert.ToInt32(Console.ReadLine());
                    double D = Math.Sqrt(Math.Pow(b, 2) - 4 * d * c);
                    if (D >= 0)
                    {
                        Console.WriteLine($"x1 = {(-b + D) / (2 * d)}");
                        Console.WriteLine($"x2 = {(-b - D) / (2 * d)}");
                    }
                    else
                    {
                        Console.WriteLine("Нет решений");
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
