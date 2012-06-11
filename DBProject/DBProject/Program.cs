using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
 
using face;
using Card;
using System.Data;

namespace DBProject
{
    static class Program
    {
        public static Welcome main;
        static void Main()
        {
                addDefault();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(main = new Welcome());     
            
        }

        private static void addDefault()
        {
            String checkName = "select * from loginInfo where userName='default'" ;

            DBOperation op = new DBOperation();
            DataTable checkDefault = op.getDataTable(checkName, "loginInfo");

            if (checkDefault.Rows.Count == 0)
            {
                String defpass = AddAccount.MD5("123456");
                String addDefault = "insert into loginInfo(userName, password, privilege) values('default', '" + defpass + "', 0)";
                op.singleOperation(addDefault);
                MessageBox.Show("已添加默认账号");
            }
        }
    }
}
