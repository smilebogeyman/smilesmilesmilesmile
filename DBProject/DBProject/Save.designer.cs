namespace Card
{
    partial class Save
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SaveMoney_B = new System.Windows.Forms.Button();
            this.ExitSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DBProject.Properties.Resources.card3;
            this.pictureBox1.Location = new System.Drawing.Point(-26, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 285);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(386, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "金额";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(467, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 2;
            // 
            // SaveMoney_B
            // 
            this.SaveMoney_B.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SaveMoney_B.Location = new System.Drawing.Point(405, 111);
            this.SaveMoney_B.Name = "SaveMoney_B";
            this.SaveMoney_B.Size = new System.Drawing.Size(96, 44);
            this.SaveMoney_B.TabIndex = 3;
            this.SaveMoney_B.Text = "确定";
            this.SaveMoney_B.UseVisualStyleBackColor = true;
            this.SaveMoney_B.Click += new System.EventHandler(this.SaveMoney_B_Click);
            // 
            // ExitSave
            // 
            this.ExitSave.Location = new System.Drawing.Point(405, 195);
            this.ExitSave.Name = "ExitSave";
            this.ExitSave.Size = new System.Drawing.Size(97, 37);
            this.ExitSave.TabIndex = 4;
            this.ExitSave.Text = "退出";
            this.ExitSave.UseVisualStyleBackColor = true;
            this.ExitSave.Click += new System.EventHandler(this.ExitSave_Click);
            // 
            // Save
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 266);
            this.Controls.Add(this.ExitSave);
            this.Controls.Add(this.SaveMoney_B);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Save";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "充值";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SaveMoney_B;
        private System.Windows.Forms.Button ExitSave;
    }
}