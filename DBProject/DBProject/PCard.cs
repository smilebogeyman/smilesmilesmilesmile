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
    public partial class PCard : Form
    {
        public PCard()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login.cards.Visible = true;
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Save save = new Save();
            save.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.ShowDialog();
        }
        /*
        private void button3_Click(object sender, EventArgs e)
        {
            Consume consume = new Consume();
            consume.ShowDialog();
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            Query query = new Query();
            query.ShowDialog();
        }
    }
}
