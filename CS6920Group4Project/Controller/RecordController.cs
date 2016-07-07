using CS6920Group4Project.DAL.Model;
using CS6920Group4Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6920Group4Project.Controller
{
    public class RecordController
    {
        private static RecordController instance;
        private readonly RecordDAL _dal = new RecordDAL();
        private RecordController() { }
        public static RecordController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RecordController();
                }
                return instance;
            }
        }
        public long InsertRecord(Record record)
        {
            return _dal.InsertRecord(record);
        }
        public Boolean  DeleteRecord(Record r)
        {
            return _dal.DeleteRecord(r);
        }
    }
}
