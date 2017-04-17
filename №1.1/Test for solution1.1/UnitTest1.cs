using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1._1;

namespace Test_for_solution1._1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckingAnsew0()
        {
            Assert.AreEqual(Program.Factorial(3), 6);
        }

        [TestMethod]
        public void CheckingAnsew1()
        {
            Assert.AreEqual(Program.Factorial(0), 1);
        }

        [TestMethod]
        public void CheckingAnsew2()
        {
            Assert.AreEqual(Program.Factorial(7), 5040);
        }
    }
}
