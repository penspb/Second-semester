using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1._3;

namespace TestForSolutionOnePointThree
{
    [TestClass]
    public class TestForOnePointThree
    {
        [TestMethod]
        public void TestSort0()
        {
            int[] array = { 1, 10, -1, 4, -4, 6 };
            Program.BubbleSort(array);

            bool check = true;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    check = false;
                }
            }

            Assert.IsTrue(check);
        }

        [TestMethod]
        public void TestSort1()
        {
            int[] array = { 5, 4, 3, 2, 1, 0, -1, 6 };

            Program.BubbleSort(array);

            Assert.AreEqual(5, array[6]);
        }

        [TestMethod]
        public void TestSort3()
        {
            int[] array = { 1, 2, 3, 4, 8, 14, 16 };
            Program.BubbleSort(array);

            bool check = true;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    check = false;
                }
            }

            Assert.IsTrue(check);
        }

        [TestMethod]
        public void TestSort4()
        {
            int[] array = { 1 };
            Program.BubbleSort(array);

            Assert.AreEqual(1, array[0]);
        }
    }
}
