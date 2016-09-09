using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCollection;

namespace UnitTests
{
    [TestClass]
    public class StackPushPopTests
    {
        [TestMethod]
        public void Pushes_Item()
        {
            var stack = new MyStack<int> {1, 2, 3};
            int input = 4;
            int expected = 4;

            stack.Push(input);
            int actual = stack[3];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Pops_Item()
        {
            var stack = new MyStack<int> { 1, 2, 3 };
            int expectedValue = 3;
            int expectedLength = 2;

            int actualValue = stack.Pop();
            int actualLength = stack.Count;

            Assert.AreEqual(expectedValue, actualValue);
            Assert.AreEqual(expectedLength, actualLength);
        }
    }
}
