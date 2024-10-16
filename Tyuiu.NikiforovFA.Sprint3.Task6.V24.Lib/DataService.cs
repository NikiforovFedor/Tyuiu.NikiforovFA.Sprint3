using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.NikiforovFA.Sprint3.Task6.V24.Lib
{
    public class DataService : ISprint3Task6V24
    {
        public static int del(int x)
        {
            int k = 0;
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    k++;
                }
            }
            return k;
        }
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int res = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                res += del(i);
            }
            return res;
        }

    }
}
