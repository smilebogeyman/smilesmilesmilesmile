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
    public partial class DailyIncome : Form
    {
        public DailyIncome()
        {
            InitializeComponent();
        }

        private void DailyIncome_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“marketdbDataSet.items”中。您可以根据需要移动或删除它。
            this.itemsTableAdapter.Fill(this.marketdbDataSet.items);
            // TODO: 这行代码将数据加载到表“marketdbDataSet.bills”中。您可以根据需要移动或删除它。
            this.billsTableAdapter.Fill(this.marketdbDataSet.bills);
            // TODO: 这行代码将数据加载到表“marketdbDataSet.itemsList”中。您可以根据需要移动或删除它。
            this.itemsListTableAdapter.Fill(this.marketdbDataSet.itemsList);
            
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            if (e.Button.ToolTipText == "首记录")
            {
                dataGridView1.Rows[0].Selected = true;
                dataGridView1.CurrentCell = dataGridView1[0, 0];
                String billId = dataGridView1.Rows[0].Cells[1].Value.ToString();
                itemListTobill(billId);
                String itemId = dataGridView1.Rows[0].Cells[2].Value.ToString();
                itemListToitem(itemId);
            }
            if (e.Button.ToolTipText == "上一记录")
            {
                int i = dataGridView1.SelectedRows[0].Index;
                if (i != 0)
                {
                    dataGridView1.Rows[i].Selected = false;
                    dataGridView1.Rows[i - 1].Selected = true;
                    i = i - 1;
                    dataGridView1.CurrentCell = dataGridView1[0, i];
                    String billId = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    itemListTobill(billId);
                    String itemId = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    itemListToitem(itemId);
                }
                else
                {
                    MessageBox.Show("已经是首记录了！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (e.Button.ToolTipText == "下一记录")
            {
                int i = dataGridView1.SelectedRows[0].Index;
                if (i < dataGridView1.Rows.Count - 1)
                {
                    dataGridView1.Rows[i].Selected = false;
                    dataGridView1.Rows[i + 1].Selected = true;
                    i = i + 1;
                    dataGridView1.CurrentCell = dataGridView1[0, i];
                    String billId = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    itemListTobill(billId);
                    String itemId = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    itemListToitem(itemId);
                }
                else
                {
                    MessageBox.Show("已经是尾记录了！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (e.Button.ToolTipText == "尾记录")
            {
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
                dataGridView1.CurrentCell = dataGridView1[0, dataGridView1.Rows.Count - 1];
                String billId = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value.ToString();
                itemListTobill(billId);
                String itemId = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value.ToString();
                itemListToitem(itemId);
            }
            if (e.Button.ToolTipText == "退出")
            {
                this.Dispose();
            }
        }
        private void itemListTobill(String itemId1)
        {
            String itemId2;
            for (int i = 0; i <= dataGridView2.Rows.Count - 1; i++)
            {
                if (dataGridView2.Rows[i].Selected == true)
                {
                    dataGridView2.Rows[i].Selected = false; ;
                }
                itemId2 = dataGridView2.Rows[i].Cells[0].Value.ToString();
                if (itemId1.Equals(itemId2))
                {
                    dataGridView2.Rows[i].Selected = true;
                    dataGridView2.CurrentCell = dataGridView2[0, i];
                }
            }
        }

        private void itemListToitem(String itemId1)
        {
            String itemId2;
            for (int i = 0; i <= dataGridView3.Rows.Count - 1; i++)
            {
                if (dataGridView3.Rows[i].Selected == true)
                {
                    dataGridView3.Rows[i].Selected = false; ;
                }
                itemId2 = dataGridView3.Rows[i].Cells[0].Value.ToString();
                if (itemId1.Equals(itemId2))
                {
                    dataGridView3.Rows[i].Selected = true;
                    dataGridView3.CurrentCell = dataGridView3[0, i];
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = this.dataGridView1.CurrentRow.Index;
            String billId = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            itemListTobill(billId);
            String itemId = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            itemListToitem(itemId);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String itemListId = textBox1.Text;
            String billId = textBox2.Text;
            String itemId = textBox3.Text;
            String itemListId2;
            String billId2;
            String itemId2;
            bool isExist = false;
            if (!itemListId.Equals("") && billId.Equals("") && itemId.Equals(""))
            {
                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Selected == true)
                    {
                        dataGridView1.Rows[i].Selected = false; ;
                    }
                    itemListId2 = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    if (itemListId2.Equals(itemListId))
                    {
                        dataGridView1.Rows[i].Selected = true;
                        dataGridView1.CurrentCell = dataGridView1[1, i];
                        isExist = true;
                        billId = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        itemId = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        itemListTobill(billId);
                        itemListToitem(itemId);
                    }
                }
            }
            else if (itemListId.Equals("") && !billId.Equals("") && itemId.Equals(""))
            {
                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Selected == true)
                    {
                        dataGridView1.Rows[i].Selected = false; ;
                    }
                    billId2 = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    if (billId2.Equals(billId))
                    {
                        dataGridView1.Rows[i].Selected = true;
                        dataGridView1.CurrentCell = dataGridView1[1, i];
                        isExist = true;
                        billId = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        itemId = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        itemListTobill(billId);
                        itemListToitem(itemId);
                        DialogResult result = MessageBox.Show("是否要继续查找", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (i == dataGridView1.Rows.Count - 1)
                        {
                            MessageBox.Show("已经是最后一个", "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                        if (result == DialogResult.No)
                        {
                            return;
                        }
                    }
                }
            }
            else if (itemListId.Equals("") && billId.Equals("") && !itemId.Equals(""))
            {
                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Selected == true)
                    {
                        dataGridView1.Rows[i].Selected = false; ;
                    }
                    itemId2 = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    if (itemId2.Equals(itemId))
                    {
                        dataGridView1.Rows[i].Selected = true;
                        dataGridView1.CurrentCell = dataGridView1[1, i];
                        isExist = true;
                        billId = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        itemId = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        itemListTobill(billId);
                        itemListToitem(itemId);
                        DialogResult result = MessageBox.Show("是否要继续查找", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (i == dataGridView1.Rows.Count - 1)
                        {
                            MessageBox.Show("已经是最后一个", "提示", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                        if (result == DialogResult.No)
                        {
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("只能有一个不为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!isExist)
            {
                MessageBox.Show("没有符合条件的商品销售信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String time = this.dateTimePicker1.Text.ToString();
            float totalprice = 0;
            float itemPrice;
            for (int i = 0; i <= dataGridView2.Rows.Count-1; i++)
            {
                String time2 = this.dataGridView2.Rows[i].Cells[2].Value.ToString().Substring(0, 8);
                Console.WriteLine(time2);
                if(time2.Equals(time))
                {
                    itemPrice = float.Parse(dataGridView2.Rows[i].Cells[1].Value.ToString());
                    totalprice = totalprice + itemPrice;
                }
            }
            this.textBox4.Text = totalprice.ToString();

        }

    }
}
