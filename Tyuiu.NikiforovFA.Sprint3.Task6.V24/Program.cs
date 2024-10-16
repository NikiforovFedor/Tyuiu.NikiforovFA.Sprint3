using Tyuiu.NikiforovFA.Sprint3.Task6.V24.Lib;
namespace Tyuiu.NikiforovFA.Sprint3.Task6.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Никифоров Ф.А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Никифоров Федор Александрович | ПКТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая вычисляет сумму делитетей  *");
            Console.WriteLine("* чисел из отрезка.                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            int s = 17, e = 26;
            Console.WriteLine("* Начальное значение: " + s);
            Console.WriteLine("* Конечное значение: " + e);
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine(ds.GetSumTheDivisors(s,e));
        }
    }
}
