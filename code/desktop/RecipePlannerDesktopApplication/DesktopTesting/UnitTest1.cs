using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecipePlannerDesktopApplication;
using System;

namespace DesktopTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var model = new ModelClass();
            Assert.IsTrue(model.testingCoverage());
        }
    }
}
