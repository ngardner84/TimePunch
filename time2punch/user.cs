using System;

namespace time2punch
{
    public class User
    {
        public string name { get; private set; }
        public string employeeId { get; private set; }
        public string password { get; set; }
        public float payRate { get; set; }


        public User()
        {
            employeeId = genUserId();
            password = null;
            payRate = 0.0f;

        }

        // Generate unique User ID
        private static string genUserId()
        {
            string genId = Guid.NewGuid().ToString("N");
            return genId;
        }

        // User functions
        public Punch StartShift()
        {
            Punch punch = new Punch
            {
                punchType = "StartShift"
            };
            return punch;
        }

        public Punch EndShift()
        {
            Punch punch = new Punch
            {
                punchType = "EndShift"
            };
            return punch;
        }

        public Punch StartLunch()
        {
            Punch punch = new Punch
            {
                punchType = "StartLunch"
            };
            return punch;
        }

        public Punch EndLunch()
        {
            Punch punch = new Punch
            {
                punchType = "EndLunch"
            };
            return punch;
        }

        private int ChangePass()
        {
            return 0;
        }

        // Admin inherits User
        public class Admin : User
        {

            public Admin()
            {

            }
            /*
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
}