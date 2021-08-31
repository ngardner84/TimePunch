using System;

public class User
{
	int employeeId;
	int password;
	int isAdmin;
	int payRate;

	private static int StartShfit(employeeId)
	{
        return 0;
	}

	private static int EndShift(employeeId)
    {
        return 0;
    }

    private static int StartLunch(employeeId)
    {
        return 0;
    }

	private static int EndLunch(employeeId)
    {
        return 0;
    }

	private static int ChangePass(password)
    {
        return 0;
    }

	private static int ChangeAdmin(isAdmin)
    {
        return 0;
    }

    // From my understanding, I don't think we take the arguments ID, PW, and payrate here 
    // Wouldn't taking these pull from the locally created instance of User?
    // Same with ChangePayRate, if we change pay rate I think we would be changing the current users payrate, not the target
	private static int CreateUser(isAdmin, employeeId, password, payRate) 
    {
        return 0;
    }

	private static int ChangePayRate(isAdmin, PayRate)
    {
        return 0;
    }
}
