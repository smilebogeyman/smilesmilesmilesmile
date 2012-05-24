namespace DBProject
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.sales = new System.Windows.Forms.Button();
            this.Warehouse = new System.Windows.Forms.Button();
            this.finance = new System.Windows.Forms.Button();
            this.facility = new System.Windows.Forms.Button();
            this.card = new System.Windows.Forms.Button();
            this.information = new System.Windows.Forms.Button();
            this.man_workers = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // sales
            // 
            this.sales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sales.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sales.ForeColor = System.Drawing.Color.Red;
            this.sales.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sales.Location = new System.Drawing.Point(132, 18);
            this.sales.Name = "sales";
            this.sales.Size = new System.Drawing.Size(112, 53);
            this.sales.TabIndex = 0;
            this.sales.Text = "售货";
            this.sales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sales.UseVisualStyleBackColor = false;
            this.sales.Click += new System.EventHandler(this.sales_Click);
            // 
            // Warehouse
            // 
            this.Warehouse.AutoSize = true;
            this.Warehouse.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Warehouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Warehouse.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Warehouse.ForeColor = System.Drawing.Color.Red;
            this.Warehouse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Warehouse.Location = new System.Drawing.Point(411, 281);
            this.Warehouse.Name = "Warehouse";
            this.Warehouse.Size = new System.Drawing.Size(94, 40);
            this.Warehouse.TabIndex = 1;
            this.Warehouse.Text = "仓库信息";
            this.Warehouse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Warehouse.UseVisualStyleBackColor = false;
            this.Warehouse.Click += new System.EventHandler(this.warehouse_Click);
            // 
            // finance
            // 
            this.finance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.finance.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.finance.ForeColor = System.Drawing.Color.Red;
            this.finance.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.finance.Location = new System.Drawing.Point(436, 77);
            this.finance.Name = "finance";
            this.finance.Size = new System.Drawing.Size(102, 40);
            this.finance.TabIndex = 2;
            this.finance.Text = "收支信息";
            this.finance.UseVisualStyleBackColor = false;
            this.finance.Click += new System.EventHandler(this.finance_Click);
            // 
            // facility
            // 
            this.facility.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.facility.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.facility.ForeColor = System.Drawing.Color.Red;
            this.facility.Location = new System.Drawing.Point(431, 235);
            this.facility.Name = "facility";
            this.facility.Size = new System.Drawing.Size(100, 40);
            this.facility.TabIndex = 3;
            this.facility.Text = "设备信息";
            this.facility.UseVisualStyleBackColor = false;
            this.facility.Click += new System.EventHandler(this.facility_Click);
            // 
            // card
            // 
            this.card.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.card.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.card.ForeColor = System.Drawing.Color.Red;
            this.card.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.card.Location = new System.Drawing.Point(449, 134);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(123, 40);
            this.card.TabIndex = 4;
            this.card.Text = "购物卡信息";
            this.card.UseVisualStyleBackColor = false;
            this.card.Click += new System.EventHandler(this.card_Click);
            // 
            // information
            // 
            this.information.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.information.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.information.ForeColor = System.Drawing.Color.Red;
            this.information.Location = new System.Drawing.Point(439, 182);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(115, 40);
            this.information.TabIndex = 5;
            this.information.Text = "信息查询";
            this.information.UseVisualStyleBackColor = false;
            this.information.Click += new System.EventHandler(this.information_Click);
            // 
            // man_workers
            // 
            this.man_workers.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.man_workers.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.man_workers.ForeColor = System.Drawing.Color.Red;
            this.man_workers.Location = new System.Drawing.Point(413, 36);
            this.man_workers.Name = "man_workers";
            this.man_workers.Size = new System.Drawing.Size(93, 35);
            this.man_workers.TabIndex = 6;
            this.man_workers.Text = "员工信息";
            this.man_workers.UseVisualStyleBackColor = false;
            this.man_workers.Click += new System.EventHandler(this.man_workers_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DBProject.Properties.Resources.menu;
            this.pictureBox1.Location = new System.Drawing.Point(387, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(12, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 55);
            this.button1.TabIndex = 9;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::DBProject.Properties.Resources.welcome;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(61, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(253, 138);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.BackgroundImage = global::DBProject.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.man_workers);
            this.Controls.Add(this.information);
            this.Controls.Add(this.card);
            this.Controls.Add(this.finance);
            this.Controls.Add(this.Warehouse);
            this.Controls.Add(this.sales);
            this.Controls.Add(this.facility);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Main_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Welcome_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sales;
        private System.Windows.Forms.Button Warehouse;
        private System.Windows.Forms.Button finance;
        private System.Windows.Forms.Button facility;
        private System.Windows.Forms.Button card;
        private System.Windows.Forms.Button information;
        private System.Windows.Forms.Button man_workers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

