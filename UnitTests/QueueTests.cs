using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCollection;

namespace UnitTests
{
    [TestClass]
    public class QueueTests
    {
        [TestMethod]
        public void Initializes_With_Enumerable()
        {
            var queue = new MyQueue<int> {1, 2, 3, 4, 5};

            Assert.IsTrue(queue.Count == 5);
        }

        [TestMethod]
        public void New_Queue_Is_Empty()
        {
            var queue = new MyQueue<int>();

            Assert.IsTrue(queue.Count == 0);
        }
    }
}
