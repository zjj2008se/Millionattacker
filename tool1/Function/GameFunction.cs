using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using MillionTools.tool1.StructInfo;

namespace MillionTools.tool1
{
    class GameFunction
    {
        public bool isLogin = false;
        GameUtil GameUtil = new GameUtil();
        private FairyList fairylist= new FairyList();
        string debugstring = "";
        bool ishavefairy = false;
        bool fariyinit = false;
        private string gameid;
        private string password;
        public FairyList list = new FairyList();
        public PlayerInfo nowinfo = new PlayerInfo();
        int items;

        public void login(string login_id, string password1) {
            gameid = login_id;
            password = password1;
            GameUtil.login(gameid, password);

        }

        public AreaList getarealist() 
        {
            AreaList arealist = new AreaList();
            XmlDocument response = GameUtil.getarealist();
            try
            {
                XmlNodeList nodelist = response.SelectNodes(
                    "/response/body/exploration_area/area_info_list/area_info");

                foreach (XmlNode child in nodelist)
                {
                    debugstring = child.InnerText;

                    Area area = new Area();

                    area.Areaid = child["id"].InnerText;
                    area.AreaName = child["name"].InnerText;
                    area.AreaProg = child["prog_area"].InnerText;
                    area.CardProg = child["prog_item"].InnerText;
                    area.AreaType = child["area_type"].InnerText;
                    arealist.arealist.Add(area);
                }
                return arealist;
            }
            catch (System.NullReferenceException)
            {
                return getarealist();
            }
        }


        public FloorList getfloorlist(string id) 
        {
            FloorList floorlist = new FloorList();
            XmlDocument response = GameUtil.getfloor(id);
            try
            {
                XmlNodeList nodelist = response.SelectNodes(
                   "/response/body/exploration_floor/floor_info_list/floor_info");

                foreach (XmlNode child in nodelist)
                {
                    Areafloor floor = new Areafloor();
                    floor.id = child["id"].InnerText;
                    floor.cost = child["cost"].InnerText;
                    floor.prog = child["progress"].InnerText;
                    floorlist.floorlist.Add(floor);
                    debugstring = child.InnerText;
                }
                return floorlist;
            }
            catch (System.NullReferenceException) 
            {
                return getfloorlist(id);
            }
        }


        public FairyList getFairyInfo() {
            
            XmlDocument response = GameUtil.getfairylist();

            //debugstring = response.OuterXml;
            try
            {
                XmlNodeList nodelist = response.SelectNodes(
                                        "/response/body/fairy_select/fairy_event");
                int count = nodelist.Count;
                debugstring = nodelist.Item(0).SelectSingleNode("user/id").InnerText;
                if (fariyinit == true)
                {
                    int count2 = list.List.Count;
                        for (int i = 0; i < count; i++)
                        {
                            bool issame = false;
                            for (int j = 0; j < count2; j++)
                            {

                                if (list.List[j].sid == nodelist.Item(i).SelectSingleNode("fairy/serial_id").InnerText &&
                                    list.List[j].LV == nodelist.Item(i).SelectSingleNode("fairy/lv").InnerText)
                                {
                                    issame = true;
                                    break;
                                }
                            }
                            if (issame == false)
                            {
                                FairyInfo info = new FairyInfo();
                                info.OwnerName = nodelist.Item(i).SelectSingleNode("user/name").InnerText;
                                info.OwnerID = nodelist.Item(i).SelectSingleNode("user/id").InnerText;
                                info.FairyName = nodelist.Item(i).SelectSingleNode("fairy/name").InnerText;
                                info.LV = nodelist.Item(i).SelectSingleNode("fairy/lv").InnerText;
                                info.sid = nodelist.Item(i).SelectSingleNode("fairy/serial_id").InnerText;
                                info.IsAttack = false;
                                if (nodelist.Item(i).SelectSingleNode("put_down").InnerText == "1")
                                {
                                    info.IsAlive = true;
                                }
                                else
                                {
                                    info.IsAlive = false;
                                }
                                debugstring = nodelist.Item(i).SelectSingleNode("fairy/serial_id").InnerText;
                                list.List.Add(info);
                            }
                    }
                }
                if(fariyinit == false)                {
                    for (int i = 0; i < count; i++)
                    {
                        FairyInfo info = new FairyInfo();
                        info.OwnerName = nodelist.Item(i).SelectSingleNode("user/name").InnerText;
                        info.OwnerID = nodelist.Item(i).SelectSingleNode("user/id").InnerText;
                        info.FairyName = nodelist.Item(i).SelectSingleNode("fairy/name").InnerText;
                        info.LV = nodelist.Item(i).SelectSingleNode("fairy/lv").InnerText;
                        info.sid = nodelist.Item(i).SelectSingleNode("fairy/serial_id").InnerText;
                        info.IsAttack = false;
                        if (nodelist.Item(i).SelectSingleNode("put_down").InnerText == "1")
                        {
                            info.IsAlive = true;
                        }
                        else
                        {
                            info.IsAlive = false;
                        }
                        debugstring = nodelist.Item(i).SelectSingleNode("fairy/serial_id").InnerText;
                        list.List.Add(info);
                    }
                    fariyinit = true;
                }
                return list;
            }
            catch (System.NullReferenceException)
            {
                int code = geterrorcode(response);
                return getFairyInfo();
            }
           
        }

        public string getdebugstring() 
        {
            return debugstring;
        }

        public string getreturnres() 
        {
            return GameUtil.returnreslut();

        }

        public bool getPlayerInfo(ref PlayerInfo playerinfo) {

            XmlDocument response = GameUtil.getPlayerInfo();
            try
            {
                nowinfo.PlayerName = response.SelectSingleNode(
                    "/response/header/your_data/name").InnerText;
                nowinfo.MaxAP = int.Parse(response.SelectSingleNode(
                    "/response/header/your_data/ap/max").InnerText);
                nowinfo.NowAP = int.Parse(response.SelectSingleNode(
                    "/response/header/your_data/ap/current").InnerText);
                nowinfo.MaxBC = int.Parse(response.SelectSingleNode(
                    "/response/header/your_data/bc/max").InnerText);
                nowinfo.NowBC = int.Parse(response.SelectSingleNode(
                    "/response/header/your_data/bc/current").InnerText);
                nowinfo.gold = int.Parse(response.SelectSingleNode(
                    "/response/header/your_data/gold").InnerText);
                nowinfo.playerid = response.SelectSingleNode(
                    "/response/body/login/user_id").InnerText;
                playerinfo = nowinfo;
            }
            catch(System.NullReferenceException)
            {
                int code = geterrorcode(response);
            
            }
            return false;

        }
        public string explore(string areaid ,string floor)
        {
            XmlDocument response = GameUtil.explore(areaid , floor);
            try
            {
                debugstring = response.SelectSingleNode("/response").InnerXml;
                if (response.SelectSingleNode("/response/body/explore/event_type").InnerText == "1")
                {
                    FairyInfo info = new FairyInfo();
                    this.ishavefairy = true;
                    info.FairyName = response.SelectSingleNode("/response/body/explore/fairy/name").InnerText;
                    info.LV = response.SelectSingleNode("/response/body/explore/fairy/lv").InnerText;
                    info.OwnerID = nowinfo.playerid;
                    info.OwnerName = nowinfo.PlayerName;
                    list.List.Add(info);
                    return "getfairy";

                }
                return "normal";
            }
            catch (System.NullReferenceException) 
            {
                return explore(areaid, floor);
            }
        }



        public int geterrorcode(XmlDocument doc) {
            try
            {
                int code = int.Parse(doc.SelectSingleNode("/response/header/error/code").InnerText);
                return code;
            }
            catch { return 99999; }
            
        }
        public string geterrormessage(XmlDocument doc)
        {
            try
            {
                string message = (doc.SelectSingleNode("/response/header/error/message").InnerText);
                return message;
            }
            catch 
            {
                return null;
            }
        }
        public string battle(string sid, string userid)
        {
            XmlDocument response = GameUtil.dobattle(sid, userid);
            try
            {
                debugstring = response.SelectSingleNode("/response").InnerXml;
                return debugstring;
            }
            catch (System.NullReferenceException)
            {
                return battle(sid, userid);
            }
                    
        }

    }
}
