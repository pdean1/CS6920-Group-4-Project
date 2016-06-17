using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CS6920Group4Project.Utilities;

namespace UnitTestProject1.Utilities
{
    [TestClass]
    public class EmailUtilityTests
    {
        [TestMethod]
        public void TestValidEmailForNullEmail()
        {
            String email = "";
            Assert.IsFalse(EmailUtility.ValidEmail(email));
        }
    }
}
