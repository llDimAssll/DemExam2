using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DemClass;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Class1.SquareMetod(2, 5, 3), "Корень x1 = -1 x2 = -1,5");
            Assert.AreEqual(Class1.LinenUr(8, 4), "Корень x = 0,5");
        }
    }
}
