using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CS6920Group4Project.model;
using CS6920Group4Project.DAL.Model;

namespace CS6920Group4ProjectTests.DALTests.ModelTests
{
    /// <summary>
    /// This test suite contains tests for the USER DAL Class.
    /// </summary>
    [TestClass]
    public class UserDALTests
    {
        private User user = new User();
        private UserDAL userDAL = new UserDAL();

        /*
        [TestMethod]
        public void TestAddUser()
        {
            user.FirstName = "Test";
            user.LastName = "Test";
            user.UserName = "Test";
            user.Password = "guest";
            long ret = userDAL.InsertUser(user);
            Assert.IsTrue(ret > 0);
        }
        */

        [TestMethod]
        public void TestAttemptUserLoginWithGuestUser()
        {
            user.FirstName = "Test";
            user.LastName = "Test";
            user.UserName = "guest";
            user.Password = "guest";
            User u2 = userDAL.AttemptUserLogin(user.UserName, user.Password);
            Assert.IsTrue(u2 != null);
        }
    }
}
