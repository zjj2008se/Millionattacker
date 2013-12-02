using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using MillionTools.tool1.util;
using System.Net;
using System.Net.Security;

namespace MillionTools.tool1
{
    class GameUtil
    {
        HttpUtil post = new HttpUtil();
        public bool islogin = false;
        public string loginid;
        public string password;
        public string code;
        public string message;
        public bool isTW;
        private CookieCollection cookies = new CookieCollection();
        private XmlDocument connect(IDictionary<string, string> data, string url)
        {
            XmlDocument check = null;
            string errorcode = null;
            if (this.islogin == false)
            {
                check = login();
                islogin = true;
                errorcode = geterrorcode(check);
                connect(data,url);
            }
            else
            {
                check = post.post(data, url,cookies,isTW);
                errorcode = geterrorcode(check);
            }

            if (errorcode == "9000")
            {
                islogin = false;
                connect(data, url);
            }

            return check;
        }

        private string geterrorcode(XmlDocument data)
        {
            string code=null;
            try
            {
                XmlNodeList response = data.SelectNodes("/response/header/error/code");
                code = response.Item(0).InnerText;
            }
            catch 
            {
                code = null;
            }
            return code;
        }


        
        public XmlDocument login() {
            string url = "/connect/app/login?cyt=1";
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            parameters.Add("login_id", this.loginid);
            parameters.Add("password", this.password);
            XmlDocument document = null;
            document = post.post(parameters,url,cookies,isTW);
            cookies = post.cookies;
            return document;
         
        }
        public string returnreslut() {
            return post.response1;
        }
        public XmlDocument explore(string areaid, string floor)
        {
            string url = "/connect/app/exploration/explore?cyt=1";
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            parameters.Add("area_id", areaid);
            parameters.Add("floor_id", floor);
            parameters.Add("auto_build", "1");
            XmlDocument resposnse = connect(parameters, url);

            return resposnse;
        }
        public XmlDocument getarealist()
        {
            string url = "/connect/app/exploration/area?cyt=1";
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            XmlDocument resposnse = connect(parameters, url);
            return resposnse;
        }
        public XmlDocument getPlayerInfo() {
            string url = "/connect/app/mainmenu?cyt=1";
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            XmlDocument response = connect(parameters, url);
            return response;
        }
        public XmlDocument getfloor(string id)
        {
            string url = "/connect/app/exploration/floor?cyt=1";
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            parameters.Add("area_id", id);
            XmlDocument response = connect(parameters, url);
            return response;
        
        }
        public XmlDocument getfairylist() 
        {
            string url = "/connect/app/menu/fairyselect?cyt=1";
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            XmlDocument response = connect(parameters, url);
            return response;
        }
        public XmlDocument dobattle(string sid, string userid) 
        {
            string url = "/connect/app/exploration/fairybattle?cyt=1";
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            parameters.Add("serial_id", sid);
            parameters.Add("user_id", userid);
            XmlDocument response = connect(parameters, url);
            return response;
        }
        public XmlDocument Recovery(string itemid) 
        {
            string url = "/connect/app/item/use?cyt=1";
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            parameters.Add("item_id", itemid);
            XmlDocument response = connect(parameters, url);
            return response;
 
        }
        public XmlDocument getFriendList()
        {
            string url = "/connect/app/menu/friendlist?cyt=1";
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            parameters.Add("move", "0");
            XmlDocument response = connect(parameters, url);
            return response;
        }
        public XmlDocument getFrienApprovedList()
        {
            string url = "/connect/app/menu/friend_notice?cyt=1";
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            parameters.Add("move", "0");
            XmlDocument response = connect(parameters, url);
            return response;
        }
        public XmlDocument searchfriend(string name)
        {
            string url = "/connect/app/menu/player_search?cyt=1";
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            parameters.Add("name", name);
            XmlDocument response = connect(parameters, url);
            return response;
        }
        public XmlDocument deletefriend(string id)
        {
            string url = "/connect/app/friend/remove_friend?cyt=1";
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            parameters.Add("dialog", "1");
            parameters.Add("user_id", id);
            XmlDocument response = connect(parameters, url);
            return response;
        }
        public XmlDocument addfriend(string id)
        {
            string url = "/connect/app/friend/add_friend?cyt=1";
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            parameters.Add("dialog", "1");
            parameters.Add("user_id", id);
            XmlDocument response = connect(parameters, url);
            return response;
        }
        public XmlDocument approvefriend(string id)
        {
            string url = "/connect/app/friend/approve_friend?cyt=1";
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            parameters.Add("user_id", id);
            parameters.Add("dialog", "1");
            XmlDocument response = connect(parameters, url);
            return response;
        }
        public XmlDocument pvpbattle(string id,string event_id)
        {
            string url = "/connect/app/battle/battle?cyt=1";
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            parameters.Add("battle_type", "0");
            parameters.Add("event_id", event_id);
            parameters.Add("user_id", id);
            XmlDocument response = connect(parameters, url);
            return response;
        }
    }
}
