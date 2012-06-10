namespace DBProject
{
    partial class Sales
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
            this.itemIdLabel = new System.Windows.Forms.Label();
            this.itemIDBox = new System.Windows.Forms.TextBox();
            this.AddItemBtn = new System.Windows.Forms.Button();
            this.PayByCashRadio = new System.Windows.Forms.RadioButton();
            this.PayByCardRadio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.WholePriceBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SaleList = new System.Windows.Forms.ListView();
            this.itemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemSum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.multiPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemSumLabel = new System.Windows.Forms.Label();
            this.itemSumBox = new System.Windows.Forms.TextBox();
            this.PayByCashCardRadio = new System.Windows.Forms.RadioButton();
            this.CardIdLabel = new System.Windows.Forms.Label();
            this.CardPwdLabel = new System.Windows.Forms.Label();
            this.CardIdBox = new System.Windows.Forms.TextBox();
            this.CardPwdBox = new System.Windows.Forms.TextBox();
            this.CardUseLabel1 = new System.Windows.Forms.Label();
            this.CardUseBox = new System.Windows.Forms.TextBox();
            this.CardUseLabel2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CheckOut = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemIdLabel
            // 
            this.itemIdLabel.AutoSize = true;
            this.itemIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.itemIdLabel.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.itemIdLabel.ForeColor = System.Drawing.Color.Teal;
            this.itemIdLabel.Location = new System.Drawing.Point(25, 50);
            this.itemIdLabel.Name = "itemIdLabel";
            this.itemIdLabel.Size = new System.Drawing.Size(114, 19);
            this.itemIdLabel.TabIndex = 1;
            this.itemIdLabel.Text = "商品识别码";
            // 
            // itemIDBox
            // 
            this.itemIDBox.Location = new System.Drawing.Point(29, 82);
            this.itemIDBox.Name = "itemIDBox";
            this.itemIDBox.Size = new System.Drawing.Size(108, 21);
            this.itemIDBox.TabIndex = 2;
            this.itemIDBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.itemIDBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.itemIDBox_KeyDown);
            this.itemIDBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemIDBox_KeyPress);
            // 
            // AddItemBtn
            // 
            this.AddItemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(201)))), ((int)(((byte)(212)))));
            this.AddItemBtn.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddItemBtn.ForeColor = System.Drawing.Color.DarkCyan;
            this.AddItemBtn.Location = new System.Drawing.Point(29, 112);
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Size = new System.Drawing.Size(170, 39);
            this.AddItemBtn.TabIndex = 3;
            this.AddItemBtn.Text = "添 加";
            this.AddItemBtn.UseVisualStyleBackColor = false;
            this.AddItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
            // 
            // PayByCashRadio
            // 
            this.PayByCashRadio.AutoSize = true;
            this.PayByCashRadio.BackColor = System.Drawing.Color.Transparent;
            this.PayByCashRadio.Checked = true;
            this.PayByCashRadio.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PayByCashRadio.ForeColor = System.Drawing.Color.Cyan;
            this.PayByCashRadio.Location = new System.Drawing.Point(30, 242);
            this.PayByCashRadio.Name = "PayByCashRadio";
            this.PayByCashRadio.Size = new System.Drawing.Size(60, 20);
            this.PayByCashRadio.TabIndex = 4;
            this.PayByCashRadio.TabStop = true;
            this.PayByCashRadio.Text = "现金";
            this.PayByCashRadio.UseVisualStyleBackColor = false;
            this.PayByCashRadio.CheckedChanged += new System.EventHandler(this.PayByCashRadio_CheckedChanged);
            // 
            // PayByCardRadio
            // 
            this.PayByCardRadio.AutoSize = true;
            this.PayByCardRadio.BackColor = System.Drawing.Color.Transparent;
            this.PayByCardRadio.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PayByCardRadio.ForeColor = System.Drawing.Color.Cyan;
            this.PayByCardRadio.Location = new System.Drawing.Point(98, 242);
            this.PayByCardRadio.Name = "PayByCardRadio";
            this.PayByCardRadio.Size = new System.Drawing.Size(77, 20);
            this.PayByCardRadio.TabIndex = 5;
            this.PayByCardRadio.Text = "购物卡";
            this.PayByCardRadio.UseVisualStyleBackColor = false;
            this.PayByCardRadio.CheckedChanged += new System.EventHandler(this.PayByCardRadio_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(26, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "付款方式";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(369, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "请输入商品识别码";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(354, 472);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(483, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "查询";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(27, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "总额";
            // 
            // WholePriceBox
            // 
            this.WholePriceBox.Enabled = false;
            this.WholePriceBox.Location = new System.Drawing.Point(79, 169);
            this.WholePriceBox.Name = "WholePriceBox";
            this.WholePriceBox.Size = new System.Drawing.Size(96, 21);
            this.WholePriceBox.TabIndex = 13;
            this.WholePriceBox.Text = "0";
            this.WholePriceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Khaki;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Location = new System.Drawing.Point(29, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 25);
            this.button4.TabIndex = 15;
            this.button4.Text = "返回主界面";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SaleList
            // 
            this.SaleList.BackColor = System.Drawing.Color.White;
            this.SaleList.BackgroundImageTiled = true;
            this.SaleList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemID,
            this.itemName,
            this.itemPrice,
            this.itemSum,
            this.multiPrice});
            this.SaleList.FullRowSelect = true;
            this.SaleList.Location = new System.Drawing.Point(219, 12);
            this.SaleList.Name = "SaleList";
            this.SaleList.Size = new System.Drawing.Size(360, 412);
            this.SaleList.TabIndex = 16;
            this.SaleList.UseCompatibleStateImageBehavior = false;
            this.SaleList.View = System.Windows.Forms.View.Details;
            this.SaleList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SaleList_KeyDown);
            // 
            // itemID
            // 
            this.itemID.Text = "商品识别码";
            this.itemID.Width = 73;
            // 
            // itemName
            // 
            this.itemName.Text = "商品名";
            this.itemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.itemName.Width = 115;
            // 
            // itemPrice
            // 
            this.itemPrice.Text = "单价(元)";
            this.itemPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // itemSum
            // 
            this.itemSum.Text = "数量";
            this.itemSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.itemSum.Width = 48;
            // 
            // multiPrice
            // 
            this.multiPrice.Text = "合计(元)";
            this.multiPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // itemSumLabel
            // 
            this.itemSumLabel.AutoSize = true;
            this.itemSumLabel.BackColor = System.Drawing.Color.Transparent;
            this.itemSumLabel.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.itemSumLabel.ForeColor = System.Drawing.Color.Teal;
            this.itemSumLabel.Location = new System.Drawing.Point(148, 50);
            this.itemSumLabel.Name = "itemSumLabel";
            this.itemSumLabel.Size = new System.Drawing.Size(51, 19);
            this.itemSumLabel.TabIndex = 17;
            this.itemSumLabel.Text = "数量";
            // 
            // itemSumBox
            // 
            this.itemSumBox.Location = new System.Drawing.Point(149, 82);
            this.itemSumBox.Name = "itemSumBox";
            this.itemSumBox.Size = new System.Drawing.Size(50, 21);
            this.itemSumBox.TabIndex = 18;
            this.itemSumBox.Text = "1";
            this.itemSumBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.itemSumBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.itemIDBox_KeyDown);
            this.itemSumBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemIDBox_KeyPress);
            // 
            // PayByCashCardRadio
            // 
            this.PayByCashCardRadio.AutoSize = true;
            this.PayByCashCardRadio.BackColor = System.Drawing.Color.Transparent;
            this.PayByCashCardRadio.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PayByCashCardRadio.ForeColor = System.Drawing.Color.Cyan;
            this.PayByCashCardRadio.Location = new System.Drawing.Point(29, 268);
            this.PayByCashCardRadio.Name = "PayByCashCardRadio";
            this.PayByCashCardRadio.Size = new System.Drawing.Size(146, 20);
            this.PayByCashCardRadio.TabIndex = 19;
            this.PayByCashCardRadio.Text = "现金 和 购物卡";
            this.PayByCashCardRadio.UseVisualStyleBackColor = false;
            this.PayByCashCardRadio.CheckedChanged += new System.EventHandler(this.PayByCashCardRadio_CheckedChanged);
            // 
            // CardIdLabel
            // 
            this.CardIdLabel.AutoSize = true;
            this.CardIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.CardIdLabel.Enabled = false;
            this.CardIdLabel.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CardIdLabel.ForeColor = System.Drawing.Color.MintCream;
            this.CardIdLabel.Location = new System.Drawing.Point(26, 304);
            this.CardIdLabel.Name = "CardIdLabel";
            this.CardIdLabel.Size = new System.Drawing.Size(82, 14);
            this.CardIdLabel.TabIndex = 20;
            this.CardIdLabel.Text = "购物卡编号";
            // 
            // CardPwdLabel
            // 
            this.CardPwdLabel.AutoSize = true;
            this.CardPwdLabel.BackColor = System.Drawing.Color.Transparent;
            this.CardPwdLabel.Enabled = false;
            this.CardPwdLabel.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CardPwdLabel.ForeColor = System.Drawing.Color.MintCream;
            this.CardPwdLabel.Location = new System.Drawing.Point(26, 331);
            this.CardPwdLabel.Name = "CardPwdLabel";
            this.CardPwdLabel.Size = new System.Drawing.Size(82, 14);
            this.CardPwdLabel.TabIndex = 21;
            this.CardPwdLabel.Text = "购物卡密码";
            // 
            // CardIdBox
            // 
            this.CardIdBox.Enabled = false;
            this.CardIdBox.Location = new System.Drawing.Point(114, 303);
            this.CardIdBox.Name = "CardIdBox";
            this.CardIdBox.Size = new System.Drawing.Size(85, 21);
            this.CardIdBox.TabIndex = 22;
            this.CardIdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CardIdBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemIDBox_KeyPress);
            // 
            // CardPwdBox
            // 
            this.CardPwdBox.Enabled = false;
            this.CardPwdBox.Location = new System.Drawing.Point(114, 331);
            this.CardPwdBox.Name = "CardPwdBox";
            this.CardPwdBox.Size = new System.Drawing.Size(85, 21);
            this.CardPwdBox.TabIndex = 23;
            this.CardPwdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CardUseLabel1
            // 
            this.CardUseLabel1.AutoSize = true;
            this.CardUseLabel1.BackColor = System.Drawing.Color.Transparent;
            this.CardUseLabel1.Enabled = false;
            this.CardUseLabel1.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CardUseLabel1.ForeColor = System.Drawing.Color.MintCream;
            this.CardUseLabel1.Location = new System.Drawing.Point(26, 360);
            this.CardUseLabel1.Name = "CardUseLabel1";
            this.CardUseLabel1.Size = new System.Drawing.Size(82, 14);
            this.CardUseLabel1.TabIndex = 24;
            this.CardUseLabel1.Text = "购物卡使用";
            // 
            // CardUseBox
            // 
            this.CardUseBox.Enabled = false;
            this.CardUseBox.Location = new System.Drawing.Point(114, 358);
            this.CardUseBox.Name = "CardUseBox";
            this.CardUseBox.Size = new System.Drawing.Size(61, 21);
            this.CardUseBox.TabIndex = 25;
            this.CardUseBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CardUseBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CardUseBox_KeyPress);
            // 
            // CardUseLabel2
            // 
            this.CardUseLabel2.AutoSize = true;
            this.CardUseLabel2.BackColor = System.Drawing.Color.Transparent;
            this.CardUseLabel2.Enabled = false;
            this.CardUseLabel2.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CardUseLabel2.ForeColor = System.Drawing.Color.MintCream;
            this.CardUseLabel2.Location = new System.Drawing.Point(180, 360);
            this.CardUseLabel2.Name = "CardUseLabel2";
            this.CardUseLabel2.Size = new System.Drawing.Size(22, 14);
            this.CardUseLabel2.TabIndex = 26;
            this.CardUseLabel2.Text = "元";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.MintCream;
            this.label10.Location = new System.Drawing.Point(177, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "元";
            // 
            // CheckOut
            // 
            this.CheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CheckOut.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckOut.ForeColor = System.Drawing.Color.RoyalBlue;
            this.CheckOut.Location = new System.Drawing.Point(29, 385);
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.Size = new System.Drawing.Size(173, 39);
            this.CheckOut.TabIndex = 28;
            this.CheckOut.Text = "结 算";
            this.CheckOut.UseVisualStyleBackColor = false;
            this.CheckOut.Click += new System.EventHandler(this.CheckOut_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(201)))), ((int)(((byte)(212)))));
            this.DelBtn.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DelBtn.ForeColor = System.Drawing.Color.DarkCyan;
            this.DelBtn.Location = new System.Drawing.Point(522, 385);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(57, 39);
            this.DelBtn.TabIndex = 29;
            this.DelBtn.Text = "删除";
            this.DelBtn.UseVisualStyleBackColor = false;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DBProject.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(593, 437);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.CheckOut);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CardUseLabel2);
            this.Controls.Add(this.CardUseBox);
            this.Controls.Add(this.CardUseLabel1);
            this.Controls.Add(this.CardPwdBox);
            this.Controls.Add(this.CardIdBox);
            this.Controls.Add(this.CardPwdLabel);
            this.Controls.Add(this.CardIdLabel);
            this.Controls.Add(this.PayByCashCardRadio);
            this.Controls.Add(this.itemSumBox);
            this.Controls.Add(this.itemSumLabel);
            this.Controls.Add(this.SaleList);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.WholePriceBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PayByCardRadio);
            this.Controls.Add(this.PayByCashRadio);
            this.Controls.Add(this.AddItemBtn);
            this.Controls.Add(this.itemIDBox);
            this.Controls.Add(this.itemIdLabel);
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "销售";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemIdLabel;
        private System.Windows.Forms.TextBox itemIDBox;
        private System.Windows.Forms.Button AddItemBtn;
        private System.Windows.Forms.RadioButton PayByCashRadio;
        private System.Windows.Forms.RadioButton PayByCardRadio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WholePriceBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView SaleList;
        private System.Windows.Forms.ColumnHeader itemID;
        private System.Windows.Forms.ColumnHeader itemName;
        private System.Windows.Forms.ColumnHeader itemPrice;
        private System.Windows.Forms.Label itemSumLabel;
        private System.Windows.Forms.TextBox itemSumBox;
        private System.Windows.Forms.RadioButton PayByCashCardRadio;
        private System.Windows.Forms.Label CardIdLabel;
        private System.Windows.Forms.Label CardPwdLabel;
        private System.Windows.Forms.TextBox CardIdBox;
        private System.Windows.Forms.TextBox CardPwdBox;
        private System.Windows.Forms.Label CardUseLabel1;
        private System.Windows.Forms.TextBox CardUseBox;
        private System.Windows.Forms.Label CardUseLabel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button CheckOut;
        private System.Windows.Forms.ColumnHeader itemSum;
        private System.Windows.Forms.ColumnHeader multiPrice;
        private System.Windows.Forms.Button DelBtn;
    }
}