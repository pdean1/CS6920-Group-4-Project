using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CS6920Group4Project.DAL.Model;
using CS6920Group4Project.model;
using System.Collections.Generic;

namespace CS6920Group4ProjectTests.DALTests.ModelTests
{
    [TestClass]
    public class BudgetDALTests
    {
        BudgetDAL _dal = new BudgetDAL();
        [TestMethod]
        public void TestSelectGuestBudgets()
        {
            Assert.IsNotNull(_dal.GetAllUserBudgets(1));
        }
    }
}
