using System;

public class User
{
	int employeeId;
	int password;
	int isAdmin;
	int payRate;

	private static int StartShfit(employeeId)
	{

	}

	private static int EndShift(employeeId)
    {

    }

	private static int StartLunch(employeeId)
    {

    }

	private static int EndLunch(employeeId)
    {

    }

	private static int ChangePass(password)
    {

    }

	private static int ChangeAdmin(isAdmin)
    {

    }

    // From my understanding, I don't think we take the arguments ID, PW, and payrate here 
    // Wouldn't taking these pull from the locally created instance of User?
    // Same with ChangePayRate, if we change pay rate I think we would be changing the current users payrate, not the target
	private static int CreateUser(isAdmin, employeeId, password, payRate) 
    {

    }

	private static int ChangePayRate(isAdmin, PayRate)
    {

    }
}
