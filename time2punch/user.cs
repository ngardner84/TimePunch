using System;

namespace TimePunch
{
    public class user
    {

        private int employeeId;
        private string password;
        float payRate;

        public user()
        {
            employeeId = 000;
            password = "none";
            payRate = 0.0f;

        }

        private static int StartShift()
        {
            return 0;
        }

        private static int EndShift()
        {
            return 0;
        }

        private static int StartLunch()
        {
            return 0;
        }

        private static int EndLunch()
        {
            return 0;
        }

        private static int ChangePass()
        {
            return 0;
        }

        class Admin : user
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