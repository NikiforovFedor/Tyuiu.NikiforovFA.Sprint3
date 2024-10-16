using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.NikiforovFA.Sprint3.Task2.V8.Lib
{
    public class DataService : ISprint3Task2V8
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            int k = 1;
            double res = 1;
            do
            {
                res *= (1 / ((Math.Cos(5) + 1) * (Math.Cos(5) + 1)));
                k++;
            } while (k < stopValue + 1);
            return Math.Round(res,3);
        }
    }
}
