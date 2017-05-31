using Microsoft.VisualStudio.TestTools.UnitTesting;
using _4._2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2.Tests
{
    [TestClass]
    public class TestForList
    {

        private List list;

        [TestInitialize]
        public void Initialize()
        {
            list = new List();
        }

        [TestMethod]
        public void TestAdd1()
        {
            list.Add(0, -3);
            Assert.IsFalse(list.IsEmpty());
        }

        [TestMethod]
        public void TestAddGet2()
        {
            list.Add(0, -2);
            Assert.AreEqual(-2, list.Get(0));
            list.Add(0, -1);
            Assert.AreEqual(-2, list.Get(1));
            list.Add(1, 0);
            Assert.AreEqual(0, list.Get(1));
        }

        [TestMethod]
        public void TestAddDelete3()
        {
            list.Add(0, 1);
            list.Add(1, 2);
            list.Add(2, 3);
            Assert.AreEqual(3, list.Delete(2));
            Assert.AreEqual(1, list.Delete(0));
        }

        [TestMethod]
        public void TestAddDelete4()
        {
            list.Add(0, 4);
            Assert.AreEqual(4, list.Delete(0));
            list.Add(0, 5);
            Assert.IsFalse(list.IsEmpty());
        }

        [TestMethod]
        [ExpectedException(typeof(ListIsEmptyException))]
        public void TestException0()
        {
            list.Get(6);
        }

        [TestMethod]
        [ExpectedException(typeof(ListIsEmptyException))]
        public void TestException1()
        {
            list.Delete(7);
        }

        [TestMethod]
        [ExpectedException(typeof(NonexistentPositionException))]
        public void TestException2()
        {
            list.Add(0, 8);
            list.Delete(-9);
        }

        [TestMethod]
        [ExpectedException(typeof(NonexistentPositionException))]
        public void TestException3()
        {
            list.Add(0, 10);
            list.Get(-11);
        }

        [TestMethod]
        [ExpectedException(typeof(NonexistentPositionException))]
        public void TestException4()
        {
            list.Add(-12, 0);
        }
    }
}