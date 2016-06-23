using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CS6920Group4Project.DAL.Model;
using CS6920Group4Project.Model;

namespace CS6920Group4ProjectTests.DALTests.ModelTests
{
    [TestClass]
    public class ExpenseDALTests
    {
        private ExpenseDAL _dal = new ExpenseDAL();
        [TestMethod]
        public void TestSelectExpensesByBudgetID()
        {
            List<Expense> expenses = _dal.GetListOfExpensesByBudgetID(1);
            if (expenses == null)
            {
                Assert.IsTrue(false);
                return;
            }
            foreach (Expense x in expenses)
            {
                Assert.IsNotNull(x);
                Assert.IsTrue(x.ID > 0);
            }
        }
    }
}
