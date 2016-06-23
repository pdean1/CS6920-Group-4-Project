using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CS6920Group4Project.DAL.Model;
using System.Collections.Generic;
using CS6920Group4Project.Model;

namespace CS6920Group4ProjectTests.DALTests.ModelTests
{
    [TestClass]
    public class RecordDALTests
    {
        RecordDAL _dal = new RecordDAL();
        [TestMethod]
        public void TestGetRecordsByBudgetIDReturnsListOfRecords()
        {
            List<Record> records = _dal.GetRecordsByBudgetID(1);
            if (records == null)
            {
                Assert.IsTrue(false);
                return;
            }
            Assert.IsTrue(_dal.GetRecordsByBudgetID(1).Count > 0);
        }
    }
}
