using PrototypeWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeTestProject
{
    internal class PrototypeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSum()
        {
            var math = new Prototype();
            int result = math.sum(2, 3);
            Assert.IsTrue(result == 5);
        }
    }
}
