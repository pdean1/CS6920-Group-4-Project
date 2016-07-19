using Jitbit.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6920Group4Project.Model
{
    public class BudgetCSV
    {
        CsvExport csv;
        public BudgetCSV(Budget b)
        {
            csv = new CsvExport();
            PopulateCSV(b);
        }

        private void PopulateCSV(Budget b)
        {
            String[] columnNames = { "Record Type", "Title", "Amount", "Date" };
            foreach (Bill bill in b.Bills)
            {
                csv.AddRow();
                csv[columnNames[0]] = "Bill";
                csv[columnNames[1]] = bill.Title; 
                csv[columnNames[2]] = Utilities.StringUtilities.GetDisplayableDollarAmount(bill.Amount);
                csv[columnNames[3]] = bill.DateDue;
            }

            foreach (Expense expense in b.Expenses)
            {
                csv.AddRow();
                csv[columnNames[0]] = "Expense";
                csv[columnNames[1]] = expense.Title;
                csv[columnNames[2]] = Utilities.StringUtilities.GetDisplayableDollarAmount(expense.Amount);
                csv[columnNames[3]] = expense.DateSpent;
            }

            foreach (Earning earning in b.Earnings)
            {
                csv.AddRow();
                csv[columnNames[0]] = "Earning";
                csv[columnNames[1]] = earning.Title;
                csv[columnNames[2]] = Utilities.StringUtilities.GetDisplayableDollarAmount(earning.Amount);
                csv[columnNames[3]] = earning.DateEarned;
            }
        }

        public Boolean ExportCSVToFile(string path)
        {
            try
            {
                csv.ExportToFile(path);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public BudgetCSV() : this(Session.SessionInformation.GetBudget()) { }
    }
}
