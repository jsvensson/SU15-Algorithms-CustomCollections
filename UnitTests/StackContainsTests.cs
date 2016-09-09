using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCollection;

namespace UnitTests
{
    [TestClass]
    public class StackContainsTests
    {
        private MyStack<int> stack;

        [TestInitialize]
        public void Initialize()
        {
            stack = new MyStack<int> { 1, 2, 3, 4, 5 };
        }

        [TestMethod]
        public void Item_Exists()
        {
            Assert.IsTrue(stack.Contains(3));
        }

        [TestMethod]
        public void Item_Does_Not_Exist()
        {
            Assert.IsFalse(stack.Contains(42));
        }
    }
}
