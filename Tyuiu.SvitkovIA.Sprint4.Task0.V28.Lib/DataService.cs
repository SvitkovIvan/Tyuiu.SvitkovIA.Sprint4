using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SvitkovIA.Sprint4.Task0.V28.Lib
{
    public class DataService : ISprint4Task0V28
    {
        public int GetMultEvenArrEl(int[] array)
        {
            int[] numbers = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
            int product = 1;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    product *= number;
                }
            }   return product;
        }
    }
}
