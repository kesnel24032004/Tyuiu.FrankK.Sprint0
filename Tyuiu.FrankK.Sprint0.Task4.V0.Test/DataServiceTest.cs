﻿using Tyuiu.FrankK.Sprint0.Task4.V0.Lib;
namespace Tyuiu.FrankK.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        [TestMethod]
        public void CheckSubstractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }
        [TestMethod]
        public void CheckMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }
        [TestMethod]
        public void CheckDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}
