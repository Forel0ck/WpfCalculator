using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Sum()
        {
            double val1 = 12;
            double val2 = 21;
            double ex = 33;
            double res = Sum(val1 , val2);

            Assert.AreEqual(ex, res);
        }
    }
}
