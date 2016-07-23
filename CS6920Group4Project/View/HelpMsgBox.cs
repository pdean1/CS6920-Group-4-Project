using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS6920Group4Project
{
    public partial class HelpMsgBox : Form
    {
        public HelpMsgBox()
        {
            InitializeComponent();
        }
        static HelpMsgBox MsgBox;
        static DialogResult result = DialogResult.No;

        public static DialogResult Show(string Text, string Caption, string okBtn, string cancelBtn)
        {
            MsgBox = new HelpMsgBox();
            MsgBox.messageLbl.Text = Text;
            MsgBox.btnOK.Text = okBtn;
            MsgBox.btnCancel.Text = cancelBtn;
            MsgBox.ShowDialog();
            return result;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            MsgBox.Close();
        }
    }
}
