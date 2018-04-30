using System;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class SortTests
    {
        [TestMethod]
        public void SelectingSort()
        {
            int[] values = ArrayHelper.InitArray(100, 1, 100);

            Assert.IsFalse(ArrayHelper.CheckArraySorted(values));

            Algorithms.SelectingSort.Sort(values);

            Assert.IsTrue(ArrayHelper.CheckArraySorted(values));
        }

        [TestMethod]
        public void InsertingSort()
        {
            int[] values = ArrayHelper.InitArray(100, 1, 100);

            Assert.IsFalse(ArrayHelper.CheckArraySorted(values));

            Algorithms.InsertingSort.Sort(values);

            Assert.IsTrue(ArrayHelper.CheckArraySorted(values));
        }
    }
}
