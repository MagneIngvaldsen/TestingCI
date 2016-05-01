using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(Task1.AlwaysTrue());
        }
    }
}
