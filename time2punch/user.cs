using System;

namespace TimePunch
{
    public class User
    {

        private int employeeId;
        private string password;
        float payRate;

        public User()
        {
            employeeId = genUserId();
            password = null;
            payRate = 0.0f;

        }
        // Generate unique User ID
        private static int genUserId()
        {
            string genId = Guid.NewGuid().ToString("N");
            int uniqueId = Convert.ToInt32(genId);
            return uniqueId;
        }

        // User functions
        private static int StartShift()
        {
            Punch punch = new Punch
            {
                punchType = "StartPunch"
            };
            return 0;
        }

        private static int EndShift()
        {
            Punch punch = new Punch
            {
                punchType = "EndShift"
            };
            return 0;
        }

        private static int StartLunch()
        {
            Punch punch = new Punch
            {
                punchType = "StartLunch"
            };
            return 0;
        }

        private static int EndLunch()
        {
            Punch punch = new Punch
            {
                punchType = "EndLunch"
            };
            return 0;
        }

        private static int ChangePass()
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