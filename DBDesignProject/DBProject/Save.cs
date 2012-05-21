using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Card
{
    public partial class Save : Form
    {
        public Save()
        {
            InitializeComponent();
        }

        private void SaveMoney_B_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您现有金额……");
        }

        private void ExitSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
