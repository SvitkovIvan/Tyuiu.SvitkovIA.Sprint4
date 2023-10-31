using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SvitkovIA.Sprint4.Task1.V9.Lib
{
    public class DataService : ISprint4Task1V9
    {
        public int Calculate(int[] array)
        {
            int product = 1;

            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    product *= num;
                }
            }

            return product;
        }
    }
}
