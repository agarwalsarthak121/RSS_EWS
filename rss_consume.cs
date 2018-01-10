//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create("http://static.cricinfo.com/rss/livescores.xml");
            myRequest.Method = "GET";
            WebResponse myResponse = myRequest.GetResponse();
            StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
            string result = sr.ReadToEnd();
            sr.Close();
            myResponse.Close();

            Console.WriteLine(result);
        }
    }
}
