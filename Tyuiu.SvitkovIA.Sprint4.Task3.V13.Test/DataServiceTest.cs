using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SvitkovIA.Sprint4.Task3.V13.Lib;

namespace Tyuiu.SvitkovIA.Sprint4.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();


            int[,] array = new int[,]
            {
            {4, 7, 4, 2, 1},
            {6, 7, 3, 6, 5},
            {6, 5, 3, 3, 5},
            {4, 4, 6, 4, 7},
            {2, 1, 2, 3, 4}
            };

            int column = 2; 
            int sum = 0;

            for (int row = 0; row < array.GetLength(0); row++)
            {
                sum += array[row, column];
            }

            int res = ds.Calculate( array);
            int wait = 18;

            Assert.AreEqual(wait, res);
        }
    }
}
