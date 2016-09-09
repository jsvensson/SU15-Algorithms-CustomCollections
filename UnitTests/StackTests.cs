using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCollection;

namespace UnitTests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void Initializes_With_Enumerable()
        {
            var queue = new MyStack<int> { 1, 2, 3, 4, 5 };

            Assert.IsTrue(queue.Count == 5);
        }

        [TestMethod]
        public void New_Queue_Is_Empty()
        {
            var queue = new MyStack<int>();

            Assert.IsTrue(queue.Count == 0);
        }
    }
}
