using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBProject
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Columns.Add("商品识别码");
            this.listView1.Columns.Add("商品名");
            this.listView1.Columns.Add("单价");
            this.listView1.Columns.Add("数量");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}
