namespace facility
{
    partial class Facility
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("全部", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("正在运行", 1, 1);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("正在维修");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("设备信息", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facility));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.return_to_main = new System.Windows.Forms.Button();
            this.fac_repair = new System.Windows.Forms.Button();
            this.fac_remove = new System.Windows.Forms.Button();
            this.fac_add = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(26, 118);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "Node1";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "全部";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "Node2";
            treeNode2.SelectedImageIndex = 1;
            treeNode2.Text = "正在运行";
            treeNode3.Name = "Node3";
            treeNode3.Text = "正在维修";
            treeNode4.Name = "Node0";
            treeNode4.Text = "设备信息";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(219, 192);
            this.treeView1.TabIndex = 9;
            // 
            // return_to_main
            // 
            this.return_to_main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("return_to_main.BackgroundImage")));
            this.return_to_main.Location = new System.Drawing.Point(397, 344);
            this.return_to_main.Name = "return_to_main";
            this.return_to_main.Size = new System.Drawing.Size(97, 41);
            this.return_to_main.TabIndex = 5;
            this.return_to_main.Text = "返回";
            this.return_to_main.UseVisualStyleBackColor = true;
            this.return_to_main.Click += new System.EventHandler(this.return_to_main_Click);
            // 
            // fac_repair
            // 
            this.fac_repair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fac_repair.BackgroundImage")));
            this.fac_repair.Location = new System.Drawing.Point(12, 329);
            this.fac_repair.Name = "fac_repair";
            this.fac_repair.Size = new System.Drawing.Size(86, 34);
            this.fac_repair.TabIndex = 3;
            this.fac_repair.Text = "维修";
            this.fac_repair.UseVisualStyleBackColor = true;
            this.fac_repair.Click += new System.EventHandler(this.Repair_Click);
            // 
            // fac_remove
            // 
            this.fac_remove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fac_remove.BackgroundImage")));
            this.fac_remove.Location = new System.Drawing.Point(225, 331);
            this.fac_remove.Name = "fac_remove";
            this.fac_remove.Size = new System.Drawing.Size(96, 32);
            this.fac_remove.TabIndex = 2;
            this.fac_remove.Text = "撤除";
            this.fac_remove.UseVisualStyleBackColor = true;
            this.fac_remove.Click += new System.EventHandler(this.button2_Click);
            // 
            // fac_add
            // 
            this.fac_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fac_add.BackgroundImage")));
            this.fac_add.Location = new System.Drawing.Point(115, 331);
            this.fac_add.Name = "fac_add";
            this.fac_add.Size = new System.Drawing.Size(86, 32);
            this.fac_add.TabIndex = 1;
            this.fac_add.Text = "增加";
            this.fac_add.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DBProject.Properties.Resources.facility;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(515, 402);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "请输入设备号：";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(34, 63);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 21);
            this.ID.TabIndex = 11;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.ControlLight;
            this.search.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.search.Location = new System.Drawing.Point(156, 63);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 12;
            this.search.Text = "查询";
            this.search.UseVisualStyleBackColor = false;
            // 
            // Facility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 400);
            this.Controls.Add(this.search);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.return_to_main);
            this.Controls.Add(this.fac_repair);
            this.Controls.Add(this.fac_remove);
            this.Controls.Add(this.fac_add);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Facility";
            this.Text = "Facility";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button fac_add;
        private System.Windows.Forms.Button fac_remove;
        private System.Windows.Forms.Button fac_repair;
        private System.Windows.Forms.Button return_to_main;
        //private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Button search;
    }
}

