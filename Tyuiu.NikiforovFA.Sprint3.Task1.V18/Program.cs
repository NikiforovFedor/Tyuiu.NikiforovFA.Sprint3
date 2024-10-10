using Tyuiu.NikiforovFA.Sprint3.Task1.V18.Lib;
namespace Tyuiu.NikiforovFA.Sprint3.Task1.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Никифоров Ф.А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла while                                              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Никифоров Федор Александрович | ПКТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая вычисляет сумму            *");
            Console.WriteLine("* по формуле.                                                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            int kEnd = 15, kStart = 1;
            Console.WriteLine("* Начальное k = " + kStart);
            Console.WriteLine("* Конечное k = " + kEnd);
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine(ds.GetSumSeries(kStart, kEnd));
        }
    }
}
