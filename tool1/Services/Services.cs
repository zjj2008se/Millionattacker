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
        PlayerInfo info = new PlayerInfo();
        public  string debugstring = "";
        public  string areaid = null;
        public  string floorid = null;
         bool isexlpore = false;
         bool ishavafairy = false;
         bool isdeckfull = false;
         bool isouttermode = false;
         bool isAPRecovery = false;
         bool isBCRecovery = false;


        public FairyList updateFairyInfo()
        {
        
            fairylist = Action.getFairyInfo();
            debugstring = Action.getdebugstring();
            int count = fairylist.List.Count;
            bool checkfairy = false;
            for (int i = 0; i < count; i++)
            {
                if (fairylist.List[i].OwnerID == info.playerid && fairylist.List[i].IsAlive == true)
                {
                    checkfairy = true;
                    break;
                }
                else
                {
                    checkfairy = false;
                }

            }
            ishavafairy = checkfairy;
            return fairylist;

            
        }
        public void settingLogin(string username, string password) 
        {
            Action.login(username, password);
            //Action.login("15099757550", "qwertyuiop");

        }
        public void settingpolicy(bool Fairyoutmode) 
        {
            isouttermode = Fairyoutmode;
        }
        public void settingRecovery(bool AP,bool BC) 
        {
            isAPRecovery = AP;
            isBCRecovery = BC;
        }

        public PlayerInfo updateInfo() 
        {
            if (isAPRecovery = true && info.NowAP < 4) 
            {
                Action.useItem("1");
            }
            if (isBCRecovery = true && info.NowBC < 3)
            {
                Action.useItem("2");
            }
            PlayerInfo info1 = new PlayerInfo();
            Action.getPlayerInfo(ref info1);
            this.info = info1;
            return info1;
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
            if (ishavafairy == false)
            {
                string s = "";
                s = Action.explore(areaid, floorid);
                /*if (s == "getfairy")
                {
                    ishavafairy = true;
                    FairyBattle();
                    isexlpore = false;
                }*/
                debugstring = Action.getdebugstring();
            }
        }
        public string FairyBattle() 
        {
            string reslut = null;
            battlereslut s = new battlereslut();
            int count = fairylist.List.Count;
            for (int i =0;i<count;i++)
            {
                if (fairylist.List[i].IsAlive == true && fairylist.List[i].IsAttack == false && isdeckfull == false)
                {
                    if (isouttermode == false)
                    {
                        s = Action.battle(fairylist.List[i].sid, fairylist.List[i].OwnerID);
                        //System.Threading.Thread.Sleep(5000);
                        if (s.haveerror == false)
                        {
                            if (s.errorcode == 1010)
                            {
                                fairylist.List[i].IsAlive = false;
                            }
                            fairylist.List[i].IsAttack = true;
                            reslut = "";

                        }
                        if (s.haveerror == true)
                        {
                            if (s.errorcode == 1050)
                            {
                                reslut = s.message;
                            }
                            if (s.errorcode == 8000)
                            {
                                reslut = s.message;
                                //isdeckfull = true;
                            }
                        }
                        break;

                    }
                    if (isouttermode == true)
                    {
                        if (fairylist.List[i].OwnerID == info.playerid)
                        {
                            s = Action.battle(fairylist.List[i].sid, fairylist.List[i].OwnerID);
                            if (s.haveerror == false)
                            {
                                if (s.errorcode == 1010)
                                {
                                    fairylist.List[i].IsAlive = false;
                                }
                                fairylist.List[i].IsAttack = true;
                                reslut = "";

                            }
                            if (s.haveerror == true)
                            {
                                if (s.errorcode == 1050)
                                {
                                    reslut = s.message;
                                }
                                if (s.errorcode == 8000)
                                {
                                    reslut = s.message;
                                    isdeckfull = true;
                                }
                            }
                        }
                    }
                }

            }
            return reslut;
        }

        public void useAPitem() 
        {
            Action.useItem("1");
        }
        public void useBCitem() 
        {
            Action.useItem("2");
        }
    }
 }

