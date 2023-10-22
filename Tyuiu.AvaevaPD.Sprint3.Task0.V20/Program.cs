using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AvaevaPD.Sprint3.Task0.V20.Lib;
namespace Tyuiu.AvaevaPD.Sprint3.Task0.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Авaева П. Д. | ИСПБ-23-1";
            // Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнила: Аваева Полина Дмитриевна | ИСПБ-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for,                                  *");
            Console.WriteLine("* которая вычисляет произведение ряда по формуле, при X = 1               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            string value = 1;
            char item = 14;

            
            Console.WriteLine("Старт шага = " +  value);
            Console.WriteLine("Конец шага = " + item);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                             *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма ряда = " + ds.GetCharCount(value,item);
        }
    }
}
