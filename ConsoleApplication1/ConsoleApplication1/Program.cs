using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double c=0;
            int i;
            Console.WriteLine("В чем вводиться температура? \n 1) Градусы цельсия \n 2) Градусы Фаренгейта \n 3) Градусы Кельвина");
            i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1: Console.WriteLine("Введите в градусах Цельсия : "); c = Convert.ToInt32(Console.ReadLine()); break;
                case 2: Console.WriteLine("Введите в градусах Фаренгейта : "); c = Convert.ToInt32(Console.ReadLine()); c = (c - 32) * 5 / 9; break;
                case 3: Console.WriteLine("Введите в градусах Кельвина : ");  c = Convert.ToInt32(Console.ReadLine()); c = c - 273.15; break;
                     default: Console.WriteLine("Ошибка ввода"); break;}

            Console.WriteLine("Во что преобразовать? \n 1) Градусы цельсия \n 2) Градусы Фаренгейта \n 3) Градусы Кельвина");
            i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1: Console.WriteLine("Результат : " + c); break;
                case 2: Console.WriteLine("Результат : " + (c * 9 / 5 + 32)); break;
                case 3: Console.WriteLine("Результат : " + (c + 273.15)); break; 
                default: Console.WriteLine("Ошибка");  break;}
            Console.ReadLine();
        }
    }
}
