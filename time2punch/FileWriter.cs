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
        public static string userFile = "usernames.csv";
        public static string punchFile = "punch.csv";

        public FileWriter()
        {
            
        }

        /*
        Function to create file - will delete existing file if found and recreate
        */
        public void CreateFile(string filename)
        {
            try
            {
                /* We can omit this, File.Create automatically overwrites the existing one

                if (File.Exists(filename))
                {
                    File.Delete(filename);
                    Console.WriteLine("Deleted" + " " + filename);
                }

                */

                /* I essentially : 
                 * - Made it so that it only creates a file when a file doesnt exist
                 * - I needed a way to compare hashes of the same inputted password,
                 * - and it kept making a new usernames.csv so I changed that 
                 * - encryptPass.cs works perfectly. It stores hashed information
                 * - and now we only need to retrieve it for log in use.
                 */


                if (!File.Exists(userFile))
                {
                    using (FileStream fs = File.Create(userFile))
                    {
                        fs.Close();
                        Console.WriteLine("File Created");

                        try
                        {
                            using (StreamWriter sw = new StreamWriter(filename))
                            {
                                sw.WriteLine("username, hashed pass, full name");
                                sw.Close();
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                    }
                }
                else if (!File.Exists(punchFile))
                {
                    try
                    {
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

                /* You're stuff
                using (FileStream fs = File.Create(filename))
                {
                    if (filename == userFile)
                    {
                        fs.Close();
                        try
                        {
                            using (StreamWriter sw = new StreamWriter(filename))
                            {
                                sw.WriteLine("username, hashed pass, first name, last name");
                                sw.Close();
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                    }
                    else if (filename == punchFile)
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
                    Console.WriteLine("Created file" + " " + filename);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            } */
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void WriteUser(User temp)
        {
            if (File.ReadAllText(userFile).Contains(temp.username))
            {
                Console.WriteLine("Username exists");
                Console.ReadLine();
            }
            else if (!File.ReadAllText(userFile).Contains(temp.username))
            {
                using (StreamWriter sw = new StreamWriter(userFile, true))
                {
                    sw.WriteLine(temp.username + "," + temp.password + "," + temp.name);
                    sw.Close();
                }
            }
        }

        /*
         * File will create a punch in the following format
         * Username, punch type, date/time, punch ID
         */ 
        public void WritePunch(Punch temp)
        {
            string punchData = temp.username + "," + temp.punchType + "," + temp.dt + "," + temp.punchId;
            using (StreamWriter sw = new StreamWriter(punchFile, true))
            {
                sw.WriteLine(punchData);
                sw.Close();
            }
        }
        
    }

}

