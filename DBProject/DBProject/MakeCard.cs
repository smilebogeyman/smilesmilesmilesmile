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
    public partial class makecard : Form
    {
        public makecard()
        {
            InitializeComponent();
        }

        private void Make_Card_Load(object sender, EventArgs e)
        {

        }

        private void Exit_MakeCard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
