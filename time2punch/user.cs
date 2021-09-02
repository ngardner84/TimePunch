using System;
using System.IO;


namespace time2punch
{
    public class User
    {
        public string name { get; private set; }
        public string username { get; private set; }
        public string password { get; set; }
        public float payRate { get; set; }

        
        public User(string un, string pw)
        {
            username = un;
            password = pw;
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

            using (StreamWriter sw = new StreamWriter("usernames.csv", true))
            {
                sw.WriteLine(this.username);
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
