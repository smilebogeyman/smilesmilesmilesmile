using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DBProject;

namespace face
{
    public partial class worker : Form
    {
        private DBOperation db;
        public worker()
        {
            InitializeComponent();
            db = new DBOperation();
            lvWorker.GridLines = true;
            lvWorker.FullRowSelect = true;
            lvWorker.View = View.Details;
            lvWorker.Clear();
            lvWorker.Columns.Add("员工号", 100, HorizontalAlignment.Center);
            lvWorker.Columns.Add("姓", 100, HorizontalAlignment.Center);
            lvWorker.Columns.Add("名", 100, HorizontalAlignment.Center);
            lvWorker.Columns.Add("性别", 100, HorizontalAlignment.Center);
            //lvWorker.Columns.Add("年龄", 100, HorizontalAlignment.Center);
            lvWorker.Columns.Add("工资", 100, HorizontalAlignment.Center);
            lvWorker.Columns.Add("职称", 100, HorizontalAlignment.Center);
            lvWorker.Columns.Add("工作部门", 100, HorizontalAlignment.Center);         
            lvWorker.ColumnClick += new ColumnClickEventHandler(lvWorker_ColumnClick);
           // tv_worker.Click += new System.EventHandler(tv_worker_NodeMouseDoubleClick);
            
        }
        /*想listview中添加数据的函数*/
        private void AddlistViewItem(string id, string firstname, string lastname, String gender, string salary, string date, string department)
        {            
            ListViewItem item = new ListViewItem(
                new string[] { id, firstname, lastname, gender.ToString(), salary.ToString(), date ,department});
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
                //这里要改，不能只将显示的信息删除，而要从数据库中删除
               for (int j = lvWorker.SelectedItems.Count - 1; j >= 0; j--)
                {
                    ListViewItem item = lvWorker.SelectedItems[j];
                    lvWorker.Items.Remove(item);
                    string id = item.SubItems[0].Text;
                   int idint =Convert.ToInt32(id);
                    String dsql = "delete from workers where workerID="+idint;
                    if (db.singleOperation(dsql))
                    {
                        ClearText();
                        MessageBox.Show("删除成功！");
                    }
                    else { MessageBox.Show("删除失败"); }
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

            tbGender.Clear();
            tbDepart.Clear();
            tbLast.Clear();
            //tbID.Clear();            
            tbFirst.Clear();
            //tbSalary.Clear();
            tbSearch.Clear();
            //tbStart.Clear();
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
            tbSearch.Clear();
            String query = "select * from workers";
            DataTable wdt = db.getDataTable(query,"workers");
            TreeNode node = tv_worker.SelectedNode;
            int number = wdt.Rows.Count;
            string nodeText = node.Name;/*获得子节点的名称*/
            
            if (nodeText.Equals("personnel"))
            {
               // lvWorker.Items.RemoveAt(1);                 
               tbSearch.Text = nodeText;
                deleteAllItems();
                for (int i = 0; i < number; )
                {
                    String qposition = "select * from position where positionID=" + wdt.Rows[i]["positionID"];
                    DataTable pdt = db.getDataTable(qposition, "position");
                     
                    if (pdt.Rows[0]["department"].ToString().Equals("personnel"))
                    {
                        AddlistViewItem(wdt.Rows[i]["workerID"].ToString(), wdt.Rows[i]["firstName"].ToString(), wdt.Rows[i]["lastName"].ToString(), ctogender(wdt.Rows[i]["gender"].ToString()), pdt.Rows[0]["salary"].ToString(), pdt.Rows[0]["positionName"].ToString(), pdt.Rows[0]["department"].ToString());
                        i++;
                    }
                    else
                        i++;
                    

                }
            }
            if (nodeText.Equals("commodity"))
            {

                deleteAllItems();
                for (int i = 0; i < number; )
                {
                    String qposition = "select * from position where positionID=" + wdt.Rows[i]["positionID"];
                    DataTable pdt = db.getDataTable(qposition, "position");

                    if (pdt.Rows[0]["department"].ToString().Equals("commodity"))
                    {
                        AddlistViewItem(wdt.Rows[i]["workerID"].ToString(), wdt.Rows[i]["firstName"].ToString(), wdt.Rows[i]["lastName"].ToString(), ctogender(wdt.Rows[i]["gender"].ToString()), pdt.Rows[0]["salary"].ToString(), pdt.Rows[0]["positionName"].ToString(), pdt.Rows[0]["department"].ToString());
                        i++;
                    }
                    else
                        i++;


                }
            }
            if (nodeText.Equals("technology"))
            {
                deleteAllItems();
                for (int i = 0; i < number; )
                {
                    String qposition = "select * from position where positionID=" + wdt.Rows[i]["positionID"];
                    DataTable pdt = db.getDataTable(qposition, "position");

                    if (pdt.Rows[0]["department"].ToString().Equals("technology"))
                    {
                        AddlistViewItem(wdt.Rows[i]["workerID"].ToString(), wdt.Rows[i]["firstName"].ToString(), wdt.Rows[i]["lastName"].ToString(), ctogender(wdt.Rows[i]["gender"].ToString()), pdt.Rows[0]["salary"].ToString(), pdt.Rows[0]["positionName"].ToString(), pdt.Rows[0]["department"].ToString());
                        i++;
                    }
                    else
                        i++;


                }
            }
            if (nodeText.Equals("security"))
            {
                deleteAllItems();
                for (int i = 0; i < number; )
                {
                    String qposition = "select * from position where positionID=" + wdt.Rows[i]["positionID"];
                    DataTable pdt = db.getDataTable(qposition, "position");

                    if (pdt.Rows[0]["department"].ToString().Equals("security"))
                    {
                        AddlistViewItem(wdt.Rows[i]["workerID"].ToString(), wdt.Rows[i]["firstName"].ToString(), wdt.Rows[i]["lastName"].ToString(), ctogender(wdt.Rows[i]["gender"].ToString()), pdt.Rows[0]["salary"].ToString(), pdt.Rows[0]["positionName"].ToString(), pdt.Rows[0]["department"].ToString());
                        i++;
                    }
                    else
                        i++;


                }
            }
            else if (nodeText.Equals("service"))
            {
                deleteAllItems();
                for (int i = 0; i < number; )
                {
                    String qposition = "select * from position where positionID=" + wdt.Rows[i]["positionID"];
                    DataTable pdt = db.getDataTable(qposition, "position");

                    if (pdt.Rows[0]["department"].ToString().Equals("service"))
                    {
                        AddlistViewItem(wdt.Rows[i]["workerID"].ToString(), wdt.Rows[i]["firstName"].ToString(), wdt.Rows[i]["lastName"].ToString(), ctogender(wdt.Rows[i]["gender"].ToString()), pdt.Rows[0]["salary"].ToString(), pdt.Rows[0]["positionName"].ToString(), pdt.Rows[0]["department"].ToString());
                        i++;
                    }
                    else
                        i++;


                }
            }
            else if (nodeText.Equals("office"))
            {
                deleteAllItems();
                for (int i = 0; i < number; )
                {
                    String qposition = "select * from position where positionID=" + wdt.Rows[i]["positionID"];
                    DataTable pdt = db.getDataTable(qposition, "position");

                    if (pdt.Rows[0]["department"].ToString().Equals("office"))
                    {
                        AddlistViewItem(wdt.Rows[i]["workerID"].ToString(), wdt.Rows[i]["firstName"].ToString(), wdt.Rows[i]["lastName"].ToString(), ctogender(wdt.Rows[i]["gender"].ToString()), pdt.Rows[0]["salary"].ToString(), pdt.Rows[0]["positionName"].ToString(), pdt.Rows[0]["department"].ToString());
                        i++;
                    }
                    else
                        i++;


                }
            }
            else if (nodeText.Equals("sales"))
            {
                deleteAllItems();
                for (int i = 0; i < number; )
                {
                    String qposition = "select * from position where positionID=" + wdt.Rows[i]["positionID"];
                    DataTable pdt = db.getDataTable(qposition, "position");

                    if (pdt.Rows[0]["department"].ToString().Equals("sales"))
                    {
                        AddlistViewItem(wdt.Rows[i]["workerID"].ToString(), wdt.Rows[i]["firstName"].ToString(), wdt.Rows[i]["lastName"].ToString(), ctogender(wdt.Rows[i]["gender"].ToString()), pdt.Rows[0]["salary"].ToString(), pdt.Rows[0]["positionName"].ToString(), pdt.Rows[0]["department"].ToString());
                        i++;
                    }
                    else
                        i++;


                }
            }
            /*显示所有的员工信息*/
             if (nodeText.Equals("worker_info"))
            {
                tbMain.Visible = false;
                lvWorker.Visible = true;
                btnAdd.Visible = true;
                return_to_main.Visible = true;
                btnDelete.Visible = true;
                btnmodify.Visible = true;
                btnSearch.Visible = true;
                tbSearch.Visible = true;                
                deleteAllItems();
                for (int i = 0; i < number; i++)
                {
                    String qposition = "select * from position where positionID=" + wdt.Rows[i]["positionID"];
                    DataTable pdt = db.getDataTable(qposition, "position");                    
                        AddlistViewItem(wdt.Rows[i]["workerID"].ToString(), wdt.Rows[i]["firstName"].ToString(), wdt.Rows[i]["lastName"].ToString(), ctogender(wdt.Rows[i]["gender"].ToString()), pdt.Rows[0]["salary"].ToString(), pdt.Rows[0]["positionName"].ToString(), pdt.Rows[0]["department"].ToString());


                }

            }
            
        }
        private string ctogender(string m)
        {
            if (m != null)
            {
                if (m.Equals("True"))
                    return "M";
                else if (m.Equals("False"))
                    return "F";
                else
                    return " ";
            }
            else
                return " ";

        }     
        //根据名字进行查询
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //tbSearch.Clear();
            string searchname = tbSearch.Text;
            if (searchname != null && !searchname.Equals(""))
            {
                String query = "select * from workers";
                DataTable wdt = db.getDataTable(query, "workers");
                TreeNode node = tv_worker.SelectedNode;
                int number = wdt.Rows.Count;
                deleteAllItems();
                for (int i = 0; i < number; )
                {
                    if(wdt.Rows[i]["lastName"].ToString().Equals(searchname))
                    {
                        String qposition = "select * from position where positionID=" + wdt.Rows[i]["positionID"];
                        DataTable pdt = db.getDataTable(qposition, "position");                     
                        AddlistViewItem(wdt.Rows[i]["workerID"].ToString(), wdt.Rows[i]["firstName"].ToString(), wdt.Rows[i]["lastName"].ToString(), ctogender(wdt.Rows[i]["gender"].ToString()), pdt.Rows[0]["salary"].ToString(), pdt.Rows[0]["positionName"].ToString(), pdt.Rows[0]["department"].ToString());
                        i++;
                    }
                    else
                        i++;


                }
            }
            else
            {                
                MessageBox.Show("请输入要查询的名称", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            if (lvWorker.Items.Count == 0)
                MessageBox.Show("查无此人","提示",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

        }

        private void btnmodify_Click(object sender, EventArgs e)
        {
              String gender1;             
            gender1 = cbgenger.Text;            
            tbSearch.Clear();             
             
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
                plInfo.Visible = true;
                ListViewItem item = lvWorker.SelectedItems[0];
                String ID = item.SubItems[0].Text;
                String name = item.SubItems[1].Text;
                String gender = item.SubItems[2].Text;
                String age = item.SubItems[3].Text;
                string salary = item.SubItems[4].Text;
                String start_date = item.SubItems[5].Text;
                string department = item.SubItems[6].Text;
                tbGender.Text = age;
               // tbDepart.Text = department;
                tbLast.Text = gender;                
                tbFirst.Text = name;
                if (tbFirst.Text != null && !tbFirst.Equals("") && tbLast.Text != null && !tbLast.Text.Equals("") && gender1 != null && !gender1.Equals("") && tbDepart.Text != null && !tbDepart.Text.Equals("")&&Convert.ToInt32(tbDepart.Text)<15)
                {

                    string id = item.SubItems[0].Text;
                    int idint = Convert.ToInt32(id);
                    String dsql;
                    if(gender1=="女")
                        dsql = "update workers set firstName='" + tbFirst.Text + "',lastName=" + tbLast.Text + ",genger='" + "false" + "',positionID='" + tbDepart.Text + "'where workerID=" +idint;
                    else 
                        dsql = "update workers set firstName='" + tbFirst.Text + "',lastName=" + tbLast.Text + ",genger='" + "true" + "',positionID='" + tbDepart.Text + "'where workerID=" +idint;
                    
                    if (db.singleOperation(dsql))
                    {
                        ClearText();
                        MessageBox.Show("修改成功！");
                    }
                    else { MessageBox.Show("修改失败"); }
                }
                else
                    MessageBox.Show("请填写详细信息！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }

           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String gender;             
            gender = cbgenger.Text;            
            tbSearch.Clear();             
            if ( tbFirst.Text != null&&!tbFirst.Equals("") && tbLast.Text != null&&!tbLast.Text.Equals("")&&gender!= null &&!gender.Equals("") && tbDepart.Text != null&&!tbDepart.Text.Equals(""))
            {
                string addsql;
                if (gender == "女")
                {
                     addsql= "insert into workers(firstName,gender,lastName,positionID)values('" + tbFirst.Text + "','" + "false" + "','" + tbLast.Text + "','" + tbDepart.Text + "')";
                }
                else
                {
                     addsql = "insert into workers(firstName,gender,lastName,positionID)values('" + tbFirst.Text + "','" + "true" + "','" + tbLast.Text + "','" + tbDepart.Text + "')";
                }
                if (db.singleOperation(addsql))
                {

                    ClearText();
                    MessageBox.Show("保存成功！");
                }
                else
                {

                    MessageBox.Show("保存失败！");
                }
            }
            else {
                MessageBox.Show("请填写详细信息！","警告",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            }
            plInfo.Visible = false;
        }
        private void ClearText()
        {
            //tbID.Clear();
            tbFirst.Clear();
            tbLast.Clear();
            tbGender.Clear();
            //tbSalary.Clear();
            //tbStart.Clear();
            tbDepart.Clear();
        
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
