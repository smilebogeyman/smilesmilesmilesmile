namespace face
{
    partial class worker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("财务部门");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("后勤部门");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("销售部门");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("人事部门");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("其他");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("员工信息", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            this.tv_worker = new System.Windows.Forms.TreeView();
            this.tbMain = new System.Windows.Forms.TextBox();
            this.lvWorker = new System.Windows.Forms.ListView();
            this.btnmodify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.return_to_main = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.plInfo = new System.Windows.Forms.Panel();
            this.btnback1 = new System.Windows.Forms.Button();
            this.tbDepart = new System.Windows.Forms.TextBox();
            this.lbDepart = new System.Windows.Forms.Label();
            this.tbStart = new System.Windows.Forms.TextBox();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.tbGender = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lbStart = new System.Windows.Forms.Label();
            this.lbSalary = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.plInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tv_worker
            // 
            this.tv_worker.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tv_worker.Location = new System.Drawing.Point(13, 51);
            this.tv_worker.Name = "tv_worker";
            treeNode7.Name = "finance";
            treeNode7.Text = "财务部门";
            treeNode8.Name = "facility";
            treeNode8.Text = "后勤部门";
            treeNode9.Name = "sale";
            treeNode9.Text = "销售部门";
            treeNode10.Name = "personnel";
            treeNode10.Text = "人事部门";
            treeNode11.Name = "purchase";
            treeNode11.Text = "其他";
            treeNode12.Name = "worker_info";
            treeNode12.Text = "员工信息";
            this.tv_worker.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.tv_worker.Size = new System.Drawing.Size(213, 379);
            this.tv_worker.TabIndex = 0;
            this.tv_worker.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_worker_NodeMouseDoubleClick);
            this.tv_worker.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_worker_AfterSelect);
            this.tv_worker.Click += new System.EventHandler(this.tv_worker_Click);
            // 
            // tbMain
            // 
            this.tbMain.BackColor = System.Drawing.Color.White;
            this.tbMain.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbMain.Location = new System.Drawing.Point(297, 51);
            this.tbMain.Multiline = true;
            this.tbMain.Name = "tbMain";
            this.tbMain.Size = new System.Drawing.Size(281, 379);
            this.tbMain.TabIndex = 1;
            this.tbMain.Text = "                                     staff code\r\n1.one\r\n2.two\r\n3.three\r\n4.four\r\n5" +
                ".five\r\n6.six\r\n7.seven\r\n8.eight\r\n9.nine\r\n10.ten\r\n11.eleven";
            // 
            // lvWorker
            // 
            this.lvWorker.BackColor = System.Drawing.Color.White;
            this.lvWorker.BackgroundImage = global::DBProject.Properties.Resources.info;
            this.lvWorker.Location = new System.Drawing.Point(232, 51);
            this.lvWorker.Name = "lvWorker";
            this.lvWorker.Size = new System.Drawing.Size(395, 379);
            this.lvWorker.TabIndex = 2;
            this.lvWorker.UseCompatibleStateImageBehavior = false;
            this.lvWorker.SelectedIndexChanged += new System.EventHandler(this.lvWorker_SelectedIndexChanged);
            this.lvWorker.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvWorker_ColumnClick);
            // 
            // btnmodify
            // 
            this.btnmodify.Location = new System.Drawing.Point(261, 436);
            this.btnmodify.Name = "btnmodify";
            this.btnmodify.Size = new System.Drawing.Size(75, 23);
            this.btnmodify.TabIndex = 3;
            this.btnmodify.Text = "修改";
            this.btnmodify.UseVisualStyleBackColor = true;
            this.btnmodify.Click += new System.EventHandler(this.btnmodify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(386, 436);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(503, 436);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // return_to_main
            // 
            this.return_to_main.Location = new System.Drawing.Point(61, 436);
            this.return_to_main.Name = "return_to_main";
            this.return_to_main.Size = new System.Drawing.Size(75, 23);
            this.return_to_main.TabIndex = 6;
            this.return_to_main.Text = "返回";
            this.return_to_main.UseVisualStyleBackColor = true;
            this.return_to_main.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(511, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(405, 15);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 21);
            this.tbSearch.TabIndex = 8;
            // 
            // plInfo
            // 
            this.plInfo.Controls.Add(this.btnback1);
            this.plInfo.Controls.Add(this.tbDepart);
            this.plInfo.Controls.Add(this.lbDepart);
            this.plInfo.Controls.Add(this.tbStart);
            this.plInfo.Controls.Add(this.tbSalary);
            this.plInfo.Controls.Add(this.tbAge);
            this.plInfo.Controls.Add(this.tbGender);
            this.plInfo.Controls.Add(this.tbName);
            this.plInfo.Controls.Add(this.tbID);
            this.plInfo.Controls.Add(this.lbStart);
            this.plInfo.Controls.Add(this.lbSalary);
            this.plInfo.Controls.Add(this.lbAge);
            this.plInfo.Controls.Add(this.lbGender);
            this.plInfo.Controls.Add(this.lbName);
            this.plInfo.Controls.Add(this.lb_id);
            this.plInfo.Controls.Add(this.btnSave);
            this.plInfo.Location = new System.Drawing.Point(297, 134);
            this.plInfo.Name = "plInfo";
            this.plInfo.Size = new System.Drawing.Size(249, 243);
            this.plInfo.TabIndex = 9;
            // 
            // btnback1
            // 
            this.btnback1.Location = new System.Drawing.Point(133, 217);
            this.btnback1.Name = "btnback1";
            this.btnback1.Size = new System.Drawing.Size(75, 23);
            this.btnback1.TabIndex = 15;
            this.btnback1.Text = "关闭";
            this.btnback1.UseVisualStyleBackColor = true;
            this.btnback1.Click += new System.EventHandler(this.btnback1_Click);
            // 
            // tbDepart
            // 
            this.tbDepart.Location = new System.Drawing.Point(86, 177);
            this.tbDepart.Name = "tbDepart";
            this.tbDepart.Size = new System.Drawing.Size(100, 21);
            this.tbDepart.TabIndex = 14;
            // 
            // lbDepart
            // 
            this.lbDepart.AutoSize = true;
            this.lbDepart.Location = new System.Drawing.Point(33, 180);
            this.lbDepart.Name = "lbDepart";
            this.lbDepart.Size = new System.Drawing.Size(29, 12);
            this.lbDepart.TabIndex = 13;
            this.lbDepart.Text = "部门";
            // 
            // tbStart
            // 
            this.tbStart.Location = new System.Drawing.Point(87, 150);
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(100, 21);
            this.tbStart.TabIndex = 12;
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(88, 122);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(100, 21);
            this.tbSalary.TabIndex = 11;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(88, 94);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(100, 21);
            this.tbAge.TabIndex = 10;
            // 
            // tbGender
            // 
            this.tbGender.Location = new System.Drawing.Point(88, 67);
            this.tbGender.Name = "tbGender";
            this.tbGender.Size = new System.Drawing.Size(100, 21);
            this.tbGender.TabIndex = 9;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(89, 42);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 21);
            this.tbName.TabIndex = 8;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(89, 12);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 21);
            this.tbID.TabIndex = 7;
            // 
            // lbStart
            // 
            this.lbStart.AutoSize = true;
            this.lbStart.Location = new System.Drawing.Point(21, 153);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(53, 12);
            this.lbStart.TabIndex = 6;
            this.lbStart.Text = "起聘日期";
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Location = new System.Drawing.Point(33, 126);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(29, 12);
            this.lbSalary.TabIndex = 5;
            this.lbSalary.Text = "工资";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(33, 98);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(29, 12);
            this.lbAge.TabIndex = 4;
            this.lbAge.Text = "年龄";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(33, 71);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(29, 12);
            this.lbGender.TabIndex = 3;
            this.lbGender.Text = "性别";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(33, 45);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(29, 12);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "姓名";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(27, 15);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(41, 12);
            this.lb_id.TabIndex = 1;
            this.lb_id.Text = "员工号";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(18, 217);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DBProject.Properties.Resources.info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(620, 488);
            this.Controls.Add(this.plInfo);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.return_to_main);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnmodify);
            this.Controls.Add(this.lvWorker);
            this.Controls.Add(this.tbMain);
            this.Controls.Add(this.tv_worker);
            this.Name = "worker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工信息";
            this.Load += new System.EventHandler(this.worker_Load);
            this.plInfo.ResumeLayout(false);
            this.plInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tv_worker;
        private System.Windows.Forms.TextBox tbMain;
        private System.Windows.Forms.ListView lvWorker;
        private System.Windows.Forms.Button btnmodify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button return_to_main;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Panel plInfo;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.TextBox tbGender;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lbStart;
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbDepart;
        private System.Windows.Forms.Label lbDepart;
        private System.Windows.Forms.TextBox tbStart;
        private System.Windows.Forms.Button btnback1;
    }
}

