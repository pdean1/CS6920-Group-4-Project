using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CS6920Group4Project.DAL.Model;
using System.Collections.Generic;
using CS6920Group4Project.Model;

namespace CS6920Group4ProjectTests.DALTests.ModelTests
{
    [TestClass]
    public class EarningDALTests
    {
        private EarningDAL _dal = new EarningDAL();
        [TestMethod]
        public void TestGetEarningsByBudgetID()
        {
            List<Earning> earnings = _dal.GetEarningsByBudgetID(1);
            if (earnings == null)
            {
                Assert.IsTrue(false);
                return;
            }
            foreach (Earning e in earnings)
            {
                Assert.IsNotNull(e);
                Assert.IsTrue(e.ID > 0);
            }
        }
    }
}
