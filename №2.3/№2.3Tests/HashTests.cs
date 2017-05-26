using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2._3;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3.Tests
{
    [TestClass]
    public class HashTests
    {
        private Hash hash;

        [TestInitialize]
        public void Initialize()
        {
            hash = new Hash();
        }
        
        [TestMethod]
        public void HashTest0()
        {
            hash.Add("I am Iron Man");
            Assert.IsTrue(hash.AreYouHere("I am Iron Man"));
        }

        [TestMethod]
        public void HashTest1()
        {
            hash.Add("Tu-u ru-u, tu ru ru. Tu-ru-tu-ru-tu-ru tu ru ru");
            hash.Add("Tu-u ru-u, tu ru ru. Tu-ru-tu-ru-tu-ru tu ru ru");
            hash.Add("Has he lost his mind?");
            Assert.IsTrue(hash.AreYouHere("Tu-u ru-u, tu ru ru. Tu-ru-tu-ru-tu-ru tu ru ru"));
            Assert.IsTrue(hash.AreYouHere("Has he lost his mind?"));
        }

        [TestMethod]
        public void StrangeTestForHashTable2()
        {
            int result = hash.Function("Now the time is here");
            Assert.AreEqual(result, hash.Function("Now the time is here"));
        }

        [TestMethod]
        public void HashTest3()
        {
            hash.Add("Can he see or his mind?");
            hash.Add("Can he walk at all");
            hash.Add("Or if he moves will he fall?");
            Assert.IsFalse(hash.AreYouHere("Is he alive or dead?"));
        }

        [TestMethod]
        public void HashTest4()
        {
            hash.Add("Has he thoughts within his head");
            hash.Add("We'll just pass him there");
            hash.Add("Why should we even care?");
            hash.Add("Why should we even care?");
            hash.Delete("Why should we even care?");
            hash.Delete("Why should we even care?");
            Assert.IsFalse(hash.AreYouHere("Why should we even care?"));
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionNonexistentPosition))]
        public void HashTest5()
        {
            hash.Delete("He was turned to steel");
        }
    }
}