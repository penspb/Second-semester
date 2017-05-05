using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1._5;

namespace TestForSolutionOnePointFive
{
    [TestClass]
    public class TestForOnePointFive
    {

        [TestMethod]
        public void TestForSwap()
        {
            int[,] array = { { 1, 10, 4 }, { -4, -2, 3 }, { 7, -1, 4 } };
            Program.LineSort(array);

            Assert.AreEqual(3, array[1, 1]);
        }

        [TestMethod]
        public void SimpleTestForSort()
        {
            int[,] array = { { 3, 2, 1 }, { 2, 1, 0 }, { 1, 0, -1 } };
            Program.LineSort(array);

            Assert.AreEqual(1, array[0, 0]);
        }

        [TestMethod]
        public void TestForSort0()
        {
            int[,] array = { { 1, 10, 4 }, { -4, -2, 3 }, { 7, -1, 4 } };
            Program.LineSort(array);

            for (int i = 0; i < array.GetLength(1) - 1; i++)
            {
                if (array[0, i + 1] < array[0, i])
                {
                    Assert.Fail();
                }
            }
        }

        [TestMethod]
        public void TestForSort1()
        {
            int[,] array = { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
            Program.LineSort(array);

            for (int i = 0; i < array.GetLength(1) - 1; i++)
            {
                if (array[0, i + 1] < array[0, i])
                {
                    Assert.Fail();
                }
            }
        }

        [TestMethod]
        public void TestForSort2()
        {
            int[,] array = { { 1 } };
            Program.LineSort(array);

            for (int i = 0; i < array.GetLength(1) - 1; i++)
            {
                if (array[0, i + 1] < array[0, i])
                {
                    Assert.Fail();
                }
            }
        }

        [TestMethod]
        public void TestForSort3()
        {
            int[,] array = { { 1, 3, 2 } };
            Program.LineSort(array);

            for (int i = 0; i < array.GetLength(1) - 1; i++)
            {
                if (array[0, i + 1] < array[0, i])
                {
                    Assert.Fail();
                }
            }
        }
    }
}
