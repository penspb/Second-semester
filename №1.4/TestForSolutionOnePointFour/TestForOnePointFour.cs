using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1._4;

namespace TestForSolutionOnePointFour
{
    [TestClass]
    public class TestForOnePointFour
    {
        [TestMethod]
        [ExpectedException(typeof(EvenNumberException))]
        public void CheckingException()
        {
            int number = 2;
            int[,] firstArray = { { 1, 2 }, { 3, 4 } };
            int[] lastArray = new int[number * number];

            Program.SpiralLine(firstArray, lastArray);
        }

        [TestMethod]
        public void Test1()
        {
            int number = 1;
            int[,] firstArray = { { 5 } };
            int[] lastArray = new int[number * number];

            Program.SpiralLine(firstArray, lastArray);

            Assert.AreEqual(5, lastArray[0]);
        }

        [TestMethod]
        public void Test2()
        {
            int number = 5;
            int[,] firstArray = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            int[] lastArray = new int[number * number];

            Program.SpiralLine(firstArray, lastArray);

            Assert.AreEqual(3, lastArray[10]);
        }
    }
}
