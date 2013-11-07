using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MillionTools.tool1;
using MillionTools.tool1.StructInfo;
using System.Windows.Forms;
namespace MillionTools.tool1
{
    class Services
    {
        GameFunction Action = new GameFunction();
        AreaList area = new AreaList();
        FloorList floor = new FloorList();
        FairyList fairylist = new FairyList();
        public string debugstring = "";
        public string areaid = null;
        public string floorid = null;
        bool isexlpore = false;


        public FairyList updateFairyInfo()
        {
        
            fairylist = Action.getFairyInfo();
            debugstring = Action.getdebugstring();
            return fairylist;

            
        }
        public void setting(string username, string password) 
        {
            //Action.login(username, password);
            Action.login("15099757550", "qwertyuiop");

        }
        public PlayerInfo updateInfo() 
        {
             PlayerInfo info = new PlayerInfo();
             if (isexlpore == true)
             {
                 info = Action.nowinfo;
             }
             else 
             {
                 Action.getPlayerInfo(ref info);
             }
            return info;
        }
        public AreaList updateArea() 
        {
            area = Action.getarealist();
            return area;
        }
        public FloorList updatefloor(string areaid) 
        {
            floor = Action.getfloorlist(areaid);
            return floor;
        }
        public void explore(string areaid , string floorid)
        {
            Action.explore(areaid , floorid);
            debugstring = Action.getdebugstring();
        }
        public string FairyBattle() 
        {
            string s = null;
            int count = fairylist.List.Count;
            for (int i =0;i<count;i++)
            {
                if(fairylist.List[i].IsAlive == true)
                {
                    s = Action.battle(fairylist.List[i].sid,fairylist.List[i].OwnerID);
                    fairylist.List[i].IsAttack = true;
                }

            }
            return s;
        }
    
    }
 }

