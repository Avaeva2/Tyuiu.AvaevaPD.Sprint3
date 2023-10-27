﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AvaevaPD.Sprint3.Task5.V5.Lib
{
    public class DataService : ISprint3Task5V5
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumSeries = 0;
            int i, j;
            for (i = startValue1; i <= stopValue1; i++)
            {
                for (j = startValue2; j <= stopValue1; j++)
                {
                    sumSeries = sumSeries + ((x / Math.Sin(j)));
                }
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
