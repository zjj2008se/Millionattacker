using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using Newtonsoft.Json;
using MillionTools.tool1.StructInfo;

namespace MillionTools.tool1.util   
{
    class databaseconnect
    {
        static string dbpath = "madata.db";
        string path1 = "Data Source =" + System.Environment.CurrentDirectory + "\\" + dbpath;
        private bool DBStructBuilder(string path)
        {
            SQLiteConnection conn = new SQLiteConnection();
            try
            {

                conn = new SQLiteConnection(path1);
                conn.Open();
                string creatcardtable = "CREATE TABLE IF NOT EXISTS carddb(sid varchar(99),id integer,name varchar(20),star integer,cost integer,hp integer,atk integer,shp integer,satk integer,abilitytype varchar(100),abilityvar real,abilityrate integer,sex varchar(2),cp real,scp real);";//建表语句  
                /*数据库结构：sid=卡牌实际ID
                 * id=卡牌类型
                 * shp=释放技能后HP
                 * satk=释放技能后ATK
                 * abilitytype包含
                     * COND_RECOVERY_HP=条件回血,
                     * TURN_UP_RECOVERY_HP=回合越多回血越多,
                     * TURN_DOWN_ATK_UP=回合越少回血越多，
                     * RECOVERY_HP=无条件回血,
                     * ATK_UP=无条件攻击上升,
                     * COND_ATK_UP=条件攻击上升,
                     * TURN_UP_ATK_UP=回合式ATK上升,
                     * TURN_DOWN_ATK_UP=回合越少式ATK上升,
                     * FIRST_ATK_UP=第一轮攻击上升,
                     * RECOVERY_BC=回复BC,
                     * RECOVERY_AP=回复AP，
                     * SUPER_UP=增加super，
                 * CP=卡片价值，
                 * SCP=卡片技能加成后的价值，
                 * */
                SQLiteCommand cmdCreateTable = new SQLiteCommand(creatcardtable, conn);
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
 