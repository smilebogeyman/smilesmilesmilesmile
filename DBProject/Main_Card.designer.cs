namespace Card
{
    partial class Cards
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
            this.MakeCard_B = new System.Windows.Forms.Button();
            this.Statement_B = new System.Windows.Forms.Button();
            this.Exit_B = new System.Windows.Forms.Button();
            this.Register_B = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MakeCard_B
            // 
            this.MakeCard_B.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MakeCard_B.ForeColor = System.Drawing.Color.Blue;
            this.MakeCard_B.Location = new System.Drawing.Point(58, 34);
            this.MakeCard_B.Name = "MakeCard_B";
            this.MakeCard_B.Size = new System.Drawing.Size(88, 39);
            this.MakeCard_B.TabIndex = 1;
            this.MakeCard_B.Text = "新建购物卡";
            this.MakeCard_B.UseVisualStyleBackColor = true;
            this.MakeCard_B.Click += new System.EventHandler(this.MakeCard_B_Click);
            // 
            // Statement_B
            // 
            this.Statement_B.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Statement_B.ForeColor = System.Drawing.Color.Blue;
            this.Statement_B.Location = new System.Drawing.Point(58, 151);
            this.Statement_B.Name = "Statement_B";
            this.Statement_B.Size = new System.Drawing.Size(88, 36);
            this.Statement_B.TabIndex = 7;
            this.Statement_B.Text = "报表";
            this.Statement_B.UseVisualStyleBackColor = true;
            this.Statement_B.Click += new System.EventHandler(this.Statement_B_Click);
            // 
            // Exit_B
            // 
            this.Exit_B.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Exit_B.ForeColor = System.Drawing.Color.Blue;
            this.Exit_B.Location = new System.Drawing.Point(475, 289);
            this.Exit_B.Name = "Exit_B";
            this.Exit_B.Size = new System.Drawing.Size(87, 36);
            this.Exit_B.TabIndex = 8;
            this.Exit_B.Text = "返回";
            this.Exit_B.UseVisualStyleBackColor = true;
            this.Exit_B.Click += new System.EventHandler(this.Exit_B_Click);
            // 
            // Register_B
            // 
            this.Register_B.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Register_B.ForeColor = System.Drawing.Color.Blue;
            this.Register_B.Location = new System.Drawing.Point(58, 258);
            this.Register_B.Name = "Register_B";
            this.Register_B.Size = new System.Drawing.Size(87, 37);
            this.Register_B.TabIndex = 9;
            this.Register_B.TabStop = false;
            this.Register_B.Text = "用户信息";
            this.Register_B.UseVisualStyleBackColor = true;
            this.Register_B.Click += new System.EventHandler(this.login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::DBProject.Properties.Resources.card1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 389);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Cards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 389);
            this.Controls.Add(this.Register_B);
            this.Controls.Add(this.Exit_B);
            this.Controls.Add(this.Statement_B);
            this.Controls.Add(this.MakeCard_B);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Cards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "购物卡";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button MakeCard_B;
        private System.Windows.Forms.Button Statement_B;
        private System.Windows.Forms.Button Exit_B;
        private System.Windows.Forms.Button Register_B;
    }
}

