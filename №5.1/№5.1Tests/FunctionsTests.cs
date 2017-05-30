using Microsoft.VisualStudio.TestTools.UnitTesting;
using _5._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1.Tests
{
    [TestClass]
    public class FunctionsTests
    {
        private IList<int> list0;
        private IList<int> newList0;
        private IList<int> list1;
        private IList<int> newList1;

        [TestInitialize]
        public void Initialize()
        {
            list0 = new List<int> { 1, 2, 3 };
            list1 = new List<int> { 0 };
        }

        [TestMethod]
        public void MapTest()
        {
            newList0 = Functions.Map(list0, x => x * 2);
            newList1 = Functions.Map(list1, x => x - 1);

            Assert.AreEqual(6, newList0[2]);
            Assert.AreEqual(4, newList0[1]);
            Assert.AreEqual(2, newList0[0]);
            Assert.AreEqual(-1, newList1[0]);
        }

        [TestMethod]
        public void FilterTest()
        {
            newList0 = Functions.Filter(list0, x => x % 3 == 0);
            newList1 = Functions.Filter(list1, x => x == 0);
            Assert.AreEqual(3, newList0[0]);
            Assert.AreEqual(0, newList1[0]);

        }

        [TestMethod]
        public void FoldTest()
        {
            Assert.AreEqual(12, Functions.Fold(list0, 2, (accumulator, item) => accumulator * item));
            Assert.AreEqual(0, Functions.Fold(list1, 0, (accumulator, item) => accumulator - item));
        }
    }
}