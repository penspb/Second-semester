using Microsoft.VisualStudio.TestTools.UnitTesting;
using _7._2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2.Tests
{
    [TestClass]
    public class SetTests
    {
        private Set<int> set0;
        private Set<int> set1;

        private Set<int> result;

        [TestInitialize]
        public void Initialize()
        {
            set0 = new Set<int>();
            set1 = new Set<int>();

            result = new Set<int>();
        }
        
        [TestMethod]
        public void AddAndIsValueHereTest()
        {
            set0.Add(0);
            set0.Add(1);
            set0.Add(2);
            set0.Add(3);
            Assert.IsTrue(set0.IsValueHere(2));
        }

        [TestMethod]
        public void AddAndDeleteValueAndCheckTest()
        {
            set0.Add(0);
            set0.DeleteValue(0);
            Assert.IsFalse(set0.IsValueHere(0));
        }

        [TestMethod]
        public void AssociationAndDeleteTest()
        {
            set0.Add(0);
            set1.Add(1);
            set1.Add(0);
            result.Association(set0, set1);
            result.DeleteValue(0);
            result.DeleteValue(1);
            Assert.IsFalse(result.IsValueHere(0));
        }

        [TestMethod()]
        public void IntersectionTest()
        {
            set0.Add(0);
            set1.Add(1);
            set1.Add(0);
            result.Intersection(set0, set1);
            Assert.IsFalse(result.IsValueHere(1));
        }
    }
}