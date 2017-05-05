using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1._1;

namespace TestForSolutionOnePointOne
{
    [TestClass]
    public class TestForOnePointOne
    {
        [TestMethod]
        public void CheckingAnswer0()
        {
            Assert.AreEqual(6, Program.Factorial(3));

        }

        [TestMethod]
        public void CheckingAnswer1()
        {

            Assert.AreEqual(1, Program.Factorial(0));
        }

        [TestMethod]
        public void CheckingAnswer2()
        {
            Assert.AreEqual(5040, Program.Factorial(7));
        }


        [TestMethod]
        [ExpectedException(typeof(NegativeReferenceExeption))]
        public void CheckingException()
        {
            Program.Factorial(-2);
        }
    }
}
