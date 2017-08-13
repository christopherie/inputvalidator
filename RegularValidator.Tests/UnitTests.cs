using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RegularValidator.Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ShouldReturnTrueForPPSN_1234567TH()
        {
            bool valid = InputValidator.IsValidPPSN("1234567TH");
            Assert.IsTrue(valid);
        }
    }
}
