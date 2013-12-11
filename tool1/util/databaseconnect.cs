using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace MillionTools.tool1.util
{
    class databaseconnect
    {
        string dbpath = "ma.db";
        public void init()
        {
            if (System.IO.File.Exists(@dbpath))
            {
                DBStructBuilder(dbpath);
            }
            else
            {
                SQLiteConnection.CreateFile(dbpath);
                DBStructBuilder(dbpath);
            }
        }
        private bool DBStructBuilder(string path)
        {
            SQLiteConnection conn = new SQLiteConnection();
            try 
            {
                string path1 = "Data Source =" + dbpath;
                conn = new SQLiteConnection(path1);
                conn.Open();
                string sql = "CREATE TABLE IF NOT EXISTS carddb(id integer, name varchar(20),cost integer,ability varchar(100),abilityrate varchar(50),sex varchar(2),abilityname varchar(99));";//建表语句  
                SQLiteCommand cmdCreateTable = new SQLiteCommand(sql, conn);
                cmdCreateTable.ExecuteNonQuery();
                conn.Close();
            }
            catch 
            {

            }
            return true;
        }
    }
}
