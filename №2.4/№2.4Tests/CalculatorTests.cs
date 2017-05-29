using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2._4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        private ListStack listStack;
        private Calculator listCalculator;

        private ArrayStack arrayStack;
        private Calculator arrayCalculator;

        [TestInitialize]
        public void Initialize()
        {
            listStack = new ListStack();
            listCalculator = new Calculator(listStack);

            arrayStack = new ArrayStack();
            arrayCalculator = new Calculator(arrayStack);
        }

        [TestMethod]
        public void ArrayCalculatorTest0()
        {
            Assert.AreEqual(0, arrayCalculator.Result("0 0 +"));
        }

        [TestMethod]
        public void ListCalculatorTest0()
        {
            Assert.AreEqual(0, listCalculator.Result("0 0 +"));
        }

        [TestMethod]
        public void ArrayCalculatorTest1()
        {
            Assert.AreEqual(0, arrayCalculator.Result("10 0 *"));
            Assert.AreEqual(17, arrayCalculator.Result("34 2 /"));
            Assert.AreEqual(5, arrayCalculator.Result("8 3 -"));
        }

        [TestMethod]
        public void ListCalculatorTest1()
        {
            Assert.AreEqual(0, listCalculator.Result("10 0 *"));
            Assert.AreEqual(17, listCalculator.Result("34 2 /"));
            Assert.AreEqual(5, listCalculator.Result("8 3 -"));
        }

        [TestMethod]
        public void ArrayCalculatorTest2()
        {
            Assert.AreEqual(5, arrayCalculator.Result("1 2 * 3 +"));
        }

        [TestMethod]
        public void ListCalculatorTest2()
        {
            Assert.AreEqual(0, listCalculator.Result("0 1 * 2 3 + *"));
        }
    }
}