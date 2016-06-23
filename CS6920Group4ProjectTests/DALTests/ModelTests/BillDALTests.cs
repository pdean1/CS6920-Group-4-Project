using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CS6920Group4Project.DAL.Model;
using System.Collections.Generic;
using CS6920Group4Project.Model;

namespace CS6920Group4ProjectTests.DALTests.ModelTests
{
    [TestClass]
    public class BillDALTests
    {
        BillDAL _dal = new BillDAL();

        [TestMethod]
        public void TestGetBillByBudgetIDReturnsAResultForIDOf1()
        {
            List<Bill> bills = _dal.GetBillsByBudgetID(1);
            if (bills == null)
            {
                Assert.IsTrue(false);
                return;
            }
            foreach (Bill b in bills)
            {
                Assert.IsNotNull(b);
                Assert.IsTrue(b.ID > 0);
            }
        }
    }
}
