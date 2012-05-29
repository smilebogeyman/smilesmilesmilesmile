using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace face
{
    public partial class worker : Form
    {
        public worker()
        {
            InitializeComponent();
            lvWorker.GridLines = true;
            lvWorker.FullRowSelect = true;
            lvWorker.View = View.Details;
            lvWorker.Clear();
            lvWorker.Columns.Add("员工号", 100, HorizontalAlignment.Center);
            lvWorker.Columns.Add("姓名", 100, HorizontalAlignment.Center);
            lvWorker.Columns.Add("性别", 100, HorizontalAlignment.Center);
            lvWorker.Columns.Add("年龄", 100, HorizontalAlignment.Center);
            lvWorker.Columns.Add("工资", 100, HorizontalAlignment.Center);
            lvWorker.Columns.Add("起聘日期", 100, HorizontalAlignment.Center);
            lvWorker.Columns.Add("工作部门", 100, HorizontalAlignment.Center);         
            lvWorker.ColumnClick += new ColumnClickEventHandler(lvWorker_ColumnClick);
           // tv_worker.Click += new System.EventHandler(tv_worker_NodeMouseDoubleClick);
            
        }
        private void AddlistViewItem(string id, string name, String gender, int age, int salary, string date, string department)
        {            
            ListViewItem item = new ListViewItem(
                new string[] { id, name, gender, age.ToString(), salary.ToString(), date ,department});
            lvWorker.Items.Add(item);
        }
        private void tv_worker_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            if (node.GetNodeCount(false) == 0)
            {
                String name = node.Text;
                tbMain.Visible = false;
                lvWorker.Visible = true;
                btnAdd.Visible = true;
                btnDelete.Visible = true;
                btnmodify.Visible = true;
                btnSearch.Visible = true;
                tbSearch.Visible = true;
               

                 
            }  

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lvWorker.SelectedItems.Count;  
            tbSearch.Clear();
            if (i < 1)
            {
                MessageBox.Show(" Please seleted an item first!");
            }
            else
            {

                for (int j = lvWorker.SelectedItems.Count - 1; j >= 0; j--)
                {
                    ListViewItem item = lvWorker.SelectedItems[j];
                    lvWorker.Items.Remove(item);
                }
            }
        }

        private void worker_Load(object sender, EventArgs e)
        {
            tbMain.Visible = true;
            lvWorker.Visible = false;
            btnAdd.Visible = false;
            btnDelete.Visible = false;
            btnmodify.Visible = false;
            btnSearch.Visible = false;
            tbSearch.Visible = false;
            plInfo.Visible = false;
        }

        private void lvWorker_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (lvWorker.Sorting == SortOrder.Descending)
            {
                lvWorker.Sorting = SortOrder.Ascending;
            }
            else
            {
                lvWorker.Sorting = SortOrder.Descending;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tbSearch.Clear();
            /*tbMain.Visible = true;
            lvWorker.Visible = false;
            btnAdd.Visible = false;
            return_to_main.Visible = false;
            btnDelete.Visible = false;
            btnmodify.Visible = false;
            btnSearch.Visible = false;
            tbSearch.Visible = false;
            plInfo.Visible = false;*/
            this.Dispose();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            tbAge.Clear();
            tbDepart.Clear();
            tbGender.Clear();
            tbID.Clear();            
            tbName.Clear();
            tbSalary.Clear();
            tbSearch.Clear();
            tbStart.Clear();
            plInfo.Visible = true;            
        }

        private void tv_worker_Click(object sender, EventArgs e)
        {
            

        }
        private void deleteAllItems()
        {
            for (int i = lvWorker.Items.Count; i > 0; i--)
            {

                lvWorker.Items.Remove(lvWorker.Items[i - 1]);
            }
        
        }

        private void tv_worker_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = tv_worker.SelectedNode;
            string nodeText = node.Text;/*获得子节点的名称*/
            //tbSearch.Text = nodeText;
            if (nodeText.Equals("Finance department"))
            {
               // lvWorker.Items.RemoveAt(1);
                //lvWorker.Items.RemoveAt(0);
                //lvWorker.Items.RemoveAt(2);
                //lvWorker.Items.
                deleteAllItems();
                AddlistViewItem("20080102", "张三", "女", 56, 4000, "1889.12.12", "finance");
                AddlistViewItem("20080104", "李四", "男", 45, 1000, "1993.12.12", "finance");
                AddlistViewItem("20080103", "王五", "女", 37, 2000, "1995.12.12", "finance");

            }
            if (nodeText.Equals("Facility department"))
            {
                //lvWorker.Clear();
                deleteAllItems();
                AddlistViewItem("20080102", "张三", "女", 56, 4000, "1889.12.12", "facility");
                AddlistViewItem("20080104", "李四", "男", 45, 1000, "1993.12.12", "facility");
                AddlistViewItem("20080103", "王五", "女", 37, 2000, "1995.12.12", "facility");

            }
            if (nodeText.Equals("Sale department"))
            {
                //lvWorker.Clear();
                deleteAllItems();
                AddlistViewItem("20080102", "张三", "女", 56, 4000, "1889.12.12", "Sale");
                AddlistViewItem("20080104", "李四", "男", 45, 1000, "1993.12.12", "Sale");
                AddlistViewItem("20080103", "王五", "女", 37, 2000, "1995.12.12", "Sale");

            }
            if (nodeText.Equals("Purchsing department"))
            {
                //lvWorker. .Clear();
                deleteAllItems();
                AddlistViewItem("20080102", "张三", "女", 56, 4000, "1889.12.12", "purchasing");
                AddlistViewItem("20080104", "李四", "男", 45, 1000, "1993.12.12", "purchasing");
                AddlistViewItem("20080103", "王五", "女", 37, 2000, "1995.12.12", "purchasing");

            }
            else if (nodeText.Equals("Personnel department"))
            {
                //lvWorker.Clear()
                deleteAllItems(); ;
                AddlistViewItem("20080102", "张三", "女", 56, 4000, "1889.12.12", "personnel");
                AddlistViewItem("20080104", "李四", "男", 45, 1000, "1993.12.12", "personnel");
                AddlistViewItem("20080103", "王五", "女", 37, 2000, "1995.12.12", "personnel");

            }
             if (nodeText.Equals("worker department"))
            {

                tbMain.Visible = true;
                lvWorker.Visible = false;
                btnAdd.Visible = false;
                return_to_main.Visible = false;
                btnDelete.Visible = false;
                btnmodify.Visible = false;
                btnSearch.Visible = false;
                tbSearch.Visible = false; 
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
             
        }

        private void btnmodify_Click(object sender, EventArgs e)
        {
            
            /*for (int i = lvWorker.SelectedItems.Count - 1; i >= 0; i--)
            {
                ListViewItem item = lvWorker.SelectedItems[i];
                lvWorker.Items.Remove(item);
            }*/
            tbSearch.Clear();
            int i = lvWorker.SelectedItems.Count;
            if (i > 1)
            {
                MessageBox.Show("more than one selected!");
            }
             if (i < 1)
            {
                MessageBox.Show("No one has been selected!");
            }
            if( i == 1)
            {

                ListViewItem item = lvWorker.SelectedItems[0];
                String ID = item.SubItems[0].Text;
                String name = item.SubItems[1].Text;
                String gender = item.SubItems[2].Text;
                String age = item.SubItems[3].Text;
                string salary = item.SubItems[4].Text;
                String start_date = item.SubItems[5].Text;
                string department = item.SubItems[6].Text;
                tbAge.Text = age;
                tbDepart.Text = department;
                tbGender.Text = gender;
                tbID.Text = ID;
                tbName.Text = name;
                tbSalary.Text = salary;
                tbStart.Text = start_date;
                plInfo.Visible = true;
            }

           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tbSearch.Clear();
            plInfo.Visible = false;
        }

        private void btnback1_Click(object sender, EventArgs e)
        {
            tbSearch.Clear();
            plInfo.Visible = false;
        }

        private void lvWorker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
