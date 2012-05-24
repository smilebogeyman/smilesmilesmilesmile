using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using face;
using Card;
using WindowsFormsApplication1;
using facility;
using DBCourse;
using finance;

namespace DBProject
{
    public partial class Login : Form
    {

        private worker workers;
        static public Cards cards;
        private Depository dep;
        private Facility facility;
        private Information info;
        private FinancialForm finance;
        private Sales sales;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            this.name.Clear();
            this.pass.Clear();
        }


        private void submit_Click(object sender, EventArgs e)
        {
           if (Welcome.current.Equals("worker"))
            {
                //need some validation here.
                
                this.workers = new worker();               
                this.before();
                this.workers.ShowDialog();
                this.after();
                this.workers.Dispose();
            }
               
           else if (Welcome.current.Equals("card"))
           {
               cards = new Cards();
               this.before();
               cards.ShowDialog();
               this.after();
               cards.Dispose();
           }

           else if (Welcome.current.Equals("warehouse"))
           {
               dep = new Depository();
               this.before();
               dep.ShowDialog();
               this.after();
               dep.Dispose();
           }

           else if (Welcome.current.Equals("facility"))
           {
               facility = new Facility();
               this.before();
               facility.ShowDialog();
               this.after();
               facility.Dispose();
           }

           else if (Welcome.current.Equals("information"))
           {
               info = new Information();
               this.before();
               info.ShowDialog();
               this.after();
               info.Dispose();
           }

           else if (Welcome.current.Equals("finance"))
           {
               finance = new FinancialForm();
               this.before();
               finance.ShowDialog();
               this.after();
               finance.Dispose();
           }

           else if (Welcome.current.Equals("sales"))
           {
               sales = new Sales();
               this.before();
               sales.ShowDialog();
               this.after();
               sales.Dispose();
           }

        }



        private void before()
        {
            Program.main.Visible = false;
            Welcome.login.Visible = false;
            Welcome.login.name.Clear();
            Welcome.login.pass.Clear();
        }

        private void after()
        {
            Program.main.Visible = true;
        }
    }
}
