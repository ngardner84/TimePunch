using System;
using System.IO;
using Microsoft.VisualBasic.FileIO;


namespace time2punch
{
    public class User
    {
        public string name { get; private set; }
        public string username { get; private set; }
        public string password { get; set; }
        public float payRate { get; set; }

        
        public User(string un, string pw, string fl)
        {
            username = un;
            password = pw;
            name = fl;
            payRate = 0.0f;

            writeUser();

        }


        // 
        private string writeUser()
        {
            // NEEDS TO BE DONE
            // Ask username, Scan csv for existing
            // If no, proceed
            // if yes, redo

            
            string filePath = "usernames.csv";
            string users;

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    users = sr.ReadLine();
                    sr.Close();
                }

                using (StreamWriter sw = new StreamWriter(filePath))
                {

                    if (users == null) // we can imply usernames.csv is empty
                    {
                        sw.WriteLine(this.username);
                    }
                    else if (users.Contains(this.username)) // not sure why this branch clears the csv file
                    {
                        Console.WriteLine("username already exists");
                        sw.Close();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: \n");
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }

            /*
            var file = File.ReadLines("usernames.csv");
            foreach(var line in file)
            {
                if (line.Equals(this.username))
                {
                    Console.WriteLine("already exists");
                    Console.ReadLine();

                }
                else
                {
                    using (StreamWriter sw = new StreamWriter("usernames.csv", true))
                    {
                        sw.Close();
                        sw.WriteLine(this.username);
                    }

                }
            }

            /*
            using (StreamReader sr = new StreamReader("usernames.csv"))
            {
                if (this.username != sr.ReadLine())
                {
                    using (StreamWriter sw = new StreamWriter("usernames.csv", true))
                    {
                        sw.WriteLine(this.username);
                    }
                } else
                {
                    Console.WriteLine("username exists");
                    Console.ReadLine();
                }
            }
            */

            return this.username;
        }

        // User functions
        public Punch StartShift()
        {
            Punch punch = new Punch("StartShift", this.username);
            return punch;
        }

        public Punch EndShift()
        {
            Punch punch = new Punch("EndShift", this.username);
            return punch;
        }

        public Punch StartLunch()
        {
            Punch punch = new Punch("StartLunch", this.username);
            return punch;
        }

        public Punch EndLunch()
        {
            Punch punch = new Punch("EndLunch", this.username);
            return punch;
        }

        private int ChangePass()
        {
            return 0;
        }

        // Admin inherits User
        /*
       public class Admin : User
       {

           public Admin()
           {

           }

                   private void changePunch(punchId, employeeId, punchTime)
                   {

                   }

                   private static int changePass(employeeId, password)
                   {
                       return 0;
                   }
                   private static int changeAdmin(employeeId, isAdmin)
                   {
                       return 0;
                   }
                   private static int createUser(isAdmin, employeeId, password, payRate)
                   {
                       return 0;
                   }
                   private static int changePayRate(isAdmin, PayRate)
                   {
                       return 0;
                   }
           */
    }
}
