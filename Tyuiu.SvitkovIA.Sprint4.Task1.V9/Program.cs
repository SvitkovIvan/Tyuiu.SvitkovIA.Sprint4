using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SvitkovIA.Sprint4.Task1.V9.Lib;

namespace Tyuiu.SvitkovIA.Sprint4.Task1.V9
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
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант 9                                                               *");
            Console.WriteLine("* Выполнил: Свитков Иван Андреевич | АСОиУб-23-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов заполненный         *");
            Console.WriteLine("* значениями в диапазоне от 3до8.Подсчитать произведение четных элементов *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[13];
        int product = 1;

        Console.WriteLine("Введите 13 чисел от 3 до 8:");

        for (int i = 0; i < array.Length; i++)
        {
            int input;
            bool isValidInput = int.TryParse(Console.ReadLine(), out input);

            if (isValidInput && input >= 3 && input <= 8)
            {
                array[i] = input;

                if (input % 2 == 0)
                {
                    product *= input;
                }
            }
        }

            Console.WriteLine("Произведение четных элементов массива: " + product);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(array);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}

            
                