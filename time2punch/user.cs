using System;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;

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
            writeUser(); // debug purposes

        }

        private string writeUser()
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
                    if (users == null | !users.Contains(this.username)) // write to csv if users is empty, or if it doesnt contain the typed username
                    {
                        sw.WriteLine(this.username);
                        sw.Close();
                    }
                    else if (users.Contains(this.username)) 
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
