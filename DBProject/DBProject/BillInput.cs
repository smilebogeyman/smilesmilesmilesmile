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
    public partial class BillInput : Form
    {
        private String operation = "";
        public BillInput()
        {
            InitializeComponent();
        }

        private void BillInput_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“marketdbDataSet.outcome”中。您可以根据需要移动或删除它。
            this.outcomeTableAdapter.Fill(this.marketdbDataSet.outcome);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            if (e.Button.ToolTipText == "首记录")
            {
                dataGridView1.Rows[0].Selected = true;
                dataGridView1.CurrentCell = dataGridView1[0, 0];
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
            }
            if (e.Button.ToolTipText == "新增")
            {
                operation = "新增";
                this.textBox2.ReadOnly = false;
                this.textBox3.ReadOnly = false;
            }
            if(e.Button.ToolTipText == "修改")
            {
                operation = "修改";
                this.textBox2.ReadOnly = false;
                this.textBox3.ReadOnly = false;
            }
            if (e.Button.ToolTipText == "删除")
            {
                int outcomeId = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                DialogResult result = MessageBox.Show("确定要删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.outcomeTableAdapter.DeleteQuery(outcomeId);
                    this.outcomeTableAdapter.Fill(this.marketdbDataSet.outcome);
                }
                else
                {
                    return;
                }
            }
            if (e.Button.ToolTipText == "提交")
            {
                if (textBox2.Text.Equals("") || comboBox2.Text.Equals("") || comboBox4.Text.Equals(""))
                {
                    MessageBox.Show("不能有空项！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                float amount = float.Parse(this.textBox2.Text.ToString());
                String type = comboBox2.Text.ToString();
                if (type.Equals("其他"))
                {
                    type = textBox3.Text.ToString();
                }
                String department = comboBox4.Text.ToString();
                String time = this.dateTimePicker1.Text.ToString();
                time = String.Format("{0}-{1}-{2}", time.Substring(0, 4), time.Substring(5, 1), time.Substring(7, 1));
                DateTime dt = DateTime.Parse(time);
                if (operation == "新增")
                {
                    this.outcomeTableAdapter.Insert(amount, type, department,dt);
                }
                else if (operation == "修改")
                {
                    int outcomeId = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    this.outcomeTableAdapter.UpdateQuery(amount, type, department, time, outcomeId,outcomeId);
                }
                else
                {
                    return;
                }
                outcomeTableAdapter.Fill(marketdbDataSet.outcome);
                this.textBox2.Text = "";
                this.textBox2.ReadOnly = true;
                this.textBox3.Text = "";
                this.textBox3.ReadOnly = true;
                this.comboBox2.Text = "";
                this.comboBox4.Text = "";
            }
            if (e.Button.ToolTipText == "取消")
            {
                this.textBox2.Text = "";
                this.textBox2.ReadOnly = true;
                this.textBox3.Text = "";
                this.textBox3.ReadOnly = true;
                this.comboBox2.Text = "";
                this.comboBox4.Text = "";
            }
            if (e.Button.ToolTipText == "退出")
            {
                this.Dispose();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String outcomeId = textBox1.Text;
            String department = comboBox1.Text;
            String outcomeId2;
            String department2;
            bool isExist = false;
            if (!outcomeId.Equals("") && !department.Equals(""))
            {
                MessageBox.Show("只能有一个不为空","提示",MessageBoxButtons.OK,MessageBoxIcon.Question);
                return;
            }
            else if(!outcomeId.Equals(""))
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Selected == true)
                    {
                        dataGridView1.Rows[i].Selected = false; ;
                    }
                    outcomeId2 = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    if (outcomeId2.Equals(outcomeId))
                    {
                        dataGridView1.Rows[i].Selected = true;
                        dataGridView1.CurrentCell = dataGridView1[1, i];
                        isExist = true;
                    }
                }
            }
            else if (!department.Equals(""))
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Selected == true)
                    {
                        dataGridView1.Rows[i].Selected = false; ;
                    }
                    department2 = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    if (department2.Equals(department))
                    {
                        dataGridView1.Rows[i].Selected = true;
                        dataGridView1.CurrentCell = dataGridView1[1, i];
                        isExist = true;
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
            if (!isExist)
            {
                MessageBox.Show("没有符合条件的商品销售信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
