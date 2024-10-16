using Tyuiu.NikiforovFA.Sprint3.Task5.V13.Lib;
namespace Tyuiu.NikiforovFA.Sprint3.Task5.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Никифоров Ф.А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Никифоров Федор Александрович | ПКТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая вычисляет результат по     *");
            Console.WriteLine("* формуле.                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            int s = 1, e = 3, s1 = 1, e1 = 12;
            Console.WriteLine("* Начальное значение 1: " + s);
            Console.WriteLine("* Конечное значение 1: " + e);
            Console.WriteLine("* Начальное значение 2: " + s1);
            Console.WriteLine("* Конечное значение 2: " + e1);
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine(ds.GetSumSumSeries(5, s, e, s1, e1));
        }
    }
}
