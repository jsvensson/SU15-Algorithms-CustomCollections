using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCollection;

namespace UnitTests
{
    [TestClass]
    public class QueueContainsTests
    {
        private MyQueue<int> queue;

        [TestInitialize]
        public void Initialize()
        {
            queue = new MyQueue<int> {1, 2, 3, 4, 5};
        }

        [TestMethod]
        public void Item_Exists()
        {
            Assert.IsTrue(queue.Contains(3));
        }

        [TestMethod]
        public void Item_Does_Not_Exist()
        {
            Assert.IsFalse(queue.Contains(42));
        }
    }
}
