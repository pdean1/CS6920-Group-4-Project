﻿using CS6920Group4Project.DAL.Model;
using CS6920Group4Project.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6920Group4Project.Controller
{
    public class BillController
    {
        private static BillController instance;
        private readonly BillDAL _dal = new BillDAL();
        
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


        public long InsertBill(Bill bill)
        {
            return _dal.InsertBill(bill);
        }
        public bool EditBills(Bill bill)
        {
            return _dal.EditBill(bill);
        }
        public bool DeleteBill(Bill b) 
        {
            return _dal.DeleteBill(b);
        }

        public MySqlDataAdapter GetListOfBillsByBudgetIDDataGridView(int BudgetID)
        {
            return _dal.GetListOfBillsByBudgetIDDataGridView(BudgetID);
        }
    }
}
