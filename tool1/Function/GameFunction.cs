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
        //private AreaList arealist =  new AreaList();


        public void login(string login_id, string password) {
            GameUtil.setlogin(login_id,password);
            GameUtil.login();

        }

        public AreaList getarealist() 
        {
            AreaList arealist = new AreaList();
            XmlDocument response = GameUtil.getarealist();
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
        public FloorList getfloorlist(string id) 
        {
            FloorList floorlist = new FloorList();
            XmlDocument response = GameUtil.getfloor(id);
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


        public FairyList getFairyInfo() {
            FairyList list = new FairyList();
            XmlDocument response = GameUtil.getfairylist();
            XmlNodeList nodelist = response.SelectNodes(
                                    "/response/body/fairy_select/fairy_event/fairy");

            XmlNodeList nodelist1 = response.SelectNodes(
                                    "/response/body/fairy_select/fairy_event/user");
            foreach (XmlNode child in nodelist)
            {
                FairyInfo info = new FairyInfo();
                info.FairyName = child["name"].InnerText;
                info.sid = child["serial_id"].InnerText;
                info.LV = child["lv"].InnerText;
                if (child["put_down"].InnerText == "1")
                {
                    info.IsAlive = true;
                }
                else 
                {
                    info.IsAlive = false;
                }


                //info.StartTime =int.Parse( child["/user/start_time"].InnerText);
                debugstring = child.InnerText;
            }
            return list;
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
            PlayerInfo nowinfo = new PlayerInfo();
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
            catch {
                int code = geterrorcode(response);
            
            }
            return false;

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

    }
}
