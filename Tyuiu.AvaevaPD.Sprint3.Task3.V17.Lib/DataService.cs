﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AvaevaPD.Sprint3.Task3.V17.Lib
{
    public class DataService : ISprint3Task3V17
    {
        public int ConvertStringToInt(string value)
        {
            int ToInt = 0;
            foreach (char c in value)
            {
                if (char.IsDigit(c))
                {
                    ToInt++;
                }

            }
            return ToInt;
        }
    }
}
