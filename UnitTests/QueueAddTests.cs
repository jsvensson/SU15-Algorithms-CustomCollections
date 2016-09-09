using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCollection;

namespace UnitTests
{
    [TestClass]
    public class QueueAddTests
    {
        [TestMethod]
        public void Adds_Single_Item()
        {
            var queue = new MyQueue<int>();

            queue.Add(1);

            Assert.IsTrue(queue.Count == 1);
        }
    }
}
