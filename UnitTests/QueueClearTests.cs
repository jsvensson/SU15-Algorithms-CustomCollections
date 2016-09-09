using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCollection;

namespace UnitTests
{
    [TestClass]
    public class QueueClearTests
    {
        [TestMethod]
        public void Clears_Queue()
        {
            var queue = new MyQueue<int> {1, 2, 3, 4, 5};
            int expected = 0;

            queue.Clear();
            int actual = queue.Count;

            Assert.AreEqual(expected, actual);
        }
    }
}
