using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SvitkovIA.Sprint4.Task4.V20.Lib;

namespace Tyuiu.SvitkovIA.Sprint4.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { {4, 5, 5, 6, 4},
                                          {7, 8, 4, 7, 5},
                                          {5, 6, 5, 8, 5},
                                          {7, 5, 8, 7, 8},
                                          {4, 7, 7, 8, 8} };

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (mas2[i, j] % 2 == 0)
                    {
                        mas2[i, j] = 1;
                    }
                }
            }
        }
    }
}
