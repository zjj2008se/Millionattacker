using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using MillionTools.tool1.util;

namespace MillionTools.tool1
{
    class GameUtil
    {
        public bool islogin = false;
        public string loginid;
        public string password;
        public string code;
        public string message;
        private XmlDocument connect(IDictionary<string, string> data, string url)
        {
            XmlDocument check = null;
            string errorcode = null;
            if (this.islogin == false)
            {
                check = login(loginid,password);
                islogin = true;
                errorcode = geterrorcode(check);
                connect(data,url);
            }
            else
            {
                check = post.post(data, url);
                errorcode = geterrorcode(check);
            }

            switch (errorcode){
                case "9000":
                    islogin = false;
                    connect(data, url);
                break;
                case "-1":
                    islogin = false;
                    connect(data, url);
                break;
            }
            if (errorcode == "") { 

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


        HttpUtil post = new HttpUtil();
        public XmlDocument login(string login_id,string password) {
            string url = "/connect/app/login?cyt=1";
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            this.loginid = login_id;
            this.password = password;
            parameters.Add("login_id", login_id);
            parameters.Add("password", password);
            /*
            parameters.Add("login_id", login_id);
            parameters.Add("password", password);
             */
            
            
            XmlDocument document = null;
            document = post.post(parameters,url);
            //XmlNode node = document.SelectSingleNode("/response/header/session_id");
            //post.s = node.InnerText;
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
            XmlDocument resposnse = post.post(parameters, url);
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
    
    }
}
