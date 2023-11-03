using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string a = Console.ReadLine();
            Console.Write("Сдвиг: ");
            int d = Convert.ToInt32(Console.ReadLine());
            int j;
            char[] chars = a.ToCharArray();
            char[] alf = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь', 'ы', 'ъ', 'э', 'ю', 'я'};
            for (int i = 0; i < chars.Length; i++)
            {
                for (j = 0; j < alf.Length; j++)
                {
                    if (chars[i] == alf[j])
                    {
                        break;
                    }
                }
                if (j < 32)
                {
                    int c = j + d;
                    if (c > 32)
                    {
                        c = c - 33;
                    }
                    chars[i] = alf[c];
                }
            }
            string g = new string(chars);
            Console.WriteLine("Зашифрованная строка: " + g);
            char[] charss = g.ToCharArray();
            for (int i = 0; i < charss.Length; i++)
            {
                for (j = 0; j < alf.Length; j++)
                {
                    if (charss[i] == alf[j])
                    {
                        break;
                    }
                }
                if (j < 32)
                {
                    int c = j - d;
                    if (c > 32)
                    {
                        c = c - 33;
                    }
                    charss[i] = alf[c];
                }
            }
            string f = new string(charss);
            Console.WriteLine("Расшифрованная строка: " + f);
            Console.ReadKey();
        }
    }
}
