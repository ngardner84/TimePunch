using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace time2punch
{
    public class Punch
    {
        public string username { get; set; }
        public string name { get; set; }
        public string punchType { get; set; }
        public string punchId { get; set; }
        public string dt { get; set; }


        public Punch(string pt, string un)
        {
            punchType = pt;
            username = un;
            punchId = GeneratePunchId();
            dt = GetDateTime();
        }

        public string GeneratePunchId() // generates unique ID everytime a new punch is made
        {
            return Guid.NewGuid().ToString("N"); ;
        }

        public string GetDateTime()
        {
            // month/day/year, hour/minute/seconds
            string dt = DateTime.Now.ToString("MM") + "," + DateTime.Now.ToString("dd") + "," + DateTime.Now.ToString("yyyy") 
                + "," + DateTime.Now.ToString("HH") + "," + DateTime.Now.ToString("mm") + "," + DateTime.Now.ToString("ss");

            return dt;
        }
    }
}
