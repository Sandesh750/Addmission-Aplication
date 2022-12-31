using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace Final_Poject
{
    public static class GlobalClass
    {
        public static OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Teach4\\Addmition Application\\Final_Poject\\bin\\Debug\\Primary Courses.xls;Persist Security Info=False;Extended Properties=Excel 8.0");
        public static OleDbCommand cmd = new OleDbCommand();
        public static OleDbDataReader dr;
        public static OleDbDataAdapter da = new OleDbDataAdapter();
        public static DataSet ds = new DataSet();


        public static string Uname = "";
        public static string Pass = "";
        public static string UType = "";
        public static string Que = "";
        public static string Ans = "";
        public static string Paymode = "";
       


        public static void record_Reader(string sqlcmd)
        {
            con.Open();
            cmd = new OleDbCommand(sqlcmd, con);
            dr = cmd.ExecuteReader();
        }

        public static int id_Reader(string sqlcmd)
        {
            int i = 0;
            con.Open();
            cmd = new OleDbCommand(sqlcmd, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                i = Convert.ToInt32(dr[0].ToString());
            }
            dr.Close();
            con.Close();
            i = i + 1;
            return i;
        }

        public static void Record_Manip(string sqlcmd)
        {
            con.Open();
            cmd = new OleDbCommand(sqlcmd, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
