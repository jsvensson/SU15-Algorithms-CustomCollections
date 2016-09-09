using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCollection;

namespace UnitTests
{
    [TestClass]
    public class StackClearTests
    {
        [TestMethod]
        public void Clears_Stack()
        {
            var stack = new MyStack<int> { 1, 2, 3, 4, 5 };
            int expected = 0;

            stack.Clear();
            int actual = stack.Count;

            Assert.AreEqual(expected, actual);
        }
    }
}
