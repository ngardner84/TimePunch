using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePunch
{
    class punch
    {
        string punchType { get; set; }
        int punchId { get; set; }
        DateTime dateTime { get; set; }

        public punch()
        {
            punchType = "Undefined";
            punchId = createPunchId();
            dateTime = getDateTime();

        }

        public static int createPunchId()
        {
            Random rnd = new Random();
            int Id = rnd.Next(0, 10000); // probably change this cuz there could be duplicates
            return Id;
        }

        public static DateTime getDateTime()
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("time:" + dateTime);

            return dateTime;
        }



    }
}
