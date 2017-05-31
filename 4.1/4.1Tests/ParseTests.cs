using Microsoft.VisualStudio.TestTools.UnitTesting;
using _4._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1.Tests
{
    [TestClass]
    public class ParseTests
    {
        private Parse tree;

        [TestInitialize]
        public void Initialize()
        {
            tree = new Parse();
        }

        [TestMethod]
        public void TestForCheckResult0()
        {
            Assert.AreEqual(4, tree.Calculate("(*(+1 1)2)"));
        }

        [TestMethod]
        public void TestForCheckResult1()
        {
            Assert.AreEqual(20, tree.Calculate("(*(+3 2) 4)"));
        }

        [TestMethod]
        public void TestForCheckResult2()
        {
            Assert.AreEqual(28, tree.Calculate("(*(+(*(+1 1)2)3)4)"));
        }
    }
}