using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CS6920Group4Project.DAL.Model;
using CS6920Group4Project.Model;
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

        [TestMethod]
        public void TestSelectBudgetsOnMaxIntShouldReturnABlankList()
        {
            Assert.IsTrue(_dal.GetAllUserBudgets(int.MaxValue).Count == 0);
        }
    }
}
