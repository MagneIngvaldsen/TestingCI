using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class ClassesAndProps
    {
        [TestMethod]
        public void CreateClass()
        {
            var person = Type.GetType("Tasks.Person, Tasks");
            Assert.IsNotNull(person, "You need to create that person class");
        }
    }
}
