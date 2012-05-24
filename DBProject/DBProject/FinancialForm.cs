using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace finance
{
    public partial class FinancialForm : Form
    {
        public FinancialForm()
        {
            InitializeComponent();
        }


        private bool checkChildFormExist(string childFormName)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.Name == childFormName)
                {
                    if (childForm.WindowState == FormWindowState.Minimized)
                        childForm.WindowState = FormWindowState.Normal;
                    childForm.Activate();
                    return true;
                }
            }
            return false;
        }	

        private void menuItem2_Click(object sender, EventArgs e)
        {
            if (this.checkChildFormExist("DailyIncome") == true)
            {
                return;
            }
            DailyIncome newForm = new DailyIncome();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            if (this.checkChildFormExist("MouthIncome") == true)
            {
                return;
            }
            MouthIncome newForm = new MouthIncome();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
            if (this.checkChildFormExist("BillInput") == true)
            {
                return;
            }
            BillInput newForm = new BillInput();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
