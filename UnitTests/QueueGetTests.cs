using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCollection;

namespace UnitTests
{
    [TestClass]
    public class QueueGetTests
    {
        [TestMethod]
        public void Returns_First_Item()
        {
            var queue = new MyQueue<int> {1, 2, 3, 4, 5};
            int expected = 1;

            int actual = queue.Get();

            Assert.AreEqual(expected, actual);
        }

    }
}
