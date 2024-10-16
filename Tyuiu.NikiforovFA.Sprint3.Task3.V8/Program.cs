using Tyuiu.NikiforovFA.Sprint3.Task3.V8.Lib;
namespace Tyuiu.NikiforovFA.Sprint3.Task3.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Никифоров Ф.А. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Никифоров Федор Александрович | ПКТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая удаляет буквы и знаки      *");
            Console.WriteLine("* из строки, а после возвращает число.                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            string s = "vc, x12fc fc!e";
            Console.WriteLine("* Строка: " + s);
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine(ds.ConvertStringToInt(s));

        }
    }
}
