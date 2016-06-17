using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CS6920Group4Project.model;
using CS6920Group4Project.DAL.Model;

namespace CS6920Group4ProjectTests.DALTests.ModelTests
{
    /// <summary>
    /// Summary description for UserDALTests
    /// </summary>
    [TestClass]
    public class UserDALTests
    {
        private User user = new User();
        private UserDAL userDAL = new UserDAL();
        [TestMethod]
        public void TestAddUser()
        {
            user.Password = "password";
            long ret = userDAL.InsertUser(user);
            Assert.IsTrue(ret > 0);
        }
    }
}
