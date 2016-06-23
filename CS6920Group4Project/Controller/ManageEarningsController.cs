using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS6920Group4Project.DAL.Model;
using CS6920Group4Project.Model;

namespace CS6920Group4Project.Controller
{
    class ManageEarningsController
    {
        private static ManageEarningsController instance;

        private readonly ManageEarningsDAL earningDAL = new ManageEarningsDAL();

        private ManageEarningsController()
        {

        }

        public static ManageEarningsController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ManageEarningsController();
                }
                return instance;
            }
        }

        /// <summary>
        /// Inserts a earning, earn, into the database
        /// </summary>
        /// <param name="earning">inserts earnings</param>
        /// <param name="category">inserts category</param>
        /// <returns>the inserted record or false</returns>
        public Boolean InsertEarn(Earning earning, EarningCategory category)
        {
            return earningDAL.InsertEarn(earning, category);
        }
    }
}
