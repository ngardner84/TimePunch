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
            Console.Write("Enter first and last name: ");
            string someName = Console.ReadLine();
            Console.Write("Create Username: ");
            string someUserName = Console.ReadLine();
            Console.Write("Create Password: ");
            string somePassword = Console.ReadLine();

            FileWriter fw = new FileWriter();
            fw.createFile("punch.csv");
            User newUser = new User(someUserName, somePassword, someName);
            fw.writeUser(newUser);
            Console.WriteLine("\nUsername: " + newUser.username + "\nPassword: " + newUser.password + "\nPayRate: " + newUser.payRate);
           
            
            Punch a = newUser.StartShift();
            fw.writePunch(a);
            Console.WriteLine("Punch Time: " + a.dt);
            Console.WriteLine("Punch Type: " + a.punchType);
            Console.WriteLine("Punch ID: " + a.punchId);


            Console.ReadLine();

        }
    }
}
