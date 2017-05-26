using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2._3;

namespace TestForList
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
        public void Test()
        {
            list.Add(0, "I travelled far and wide through many different times.");
            list.Add(1, "What did you see there?");
            list.Add(2, "I saw the saints with their toys.");
            list.Add(3, "What did you see there?");
            list.Add(4, "I saw all knoledge destroyed.");
            Assert.AreEqual("What did you see there?", list.Delete(list.FindPosition("What did you see there?")));
            Assert.AreEqual("What did you see there?", list.Delete(list.FindPosition("What did you see there?")));
            Assert.AreEqual("I saw all knoledge destroyed.", list.Delete(list.FindPosition("I saw all knoledge destroyed.")));
        }

        [TestMethod]
        public void TestAdd1()
        {
            list.Add(0, "qwerty");
            Assert.IsFalse(list.IsEmpty());
        }

        [TestMethod]
        public void TestAddGet2()
        {
            list.Add(0, "Hello");
            Assert.AreEqual("Hello", list.Get(0));
            list.Add(0, ",");
            Assert.AreEqual("Hello", list.Get(1));
            list.Add(1, "wolrld!");
            Assert.AreEqual("wolrld!", list.Get(1));
        }

        [TestMethod]
        public void TestAddDelete3()
        {
            list.Add(0, "I hurt myself today");
            list.Add(1, "To see if I steel feel");
            list.Add(2, "I focus on the pain");
            list.Delete(1);
            list.Delete(1);
            Assert.AreEqual("I hurt myself today", list.Get(0));
        }

        [TestMethod]
        public void TestAddDelete4()
        {
            list.Add(0, "Such a lonely day");
            Assert.AreEqual("Such a lonely day", list.Get(0));
            list.Add(0, "And it's mine");
            Assert.IsFalse(list.IsEmpty());
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionListIsEmpty))]
        public void TestException0()
        {
            list.Get(6);
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionListIsEmpty))]
        public void TestException1()
        {
            list.Delete(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionNonexistentPosition))]
        public void TestException2()
        {
            list.Add(0, "What did you see there?");
            list.Delete(1);
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionNonexistentPosition))]
        public void TestException3()
        {
            list.Add(0, "There's devil waiting outside your door");
            list.Get(-11);
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionNonexistentPosition))]
        public void TestException4()
        {
            list.Add(-12, "I'm walking thriugh deep water");
        }
    }
}
