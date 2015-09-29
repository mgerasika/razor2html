using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CsharpToHtml
{
    class Utils
    {
        public static void Log(string msg)
        {
            using (StreamWriter sw = new StreamWriter("log.txt", true))
            {
                sw.WriteLine(msg);
            }
        }
    }
}
