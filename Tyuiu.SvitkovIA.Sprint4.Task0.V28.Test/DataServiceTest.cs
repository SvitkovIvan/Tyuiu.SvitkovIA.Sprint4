using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SvitkovIA.Sprint4.Task0.V28.Lib;

namespace Tyuiu.SvitkovIA.Sprint4.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultEvenArrEl1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
            int res = ds.GetMultEvenArrEl(numsArray);
            int numsWaitValue = 9216;
            Assert.AreEqual(numsWaitValue, res);
        }
    }
}
