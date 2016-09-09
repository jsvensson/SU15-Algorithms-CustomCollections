using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCollection;

namespace UnitTests
{
    [TestClass]
    public class StackAddTests
    {
        [TestMethod]
        public void Adds_Single_Item()
        {
            var stack = new MyStack<int>();

            stack.Add(1);

            Assert.IsTrue(stack.Count == 1);
        }
    }
}
