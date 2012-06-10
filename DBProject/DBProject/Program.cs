using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using face;
using Card;
using DBProject;
namespace DBProject
{
    static class Program
    {
        public static Welcome main;
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(main = new Welcome());
        }
    }
}
