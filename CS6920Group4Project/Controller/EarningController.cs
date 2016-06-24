using CS6920Group4Project.DAL.Model;
using CS6920Group4Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6920Group4Project.Controller
{
    class EarningController
    {
        private static EarningController instance;

        private readonly EarningDAL _dal = new EarningDAL();

        public static EarningController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EarningController();
                }
                return instance;
            }
        }

        public List<Earning> GetEarningsByBudgetID(int ID)
        {
            return _dal.GetEarningsByBudgetID(ID);
        }
    }
}
