using Microsoft.VisualStudio.TestTools.UnitTesting;
using _4._2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2.Tests
{
    [TestClass()]
    public class UniqueListTests
    {
        private UniqueList list;

        [TestInitialize]
        public void Initialize()
        {
            list = new UniqueList();
        }

        [TestMethod]
        public void TestAdd1()
        {
            list.Add(0, -3);
            Assert.IsFalse(list.IsEmpty());
        }

        [TestMethod]
        public void TestAddDelete2()
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

        [TestMethod]
        [ExpectedException(typeof(ValueUnfortunatelyIsHere))]
        public void TestException5()
        {
            list.Add(0, 10);
            list.Add(1, 10);
        }
    }
}