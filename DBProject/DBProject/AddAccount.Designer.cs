namespace DBProject
{
    partial class AddAccount
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
            this.addname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.addpass = new System.Windows.Forms.TextBox();
            this.addPri = new System.Windows.Forms.ComboBox();
            this.submit = new System.Windows.Forms.Button();
            this.privilege = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.repass = new System.Windows.Forms.Label();
            this.addrepass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addname
            // 
            this.addname.Location = new System.Drawing.Point(187, 48);
            this.addname.Name = "addname";
            this.addname.Size = new System.Drawing.Size(100, 21);
            this.addname.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(98, 51);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(41, 12);
            this.name.TabIndex = 1;
            this.name.Text = "用户名";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(100, 110);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(29, 12);
            this.password.TabIndex = 2;
            this.password.Text = "密码";
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // addpass
            // 
            this.addpass.Location = new System.Drawing.Point(186, 105);
            this.addpass.Name = "addpass";
            this.addpass.PasswordChar = '●';
            this.addpass.Size = new System.Drawing.Size(100, 21);
            this.addpass.TabIndex = 3;
            // 
            // addPri
            // 
            this.addPri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addPri.FormattingEnabled = true;
            this.addPri.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.addPri.Location = new System.Drawing.Point(187, 183);
            this.addPri.Name = "addPri";
            this.addPri.Size = new System.Drawing.Size(100, 20);
            this.addPri.TabIndex = 4;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(212, 226);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 43);
            this.submit.TabIndex = 5;
            this.submit.Text = "确定";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // privilege
            // 
            this.privilege.AutoSize = true;
            this.privilege.Location = new System.Drawing.Point(98, 191);
            this.privilege.Name = "privilege";
            this.privilege.Size = new System.Drawing.Size(53, 12);
            this.privilege.TabIndex = 6;
            this.privilege.Text = "选择权限";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "( 6-16位 )";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "( 6-20位 )";
            // 
            // repass
            // 
            this.repass.AutoSize = true;
            this.repass.Location = new System.Drawing.Point(100, 148);
            this.repass.Name = "repass";
            this.repass.Size = new System.Drawing.Size(53, 12);
            this.repass.TabIndex = 9;
            this.repass.Text = "重复密码";
            this.repass.Click += new System.EventHandler(this.label3_Click);
            // 
            // addrepass
            // 
            this.addrepass.Location = new System.Drawing.Point(186, 144);
            this.addrepass.Name = "addrepass";
            this.addrepass.PasswordChar = '●';
            this.addrepass.Size = new System.Drawing.Size(100, 21);
            this.addrepass.TabIndex = 10;
            this.addrepass.TextChanged += new System.EventHandler(this.repassword_TextChanged);
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DBProject.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(426, 281);
            this.Controls.Add(this.addrepass);
            this.Controls.Add(this.repass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.privilege);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.addPri);
            this.Controls.Add(this.addpass);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.addname);
            this.Name = "AddAccount";
            this.Text = "AddAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addname;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox addpass;
        private System.Windows.Forms.ComboBox addPri;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label privilege;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label repass;
        private System.Windows.Forms.TextBox addrepass;
    }
}