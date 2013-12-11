using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using MillionTools.tool1.util;
using MillionTools.tool1.StructInfo;
namespace MillionTools.tool1.util
{
    class cardreader
    {
        public void reader() 
        {
            string json = "";
            string strReadFilePath = System.Environment.CurrentDirectory+"\\"+ "ma_card.dat";
            StreamReader srReadFile = new StreamReader(strReadFilePath);

            while (!srReadFile.EndOfStream)
            {
                json = json + srReadFile.ReadLine(); //读取每行数据
            }
            srReadFile.Close();
            json = json.Replace("\t", "");
            json = json.Replace(" ", "");
            //json = json.Replace("[", "");
            //json = json.Replace("]", "");
            List<macard> macardlist = JsonConvert.DeserializeObject<List<macard>>(json);  
            macardlist[1].a.ToString();


        }
    }
}
