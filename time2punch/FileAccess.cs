using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace time2punch
{
    //Will need to create a FileAccess object whenever we want to run the functions
    class FileAccess
    {
        public static string userFile = "usernames.csv";
        public static string punchFile = "punch.csv";

        public FileAccess()
        {
            
        }

        /*
        Function to create file - will delete existing file if found and recreate
        */

        public void CreateFile(string filename)
        {
            try
            {
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
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /*
        public static bool CheckLogin(string un, string pw)
        {

            bool doesExist;

            return doesExist;
        }*/
        
        public static string HashPassword(User temp)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(temp.password);
            SHA256Managed hashString = new SHA256Managed();
            byte[] hash = hashString.ComputeHash(bytes);
            string hashedString = string.Empty;

            foreach (byte x in hash)
            {
                hashedString += String.Format("{0:x2}", x);
            }
            
            return hashedString;
        }

        public void WriteUser(User temp)
        {

            string hashedPass = HashPassword(temp);
            if (File.ReadAllText(userFile).Contains(temp.username))
            {
                Console.WriteLine("Username exists");
                Console.ReadLine();
            }
            else if (!File.ReadAllText(userFile).Contains(temp.username))
            {
                using (StreamWriter sw = new StreamWriter(userFile, true))
                {
                    sw.WriteLine(temp.username + "," + hashedPass + "," + temp.name);
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

