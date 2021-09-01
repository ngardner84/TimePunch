using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePunch
{
    class Punch
    {
        public string punchType { get; set; }
        int punchId { get; set; }
        DateTime dateTime { get; set; }

        public Punch()
        {
            punchType = null;
            punchId = generatePunchId();
            dateTime = getDateTime();
        }

        private static int generatePunchId() // generates unique ID everytime a new punch is made
        {
            string genId = Guid.NewGuid().ToString("N");
            int uniqueId = Convert.ToInt32(genId);
            return uniqueId;
        }

        public static DateTime getDateTime()
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("time:" + dateTime);

            return dateTime;
        }

    }
}
