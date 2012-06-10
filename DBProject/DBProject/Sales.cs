using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DBProject;

namespace DBProject
{
    public partial class Sales : Form
    {
        SqlCommand SaleCmd;
        SqlDataReader SaleRead;
        public Sales()
        {
            InitializeComponent();//初始化界面
            SaleCmd = new SqlCommand();
            SaleCmd.Connection = DBOperation.conn();//创建SQL连接
            SaleCmd.Connection.Open();              //打开SQL连接
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void PayByCashRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked == false)
                return;
            this.CardIdBox.Enabled = false;     //更改支付方式，选择现金支付
            this.CardIdLabel.Enabled = false;   //更改界面控件
            this.CardPwdBox.Enabled = false;
            this.CardPwdLabel.Enabled = false;
            this.CardUseBox.Enabled = false;
            this.CardUseLabel1.Enabled = false;
            this.CardUseLabel2.Enabled = false;
        }

        private void PayByCardRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked == false)
                return;
            this.CardIdBox.Enabled = true;      //更改支付方式，选择购物卡支付
            this.CardIdLabel.Enabled = true;    //更改界面控件
            this.CardPwdBox.Enabled = true;
            this.CardPwdLabel.Enabled = true;
            this.CardUseBox.Enabled = false;
            this.CardUseLabel1.Enabled = false;
            this.CardUseLabel2.Enabled = false;
        }

        private void PayByCashCardRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked == false)
                return;
            this.CardIdBox.Enabled = true;      //更改支付方式，选择 现金 和 购物卡 同时支付
            this.CardIdLabel.Enabled = true;    //更改界面控件
            this.CardPwdBox.Enabled = true;
            this.CardPwdLabel.Enabled = true;
            this.CardUseBox.Enabled = true;
            this.CardUseLabel1.Enabled = true;
            this.CardUseLabel2.Enabled = true;
        }

        private void AddItemBtn_Click(object sender, EventArgs e)//添加一件商品
        {
            if (!checkSaleInput())              //检查输入的商品ID、商品数量是否正确
                return;

            SaleCmd.CommandText = "select dbo.items.itemName, dbo.items.itemPrice from dbo.items where dbo.items.itemID='"
                + this.itemIDBox.Text+"';";
            SaleRead = SaleCmd.ExecuteReader();
            if (!SaleRead.Read())               //如果所输商品数据库中不存在，则提示错误
            {
                MessageBox.Show("抱歉，没有所输入的商品。");
                SaleRead.Close();
                return;
            }
            else if (this.findInItemList(this.itemIDBox.Text)==-1)//如果所输商品不在右侧输过的目录中
            {                                                     //则在右侧添加新项
                ListViewItem li=new ListViewItem();
                li.Text = this.itemIDBox.Text;//设置商品ID
                li.SubItems.Add(SaleRead[0].ToString());//设置商品名称
                li.SubItems.Add(SaleRead[1].ToString());//设置单价
                li.SubItems.Add(this.itemSumBox.Text);//设置数量
                li.SubItems.Add((double.Parse(this.itemSumBox.Text) * double.Parse(SaleRead[1].ToString())).ToString());//设置合计价格（数量×单价）
                this.SaleList.Items.Add(li);//添加此新条目到右侧
            }
            else if (this.findInItemList(this.itemIDBox.Text) != -1)//如果商品已存在于右表中
            {
                int indexInList = this.findInItemList(this.itemIDBox.Text);//获得商品在右表中的位置
                int currentSum= int.Parse(this.SaleList.Items[indexInList].SubItems[3].Text);//获得当前该商品数量
                this.SaleList.Items[indexInList].SubItems[3].Text = (currentSum + int.Parse(this.itemSumBox.Text)).ToString();//改变已有的数量
                currentSum = int.Parse(this.SaleList.Items[indexInList].SubItems[3].Text);//获得当前该商品数量
                this.SaleList.Items[indexInList].SubItems[4].Text = (currentSum * double.Parse(SaleRead[1].ToString())).ToString();//改变合计价格
                this.SaleList.Items[indexInList].SubItems[2].Text = SaleRead[1].ToString();//设置商品单价(这也可忽略)
            }
            this.itemIDBox.Text = "";//清空ID输入框
            this.itemSumBox.Text = "1";//还原商品默认数量
            this.itemIDBox.Focus();//将光标定到ID输入框中
            SaleRead.Close();//关闭SqlDataReader
            CalculatePice();//计算并显示当前总价
            return;
        }
        //WholePriceBox
        private void CalculatePice()//计算并显示当前总价
        {
            double priceSum = 0;
            for (int i = 0; i < this.SaleList.Items.Count; i++)//循环读取、累加右侧价格
            {
                priceSum += double.Parse(this.SaleList.Items[i].SubItems[4].Text);
            }
            this.WholePriceBox.Text = priceSum.ToString();
        }

        private void itemIDBox_KeyPress(object sender, KeyPressEventArgs e)//限制 ID 和 数量 两框的输入为数字
        {
            if (("1234567890".IndexOf(e.KeyChar) == -1) && (e.KeyChar != '\b'))
                e.Handled = true;
        }
        private bool checkInteger(String intstr)//判断输入字符串是否只包含整型数字
        {
            for (int i = 0; i < intstr.Length;i++ )
            {
                if ("1234567890".IndexOf(intstr[i]) == -1)
                    return false;
            }
            return true;
        }
        private bool checkfloat(String floatstr)//判断输入字符串是否只包含浮点数字
        {
            for (int i = 0; i < floatstr.Length; i++)
            {
                if ("1234567890.".IndexOf(floatstr[i]) == -1)
                    return false;
            }
            if (floatstr.Split('.').Length > 2)
                return false;
            return true;
        }
        private bool checkSaleInput()//判断 ID 和 数量 两输入框的内容是否符合规定
        {
            if (!checkInteger(this.itemIDBox.Text))
            {
                MessageBox.Show("请输入正确的商品识别码！");
                this.itemIDBox.Focus();
                return false;
            }
            else if (this.itemIDBox.Text=="")
            {
                MessageBox.Show("请输入所需商品的识别码");
                this.itemIDBox.Focus();
                return false;
            }
            else if (!checkInteger(this.itemSumBox.Text))
            {
                MessageBox.Show("请输入正确的商品数量！");
                this.itemSumBox.Focus();
                return false;
            }
            else if (int.Parse(this.itemSumBox.Text)==0)
            {
                MessageBox.Show("请输入正确的商品数量！");
                this.itemSumBox.Focus();
                return false;
            }
            return true;
        }
        private int findInItemList(String itemID)//在右侧列表查找商品ID是否存在，若存在，返回位置序号
        {
            for (int i = 0; i < this.SaleList.Items.Count; i++)
            {
                if (this.SaleList.Items[i].SubItems[0].Text.Equals(itemID))
                    return i;
            }
            return -1;
        }

        private void DelBtn_Click(object sender, EventArgs e)//点击删除按钮，删除所选条目（可多选）
        {
            foreach (ListViewItem item in this.SaleList.SelectedItems)
            {
                item.Remove();
            }
            CalculatePice();
        }

        private void SaleList_KeyDown(object sender, KeyEventArgs e)//点击Delete或Backspace按钮，删除所选条目（可多选）
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                DelBtn_Click(sender, e);
            }
        }

        private void itemIDBox_KeyDown(object sender, KeyEventArgs e)//若在 ID 或 数量按回车，则执行添加商品命令
        {
            if (e.KeyCode == Keys.Enter)
                AddItemBtn_Click(sender, e);
        }

        private bool checkCardInput()//判断购物卡各框的输入是否正确
        {
            if(this.PayByCashCardRadio.Checked)
            {
                if (!checkfloat(this.CardUseBox.Text))
                {
                    MessageBox.Show("购物卡使用金额输入错误...\n请重新输入。");
                    return false;
                }
                else if (float.Parse(this.CardUseBox.Text) > float.Parse(this.WholePriceBox.Text))
                {
                    MessageBox.Show("购物卡使用金额超过所需支付金额...\n请重新输入。");
                    return false;
                }
            }
            return true;
        }

        private void CheckOut_Click(object sender, EventArgs e)//点击支付按钮，启动支付流程
        {
            if (this.WholePriceBox.Text == "0")//如果商品数为0，则提示并结束支付流程
            {
                MessageBox.Show("当前未输入任何商品。");
                this.itemSumBox.Focus();
                return;
            }

            if (this.PayByCashRadio.Checked)//如果只用现金支付，则提示支付额，然后结束支付流程
            {
                MessageBox.Show("需收现金：" + this.WholePriceBox.Text + " 元");
                SaveBill();
                ClearAll();//支付完毕，还原界面上的信息，退出支付流程
                return;
            }

            if (!checkCardInput())//如果购物卡框有错误输入，则提示并结束支付流程
                return;

            float cardAmount;
            SaleCmd.CommandText = "select dbo.cards.cardID, dbo.cards.amount from dbo.cards where dbo.cards.cardID='"
                + this.CardIdBox.Text + "'and dbo.cards.password='"+this.CardPwdBox.Text+"';";
            SaleRead = SaleCmd.ExecuteReader();//查询所输购物卡信息
            if (!SaleRead.Read())
            {
                MessageBox.Show("抱歉，卡号或密码错误...\n请重新输入。");
                SaleRead.Close();
                return;
            }
            else
            {
                cardAmount = float.Parse(SaleRead[1].ToString());//获得购物卡余额
                SaleRead.Close();
            }

            if(this.PayByCardRadio.Checked)//进入仅用”购物卡“的支付流程
            {
                if (cardAmount < float.Parse(this.WholePriceBox.Text))
                {
                    MessageBox.Show("卡内余额不足，支付失败...");
                    return;
                }
                else
                {
                    SaleCmd.CommandText = "update dbo.cards set dbo.cards.amount = dbo.cards.amount - "
                        + this.WholePriceBox.Text + " where dbo.cards.cardID='" + this.CardIdBox.Text + "';";
                    SaleCmd.ExecuteNonQuery();
                    MessageBox.Show("支付成功！");
                }
            }
            else if (this.PayByCashCardRadio.Checked)//进入”现金+购物卡“的支付流程
            {
                if (cardAmount < float.Parse(this.CardUseBox.Text))
                {
                    MessageBox.Show("卡内余额不足，支付失败...");
                    return;
                }
                else
                {
                    SaleCmd.CommandText = "update dbo.cards set dbo.cards.amount = dbo.cards.amount - "
                        + this.CardUseBox.Text + " where dbo.cards.cardID='" + this.CardIdBox.Text + "';";
                    SaleCmd.ExecuteNonQuery();
                    MessageBox.Show("购物卡支付成功！请支付现金 "
                        + (float.Parse(this.WholePriceBox.Text) - float.Parse(this.CardUseBox.Text)).ToString()
                        + " 元");
                }
            }
            SaveBill();
            ClearAll();//支付完毕，还原界面上的信息，退出支付流程
        }
        private void CardUseBox_KeyPress(object sender, KeyPressEventArgs e)//限制 购物卡使用金额框 的输入为浮点型
        {
            if (("1234567890.".IndexOf(e.KeyChar) == -1) && (e.KeyChar != '\b'))
                e.Handled = true;            
        }
        private void ClearAll()//还原界面上的信息
        {
            foreach (ListViewItem item in this.SaleList.Items)
            {
                item.Remove();
            }
            this.PayByCashRadio.Checked = true;
            this.CardPwdBox.Clear();
            this.CardIdBox.Clear();
            this.CardUseBox.Clear();
            this.WholePriceBox.Text = "0";
        }
        private bool SaveBill()//保存交易信息到数据库中itemsList和bills两表
        {
            SaleCmd.CommandText = "insert into dbo.bills (sumPrice)values("
            +this.WholePriceBox.Text+"); select cast(scope_identity() as int);";
            String currBillId = SaleCmd.ExecuteScalar().ToString();//保存到bills并获得billID
            SaleCmd.CommandText="";
            for (int i = 0; i < this.SaleList.Items.Count; i++)
            {
                SaleCmd.CommandText += "insert into dbo.itemsList (billID, itemID, itemNum)values('"
                    + currBillId + "', '"                               //billID作为itemsList的foreign key
                    + this.SaleList.Items[i].SubItems[0].Text + "', '"
                    + this.SaleList.Items[i].SubItems[3].Text + "');";
            }
            SaleCmd.ExecuteNonQuery();
            return true;
        }
    }
}
