using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace time2punch
{
    //Will need to create a FileWriter object whenever we want to run the functions
    class FileWriter
    {

        public FileWriter()
        {

        }
        /*Function checks to see if new user is in system file and if it isn't will write to file
         * TODO rework file check into separate function for better handling of the user adding process
         */
        public int writeUser(User temp)
        {
            string filePath = "usernames.csv";
            List<string> users = new List<string>();

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (sr.Peek() >= 0) // iterate through the csv and add it to our users list
                    {
                        users.Add(sr.ReadLine());
                    }
                    sr.Close();
                }
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    if (users == null | !users.Contains(temp.username)) // write to csv if users is empty, or if it doesnt contain the typed username
                    {
                        sw.WriteLine(temp.username);
                        sw.Close();
                    }
                    else if (users.Contains(temp.username))
                    {
                        Console.WriteLine("username already exists");
                        sw.Close();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Some Error Occured: \n" + e.Message);
                Console.ReadLine();
            }
            return 0;
        }
    }
}
