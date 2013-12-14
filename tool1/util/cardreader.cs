using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using Newtonsoft.Json;
using MillionTools.tool1.util;
using MillionTools.tool1.StructInfo;
namespace MillionTools.tool1.util
{
    class cardreader
    {

        string dbpath = "ma.db";
        string path1 = "Data Source =" + System.Environment.CurrentDirectory + "\\" + "ma.db";
        public void init()
        {
            if (System.IO.File.Exists(@dbpath))
            {
                add2database(readermakong());
            }
            else
            {
                SQLiteConnection.CreateFile(dbpath);
                DBStructBuilder(dbpath);
                this.init();
            }
        }
        private bool DBStructBuilder(string path)
        {
            SQLiteConnection conn = new SQLiteConnection();
            try 
            {
                
                conn = new SQLiteConnection(path1);
                conn.Open();
                string sql = "CREATE TABLE IF NOT EXISTS carddb(id integer,name varchar(20),star integer,cost integer,ability varchar(100),abilityvar real,abilityrate varchar(50),sex varchar(2),abilityname varchar(99));";//建表语句  
                SQLiteCommand cmdCreateTable = new SQLiteCommand(sql, conn);
                cmdCreateTable.ExecuteNonQuery();
                conn.Close();
            }
            catch 
            {

            }
            return true;
        }
        public void add()
        {

        }
        private void add2database(List<macard> macard) 
        {
            int count = macard.Count;
            SQLiteConnection conn = new SQLiteConnection();
            conn= new SQLiteConnection(path1);
            conn.Open();
            for (int j = 0; j < count; j++) 
            {
                SQLiteCommand add = new SQLiteCommand(conn);
                add.CommandText = "insert into carddb values(@id, @name,@star,@cost,@ability,@abilityvar,@abilityrate,@sex,@abilityname)";
                add.Parameters.AddRange(new[] {//添加参数  
                           new SQLiteParameter("@id", macard[j].a),
                           new SQLiteParameter("@star", macard[j].c),
                           new SQLiteParameter("@name", macard[j].b),  
                           new SQLiteParameter("@cost", macard[j].e),
                            new SQLiteParameter("@ability", macard[j].g),
                            new SQLiteParameter("@abilityvar", macard[j].h),
                            new SQLiteParameter("@abilityrate",macard[j].j),
                            new SQLiteParameter("@sex", macard[j].m),
                            new SQLiteParameter("@abilityname", macard[j].z),
                       });
                add.ExecuteNonQuery();
            }
            conn.Close();
        }
        private List<macard> readermakong()
        {
            string json = "";
            string strReadFilePath = System.Environment.CurrentDirectory + "\\" + "ma_card.dat";
            StreamReader srReadFile = new StreamReader(strReadFilePath);

            while (!srReadFile.EndOfStream)
            {
                json = json + srReadFile.ReadLine();
            }
            srReadFile.Close();
            json = json.Replace("\t", "");
            json = json.Replace(" ", "");
            //json = json.Replace("[", "");
            //json = json.Replace("]", "");
            List<macard> macardlist = JsonConvert.DeserializeObject<List<macard>>(json);
            macardlist[1].a.ToString();
            return macardlist;


        }
    }
}
