using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCollection;

namespace UnitTests
{
    [TestClass]
    public class QueueGetAndRemoveTests
    {
        [TestMethod]
        public void Returns_First_Item()
        {
            var queue = new MyQueue<int> { 1, 2, 3, 4, 5 };
            int expected = 1;

            int actual = queue.Get();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Removes_First_Item()
        {
            var queue = new MyQueue<int> { 1, 2, 3, 4, 5 };
            int expectedLength = 4;

            int item = queue.GetAndRemove();
            int actualLength = queue.Count;

            Assert.IsFalse(queue.Contains(item));
            Assert.AreEqual(expectedLength, actualLength);
        }
    }
}
