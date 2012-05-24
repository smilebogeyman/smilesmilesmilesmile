using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBProject
{
    public partial class Welcome : Form
    {
        public static Login login ;
        public static String current;

        public Welcome()
        {
            InitializeComponent();
            login = new Login();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void man_workers_Click(object sender, EventArgs e)
        {
            current = "worker";
            login.ShowDialog();
        }

        private void card_Click(object sender, EventArgs e)
        {
            current = "card";
            login.ShowDialog();
        }

        private void finance_Click(object sender, EventArgs e)
        {
            current = "finance";
            login.ShowDialog();
        }

        private void information_Click(object sender, EventArgs e)
        {
            current = "information";
            login.ShowDialog();
        }

        private void facility_Click(object sender, EventArgs e)
        {
            current = "facility";
            login.ShowDialog();
        }

        private void warehouse_Click(object sender, EventArgs e)
        {
            current = "warehouse";
            login.ShowDialog();
        }

        private void sales_Click(object sender, EventArgs e)
        {
            current = "sales";
            login.ShowDialog();
        }

        private void Welcome_FormClosing(object sender, FormClosingEventArgs e)
        {         
            login.Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
