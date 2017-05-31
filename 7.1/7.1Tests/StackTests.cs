using Microsoft.VisualStudio.TestTools.UnitTesting;
using _7._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1.Tests
{
    [TestClass]
    public class StackTests
    {
        private Stack<int> stack;

        [TestInitialize]
        public void Initialize()
        {
            stack = new Stack<int>();
        }

        [TestMethod]
        public void TestForPush()
        {
            stack.Push(-1);
            Assert.IsFalse(stack.IsEmpty());
        }

        [TestMethod]
        public void TestForPush1()
        {
            stack.Push(0);
            stack.Push(1);
            Assert.IsFalse(stack.IsEmpty());
        }

        [TestMethod]
        public void TestForPop()
        {
            stack.Push(2);
            Assert.AreEqual(2, stack.Pop());
        }

        [TestMethod]
        public void TestForPop1()
        {
            stack.Push(3);
            stack.Push(4);
            Assert.AreEqual(4, stack.Pop());
        }

        [TestMethod]
        public void TestForPop2()
        {
            stack.Push(5);
            stack.Push(6);
            Assert.AreEqual(6, stack.Pop());
            Assert.AreEqual(5, stack.Pop());
        }

        [TestMethod]
        [ExpectedException(typeof(ListIsEmptyException))]
        public void TestForException()
        {
            stack.Pop();
        }
    }
}