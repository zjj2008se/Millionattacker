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
        public bool islogin =false;
        HttpUtil post = new HttpUtil();
        public XmlDocument login(string login_id,string password) {
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
    
    }
}
