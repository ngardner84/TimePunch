using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePunch
{
    class punch
    {
        int punchType { get; set; }
        int punchId { get; set; }
        DateTime dateTime { get; set; }

        public static DateTime getDateTime()
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("time:" + dateTime);

            return dateTime;
        }
    }
}
