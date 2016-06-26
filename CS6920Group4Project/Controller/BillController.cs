using CS6920Group4Project.DAL.Model;
using CS6920Group4Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6920Group4Project.Controller
{
    class BillController
    {
        private static BillController instance;
        private readonly BillDAL _dal = new BillDAL();
        private BillController()
        {
            
        }

        public static BillController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillController();
                }
                return instance;
            }
        }
        public List<Bill> GetBillsByBudgetID(int ID)
        {
            return _dal.GetBillsByBudgetID(ID);
        }

        public List<BillCategory> GetBillCategoryList()
        {
            return _dal.GetBillCategoryList();
        }
<<<<<<< HEAD

        public long InsertBill(Bill bill)
        {
            return _dal.InsertBill(bill);
=======
        public long InsertBill(Bill b)
        {
            return _dal.InsertBill(b);
>>>>>>> 6ed44ef9f1209d253f30e2e97f440a0d9d23c46f
        }
    }
}
