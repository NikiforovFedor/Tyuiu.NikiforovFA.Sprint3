﻿using Tyuiu.NikiforovFA.Sprint3.Task7.V29.Lib;
namespace Tyuiu.NikiforovFA.Sprint3.Task7.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Никифоров Ф.А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Никифоров Федор Александрович | ПКТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая вычисляет результат по     *");
            Console.WriteLine("* формуле.                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            int s = -5, e = 5;
            Console.WriteLine("* Начальное значение: " + s);
            Console.WriteLine("* Конечное значение: " + e);
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine(ds.GetMassFunction(s, e));


        }
    }
}
