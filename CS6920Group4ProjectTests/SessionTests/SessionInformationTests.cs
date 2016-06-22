﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CS6920Group4Project.model;
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
        }
    }
}