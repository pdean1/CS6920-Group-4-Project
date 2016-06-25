using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CS6920Group4Project.Controller;

namespace CS6920Group4Project.View
{
    public partial class ManageBills : Form
    {
        String billSource;
        String billDesc;
        String billAmount;
        String billDate;

        public ManageBills()
        {
            InitializeComponent();
            this.getBillCategoryList();
        }

        private void billBtn_Click(object sender, EventArgs e)
        {
            bool isValidData = this.validateData();
            if (isValidData == true)
            {
                
            }
            else
            {
                this.clearData();
            }
        }

        public bool validateData()
        {
            billSource = billBox.Text;
            billDesc = billCategoryBox.SelectedText.ToString();
            billAmount = billAmountBox.Text;
            billDate = monthCalendar.Text;

            if (String.IsNullOrEmpty(billSource) || String.IsNullOrEmpty(billDesc) ||
                String.IsNullOrEmpty(billAmount) || String.IsNullOrEmpty(billDate))
            {
                MessageBox.Show("All fields are required, Please Try Again",
                                "USER",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop);
                return false;
            }

            return true;
        }

        private void clearData()
        {
            billBox.Text = "";
            billCategoryBox.SelectedIndex = -1 ;
            billAmountBox.Text = "";
            monthCalendar.Text = "";
        }

        private void getBillCategoryList()
        {
            billCategoryBox.DataSource = BillController.Instance.GetBillCategoryList();
            billCategoryBox.DisplayMember = "Title";
            billCategoryBox.ValueMember = "ID";
        }
    }
}
