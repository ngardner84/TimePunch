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

        /*
        Function to create file - will delete existing file if found and recreate
        */
        public void createFile(string filename)
        {
            try
            {
                if (File.Exists(filename))
                {
                    File.Delete(filename);
                    Console.WriteLine("Deleted existing file");
                }

                using (FileStream fs = File.Create(filename))
                {
                    if (filename == "usernames.csv")
                    {
                        fs.Close();
                        try
                        {
                            using (StreamWriter sw = new StreamWriter(filename))
                            {
                                sw.WriteLine("username, password");
                                sw.Close();
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                    }
                    else if (filename == "punch.csv")
                    {
                        try
                        {
                            fs.Close();
                            using (StreamWriter sw2 = new StreamWriter(filename))
                            {
                                sw2.WriteLine("Username, PunchType, Month, Day, Year, Hour, Minute, Second, PunchID");
                                sw2.Close();
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                    }
                    Console.WriteLine("Created file");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        

        /* This function fucking sucks
         * Function checks to see if new user is in system file and if it isn't will write to file
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

        
        /*
         * File will create a punch in the following format
         * Username, punch type, date/time, punch ID
         */ 
        public void writePunch(Punch temp)
        {
            string filePath = "punch.csv";

            string punchData = temp.username + "," + temp.punchType + "," + temp.dt + "," + temp.punchId;
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(punchData);
                sw.Close();
            }
        }
        
    }

}

