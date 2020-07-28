using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


using System.Net.Http;
using Newtonsoft.Json;

namespace LangTranslate
{
    public class AppData
    {

        const string f = "userdata.txt";

        static string[] lines = File.ReadAllLines(f);

        //User data
        public static string key_var = lines[0];
        public static string endpoint_var = lines[1];
        public static string region = lines[2];
        //




    }


}
