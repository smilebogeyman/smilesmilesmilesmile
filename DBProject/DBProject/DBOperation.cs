using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data.SqlClient;

namespace DBProject
{
    class DBOperation
    {
        public SqlConnection conn()
        { 
            string con = "data source = L-PC\\LEGNA; initial catalog = master; integrated security = true";
            SqlConnection conn = new SqlConnection(con);
            return conn;
        }

        public bool singleOperation(string SQLcmd)
        {
            SqlConnection con = conn();
            con.Open();
            SqlCommand cmd = new SqlCommand(SQLcmd, con);
            bool succ = true;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("error");
                succ = false;
            }
            return succ;
        }

        public string singleSearch(string sqlcmd)
        {
            string count = "";
            SqlConnection con = conn();
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlcmd, con);
            try
            {
                SqlDataReader rs = cmd.ExecuteReader();
                if (rs.Read())
                {
                    count = rs[0].ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("error");
            }
            return count;
        }

        public DataTable getDataTable(string str, string TableName)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(str, conn());
            try
            {
                da.Fill(ds, TableName);
                return ds.Tables[0];
            }
            catch
            {
                return new DataTable();
            }
        }
    }

}
