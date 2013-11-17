using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.IO;
using System.Xml;
using System.ComponentModel;
using System.Threading;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;


namespace MillionTools.tool1.util
{
    class HttpUtil
    {
        private String baseurl = "http://game1-cbt.ma.sdo.com:10001";
        private string TWurl = "http://game.ma.mobimon.com.tw:10001";
        private String UA1 = "Million/101 (GT-I9100; GT-I9100; 2.3.4) samsung/GT-I9100/GT-I9100:2.3.4/GRJ22/eng.build.20120314.185218:eng/release-keys";
        private String UATW = "Million/102 (GT-I9100; GT-I9100; 2.3.4) samsung/GT-I9100/GT-I9100:2.3.4/GRJ22/eng.build.20120314.185218:eng/release-keys";
        //private String domain = "web.million-arthurs.com";
        private string key = "rBwj1MIAivVN222b";
        public CookieCollection cookies = new CookieCollection();
        public string s = null;
        public string response1 = null;
        public bool TWorCN = false;
        private IDictionary<string, string> docrypt(IDictionary<string, string> data)
        {
            if (data == null)
            {
                return null;

            }
            else
            {
                IDictionary<string, string> dictionary = new Dictionary<String, String>();
                foreach (KeyValuePair<string, string> entry in data)
                {
                    dictionary.Add(entry.Key, Encypt(entry.Value));
                }
                return dictionary;
            }
        }
        private string Encypt(string data)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            byte[] buffer2 = Encoding.UTF8.GetBytes(key);
            AesManaged managed2 = new AesManaged
            {
                Padding = PaddingMode.PKCS7,
                Mode = CipherMode.ECB,
                Key = buffer2
            };
            ICryptoTransform transform = managed2.CreateEncryptor();
            try
            {
                byte[] inArray = transform.TransformFinalBlock(bytes, 0, bytes.Length);
                return Convert.ToBase64String(inArray, 0, inArray.Length);
            }
            catch (CryptographicException exception)
            {
                return exception.Message;
            }
        }

        public XmlDocument post(IDictionary<String, String> data, string exurl, CookieCollection cookies0, bool isTW) 
        {
            try
            {
                Dictionary<string, string> dictionary = new Dictionary<string, string>();
                dictionary.Add("", "");
                IDictionary<string, string> postdata = dictionary;
                postdata.Clear();
                postdata = docrypt(data);
                String url = null;
                string UA =null;
                Encoding encoding;
                if (isTW == false)
                {
                    url = baseurl + exurl;
                    UA = UA1;

                }
                else 
                {
                    url = TWurl + exurl;
                    UA = UATW;
                }
                if (string.IsNullOrEmpty(url))
                {
                    throw new ArgumentNullException("url");
                }
                encoding = Encoding.Default;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(url));
                request.ProtocolVersion = HttpVersion.Version11;
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ServicePoint.Expect100Continue = false;
                request.UserAgent = UA;
                request.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip, deflate");
                request.KeepAlive = true;
                request.Timeout = 0xc350;
                if (cookies0 != null)
                {
                    request.CookieContainer = new CookieContainer();
                    request.CookieContainer.Add(cookies0);
                }
                request.Expect = null;
                StringBuilder builder = new StringBuilder();
                if ((postdata != null) && (postdata.Count != 0))
                {
                    int num = 0;
                    foreach (string str in postdata.Keys)
                    {
                        string str2 = postdata[str].Replace("=", "%3D").Replace("+", "%2B").Replace("/", "%2F");
                        if (str2.Substring(str2.Length - 3) != "%0A")
                        {
                            if (num > 0)
                            {
                                builder.AppendFormat("&{0}={1}%0A", str, str2);
                            }
                            else
                            {
                                builder.AppendFormat("{0}={1}%0A", str, str2);
                            }
                        }
                        else if (num > 0)
                        {
                            builder.AppendFormat("&{0}={1}", str, str2);
                        }
                        else
                        {
                            builder.AppendFormat("{0}={1}", str, str2);
                        }
                        num++;
                    }
                }
                byte[] bytes = encoding.GetBytes(builder.ToString());
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(bytes, 0, bytes.Length);

                }
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                cookies = response.Cookies; 
                Stream responseStream = response.GetResponseStream();
                byte[] buffer = new byte[4096];
                byte[] result;
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    int count = 0;
                    do
                    {
                        count = responseStream.Read(buffer, 0, buffer.Length);
                        memoryStream.Write(buffer, 0, count);

                    } while (count != 0);

                    result = memoryStream.ToArray();

                }
                response.Close();
                XmlDocument document = new XmlDocument();
                response1 = decrypt(result);
                document.LoadXml(decrypt(result));
                return document;
            }
            catch (System.Net.WebException) 
            {
                return post(data, exurl,cookies0,isTW);
            }
            
        }

        private string decrypt(byte[] data)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(key);
            AesManaged managed2 = new AesManaged
            {
                Padding = PaddingMode.PKCS7,
                Mode = CipherMode.ECB,
                Key = bytes
            };
            AesManaged managed = managed2;
            int blockSize = managed.BlockSize;
            ICryptoTransform transform = managed.CreateDecryptor();
            try
            {
                byte[] buffer2 = transform.TransformFinalBlock(data, 0, data.Length);
                string decode2 = Encoding.UTF8.GetString(buffer2);
                //byte[] byte3 = Convert.FromBase64String(decode2);
                //string decode = Encoding.UTF8.GetString(byte3);
                return decode2;
            }
            catch (CryptographicException exception)
            {
                return exception.Message;
            }
        }

    
    }

}
