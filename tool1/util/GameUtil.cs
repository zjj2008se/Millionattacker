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
        private string login_id = "";
        private string password = "";
        public bool islogin = false;


        public void setlogin(string loginid,string password) 
        {
            this.login_id = loginid;
            this.password = password;

        }
        private int connect(IDictionary<string,string> data, string url)
        {
            XmlDocument check = null;
            string errorcode = null;
            if (this.islogin == false)
            {
                check = login();
                errorcode = geterrorcode(check);
            }
            else
            {
                check = post.post(data, url);
                errorcode = geterrorcode(check);
            }

            switch (errorcode){
                case "1":
                break;
                case "2":
                break;
            }
            if (errorcode == "") { 

            }

            return 0;
        }

        private string geterrorcode(XmlDocument data)
        {
            return null;

        
        }


        HttpUtil post = new HttpUtil();
        public XmlDocument login() {
            string url = "/connect/app/login?cyt=1";
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            parameters.Add("login_id", "15099797743");
            parameters.Add("password", "qwertyuiop");
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
        public XmlDocument explore()
        {
            string url = "/connect/app/exploration/area?cyt=1";
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            XmlDocument resposnse = post.post(parameters, url);

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
            XmlDocument response = post.post(parameters, url);
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
            XmlDocument response = post.post(parameters, url);
            return response;
        
        }
        public XmlDocument getfairylist() 
        {
            string url = "/connect/app/menu/fairyselect?cyt=1";
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("", "");
            IDictionary<string, string> parameters = dictionary;
            parameters.Clear();
            XmlDocument response = post.post(parameters, url);
            return response;
        }
    
    }
}
