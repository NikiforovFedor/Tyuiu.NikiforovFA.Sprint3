﻿using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.NikiforovFA.Sprint3.Task0.V16.Lib
{
    public class DataService : ISprint3Task0V16
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double res = 1;

            for (int k = startValue; k <= stopValue; k++)
            {
                res *= Math.Pow((value / k), 3);
            }
            return res;
        }
    }
}
