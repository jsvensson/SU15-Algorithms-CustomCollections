using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCollection;

namespace UnitTests
{
    [TestClass]
    public class StackGetTests
    {
        [TestMethod]
        public void Returns_Last_Item()
        {
            var stack = new MyStack<int> { 1, 2, 3, 4, 5 };
            int expected = 5;

            int actual = stack.Get();

            Assert.AreEqual(expected, actual);
        }

    }
}
