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
        public string punchType { get; set; }
        public string punchId { get; set; }
        public DateTime dateTime { get; set; }


        public Punch(string pt, string un)
        {
            punchType = pt;
            username = un;
            punchId = generatePunchId();
            dateTime = getDateTime();
        }

        public string generatePunchId() // generates unique ID everytime a new punch is made
        {
            string genId = Guid.NewGuid().ToString("N");
            return genId;
        }

        public DateTime getDateTime()
        {
            DateTime dateTime = DateTime.Now;
            //Console.WriteLine("time:" + dateTime);

            return dateTime;
        }

    }
}
