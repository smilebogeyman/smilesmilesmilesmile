using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Security.Cryptography;

namespace DBProject
{
    public partial class AddAccount : Form
    {
        DBOperation op;
        public AddAccount()
        {
            InitializeComponent();
            this.addname.Text = "";
            this.addpass.Text = "";
            this.addPri.Text = "";
                
        }

       
      public static string MD5(String str)
      {
          MD5 md5 = new MD5CryptoServiceProvider();
          byte[] data = System.Text.Encoding.Default.GetBytes(str);
          byte[] result = md5.ComputeHash(data);
          String ret = "";
          for (int i = 0; i < result.Length; i++)
              ret += result[i].ToString("x").PadLeft(2, 'x');

          for (int i = 0; i < result.Length; i++)
              ret += result[i].ToString("0").PadLeft(3, '5');

          return ret;
      } 


        private void button1_Click(object sender, EventArgs e)
        {

            if(this.addname.Text == "")
            {
                MessageBox.Show("请输入用户名");
                return;
            }
            if(this.addpass.Text == "")
            {
                MessageBox.Show("请输入密码");
                return;
            }

            if (this.addrepass.Text == "")
            {
                MessageBox.Show("请输入密码");
                return;
            }

            if (this.privilege.Text == "")
            {
                MessageBox.Show("请选择权限");
                return;
            }

            if (this.addname.Text.Length > 16 || this.addname.Text.Length < 6)
            {
                MessageBox.Show("用户名应为6至16位");
                return;
            }

            if (this.addpass.Text.Length > 20 || this.addpass.Text.Length < 6)
            {
                MessageBox.Show("密码应为6至20位");
                return;
            }

            if(!this.addpass.Text.Equals(this.addrepass.Text))
            {
                MessageBox.Show("两次输入密码不匹配");
                return;
            }
            
            op = new DBOperation();
            String check = "select * from loginInfo where userName='" + this.name.Text + "'";
            DataTable search = op.getDataTable(check, "loginInfo");
            if (search.Rows.Count != 0)
            {
                MessageBox.Show("该用户名已存在");
                return;
            }

            String md5 = MD5(this.addpass.Text);

            op = new DBOperation();
            String addAccount = "insert into loginInfo(userName, password, privilege) values('" + this.addname.Text
                + "', '" + md5 + "', " + this.addPri.Text + ")";
            MessageBox.Show(md5);
            if (op.singleOperation(addAccount))
            {
                this.addname.Text = "";
                this.addpass.Text = "";
                this.addPri.Text = "";
                
                MessageBox.Show("添加成功");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void repassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }
    }
}
