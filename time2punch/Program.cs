using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace time2punch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Create Username: ");
            string someUserName = Console.ReadLine();
            Console.Write("Create Password: ");
            string somePassword = Console.ReadLine();

            User newUser = new User(someUserName, somePassword);
            Console.WriteLine("\nUsername: " + newUser.username + "\nPassword: " + newUser.password + "\nPayRate: " + newUser.payRate);
           
            
            Punch a = newUser.StartShift();
            Console.WriteLine("Punch Time: " + a.dateTime);
            Console.WriteLine("Punch Type: " + a.punchType);
            Console.WriteLine("Punch ID: " + a.punchId);


            Console.ReadLine();

        }
    }
}
