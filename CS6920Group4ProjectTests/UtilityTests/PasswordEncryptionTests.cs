using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CS6920Group4ProjectTests.UtilityTests
{
    [TestClass]
    public class PasswordEncryptionTests
    {
        [TestMethod]
        public void TestMatchingHashIsTrue()
        {
            Assert.IsTrue(CS6920Group4Project.Utilities.PasswordEncryption.ValidatePassword("guestguest", "1000:3dki5MOtE9ipOajrvJxWeooHJivqufJW:TnxTQ+3m++F6lE6gLVv1I6nW46xwSnQz"));
        }

        [TestMethod]
        public void TestMatchingHashIsFalse()
        {
            Assert.IsFalse(CS6920Group4Project.Utilities.PasswordEncryption.ValidatePassword("badlogin", "1000:3dki5MOtE9ipOajrvJxWeooHJivqufJW:TnxTQ+3m++F6lE6gLVv1I6nW46xwSnQz"));
        }
    }
}
