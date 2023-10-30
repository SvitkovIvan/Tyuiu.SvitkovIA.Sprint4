using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SvitkovIA.Sprint4.Task0.V28.Lib;

namespace Tyuiu.SvitkovIA.Sprint4.Task0.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Свитков И. А. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант 28                                                              *");
            Console.WriteLine("* Выполнил: Свитков Иван Андреевич | АСОиУб-23-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статистическими значениями, подсчитать произведение четных элементов.   *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int[] numsArray = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
            int product = 1;
            int res  = ds.GetMultEvenArrEl(numsArray);

            Console.Write("Четные элементы массива: ");

            foreach (int number in numsArray)
            {
                if (number % 2 == 0)
                {
                    Console.Write(number + " ");
                }
            }

            foreach (int num in numsArray)
            {
                if (num % 2 == 0)
                {
                    product *= num;
                }
            }
            Console.WriteLine("Произведение четных элементов в массиве: " + product);

            Console.WriteLine();
            Console.ReadKey();

            

        }
    }
}