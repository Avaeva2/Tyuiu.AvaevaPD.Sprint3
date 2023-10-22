using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.AvaevaPD.Sprint3.Task0.V20.Lib
{
    public class DataService : ISprint3Task3V20
    {
        public int GetCharCount(string value, char item)
        {
            double charCount = 1;
            int k;
            for (double x = 1; x < 360; x ++)
            {
                charCount = charCount + Math.Cos(x) + Math.Pow( x/8, 3) ;
            }
            return (int)Math.Round(charCount,1);
        }   
    }
}
