using System;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorythms.Tests
{
    [TestClass]
    public class SelectingSortTests
    {
        [TestMethod]
        public void Correctness()
        {
            int[] values = Helper.InitArray(100, 1, 100);

            Assert.IsFalse(Helper.CheckArraySorted(values));

            SelectingSort.Sort(values);

            Assert.IsTrue(Helper.CheckArraySorted(values));
        }
    }
}
