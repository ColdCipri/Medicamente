using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicamente
{
    static class Utils
    {
        public static List<string> readFromFile(String link)
        {
            string line;
            List<string> stringList = new List<string>();

            System.IO.StreamReader file = new System.IO.StreamReader(@link);

            while ((line = file.ReadLine()) != null)
            { 
                stringList.Add(line);
            }

            file.Close();
            return stringList;
        }
    }
}
