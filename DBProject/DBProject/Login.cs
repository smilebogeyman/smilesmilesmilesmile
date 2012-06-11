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
        private AddAccount add;

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
            if (this.name.Text == "")
            {
                MessageBox.Show("请输入用户名");
                return;    
            }
            if (this.pass.Text == "")
            {
                MessageBox.Show("请输入密码");
                return;
            }
                
                
            //1-6权限分别对应售货，员工，收支，购物卡，设备，仓库，0为最高权限，可以进入所有模块
            String checkName = "select * from loginInfo where userName='" + this.name.Text + "'" ;
           
            DBOperation op = new DBOperation();
            DataTable namedt = op.getDataTable(checkName, "loginInfo");
            if (namedt.Rows.Count == 0)
            {
                MessageBox.Show("用户名错误");
                return;
            }

            else
            {
                String password = namedt.Rows[0]["password"].ToString();
                String priv = namedt.Rows[0]["privilege"].ToString();

                String md5pass = AddAccount.MD5(this.pass.Text);

                if (!password.Equals(md5pass))
                {
                    MessageBox.Show("密码错误");
                }
                else
                {
                    if (Welcome.current.Equals("worker"))
                    {
                        if (priv.Equals("2") || priv.Equals("0"))
                        {
                            this.workers = new worker();
                            this.before();
                            this.workers.ShowDialog();
                            this.after();
                            this.workers.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("您没有权限访问此模块");
                            this.name.Text = "";
                            this.pass.Text = "";
                        }
                    }

                    else if (Welcome.current.Equals("card"))
                    {
                        if (priv.Equals("4") || priv.Equals("0"))
                        {
                            cards = new Cards();
                            this.before();
                            cards.ShowDialog();
                            this.after();
                            cards.Dispose();
                        }

                        else
                        {
                            MessageBox.Show("您没有权限访问此模块");
                            this.name.Text = "";
                            this.pass.Text = "";
                        }
                    }

                    else if (Welcome.current.Equals("warehouse"))
                    {
                        if (priv.Equals("6") || priv.Equals("0"))
                        {
                            dep = new Depository();
                            this.before();
                            dep.ShowDialog();
                            this.after();
                            dep.Dispose();
                        }

                        else
                        {
                            MessageBox.Show("您没有权限访问此模块");
                            this.name.Text = "";
                            this.pass.Text = "";
                        }
                    }

                    else if (Welcome.current.Equals("facility"))
                    {
                        if (priv.Equals("5") || priv.Equals("0"))
                        {
                            facility = new Facility();
                            this.before();
                            facility.ShowDialog();
                            this.after();
                            facility.Dispose();
                        }

                        else
                        {
                            MessageBox.Show("您没有权限访问此模块");
                            this.name.Text = "";
                            this.pass.Text = "";
                        }
                    }

                    else if (Welcome.current.Equals("information"))
                    {
                        if (priv.Equals("0"))
                        {
                            info = new Information();
                            this.before();
                            info.ShowDialog();
                            this.after();
                            info.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("您没有权限访问此模块");
                            this.name.Text = "";
                            this.pass.Text = "";
                        }
                    }

                    else if (Welcome.current.Equals("finance"))
                    {
                        if (priv.Equals("3") || priv.Equals("0"))
                        {
                            finance = new FinancialForm();
                            this.before();
                            finance.ShowDialog();
                            this.after();
                            finance.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("您没有权限访问此模块");
                            this.name.Text = "";
                            this.pass.Text = "";
                        }
                    }

                    else if (Welcome.current.Equals("sales"))
                    {
                        if (priv.Equals("1") || priv.Equals("0"))
                        {
                            sales = new Sales();
                            this.before();
                            sales.ShowDialog();
                            this.after();
                            sales.Dispose();
                        }

                        else
                        {
                            MessageBox.Show("您没有权限访问此模块");
                            this.name.Text = "";
                            this.pass.Text = "";
                        }
                    }

                    else if (Welcome.current.Equals("addCourse"))
                    {
                        if (priv.Equals("0"))
                        {
                            add = new AddAccount();
                            this.before();
                            add.ShowDialog();
                            this.after();
                            add.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("您没有权限访问此模块");
                            this.name.Text = "";
                            this.pass.Text = "";
                        }
                    }
                    
                }
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
