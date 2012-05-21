using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBProject;

namespace Card
{
    public partial class Cards : Form
    {
        public Cards()
        {
            InitializeComponent();
        }

        private void MakeCard_B_Click(object sender, EventArgs e)
        {
            makecard makeCard = new makecard();
            this.Visible = false;
            makeCard.ShowDialog();
            this.Visible = true;
            makeCard.Dispose();
        }

      
        private void Save_B_Click(object sender, EventArgs e)
        {
            Save save = new Save();
            save.Show();
        }


        private void Statement_B_Click(object sender, EventArgs e)
        {
            Statement statement = new Statement();
            statement.ShowDialog();
        }

        private void Exit_B_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Program.main.Visible = true;
        }

        private void login_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Visible = false;
            register.ShowDialog();
        }
    }
}
