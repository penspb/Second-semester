using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1._2;

namespace TestForSolutionOnePointTwo
{
    [TestClass]
    public class TestForOnePoinTwo
    {
        [TestMethod]
        public void CheckingResult0()
        {
            Assert.AreEqual(Program.Fibonacci(0), 1);
        }

        [TestMethod]
        public void CheckingResult1()
        {
            Assert.AreEqual(Program.Fibonacci(1), 1);
        }

        [TestMethod]
        public void CheckingResult2()
        {
            Assert.AreEqual(Program.Fibonacci(2), 2);
        }

        [TestMethod]
        public void CheckingResult3()
        {
            Assert.AreEqual(Program.Fibonacci(5), 8);
        }

        [TestMethod]
        [ExpectedException(typeof(NegativeReferenceException))]
        public void CheckingException()
        {
            Program.Fibonacci(-2);
        }
    }
}
