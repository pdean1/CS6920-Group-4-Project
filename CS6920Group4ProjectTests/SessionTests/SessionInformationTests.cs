using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CS6920Group4Project.Model;
using CS6920Group4Project.Session;

namespace CS6920Group4ProjectTests.SessionTests
{
    [TestClass]
    public class SessionInformationTests
    {
        User user = new User();
        [TestMethod]
        public void TestGetAndSetUser()
        {
            user.FirstName = "Patrick";
            user.LastName = "Dean";
            SessionInformation.SetSessionUser(user);
            Assert.AreEqual("Patrick", SessionInformation.GetSessionUser().FirstName);
            Assert.AreEqual("Dean", SessionInformation.GetSessionUser().LastName);
            SessionInformation.InitSession();
            Assert.AreEqual(null, SessionInformation.GetSessionUser().FirstName);
            Assert.AreEqual(null, SessionInformation.GetSessionUser().LastName);
        }

        [TestMethod]
        public void TestInitSessionMethod()
        {
            SessionInformation.InitSession();
            Assert.IsTrue(SessionInformation.GetSessionUser() != null);
            Assert.IsTrue(SessionInformation.GetBudget() != null);
        }
    }
}