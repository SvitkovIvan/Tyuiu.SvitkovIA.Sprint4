using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SvitkovIA.Sprint4.Task6.V11.Lib;

namespace Tyuiu.SvitkovIA.Sprint4.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var animal = new string[] { "Кошка", "Собака", "Слон", "Жираф", "Бегемот", "Игуана", "Ягуар" };
            int res = ds.Calculate(animal);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
