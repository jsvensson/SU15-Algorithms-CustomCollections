using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCollection;

namespace UnitTests
{
    [TestClass]
    public class QueueEnqueueDequeueTests
    {
        [TestMethod]
        public void Enqueues_Item()
        {
            var queue = new MyQueue<int> {1, 2, 3};
            int input = 4;
            int expected = 4;

            queue.Enqueue(input);
            int actual = queue[3];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Dequeues_Item()
        {
            var queue = new MyQueue<int> { 1, 2, 3, 4, 5 };
            int expected = 1;

            int actual = queue.Dequeue();

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(queue.Count == 4);
        }
    }
}
