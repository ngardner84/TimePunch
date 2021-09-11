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

            FileAccess fa = new FileAccess();

            fa.CreateFile("usernames.csv");

            Console.WriteLine("enter username: ");
            string someUserName = Console.ReadLine();
            Console.WriteLine("create a password: ");
            string somePassword = Console.ReadLine();
            Console.WriteLine("enter a first/last name: ");
            string someFl = Console.ReadLine();
            User newUser = new User(someUserName, somePassword, someFl);
            fa.WriteUser(newUser);


            /*
            FileWriter fw = new FileWriter();
            Console.Write("Enter first and last name: ");
            string someName = Console.ReadLine();
            Console.Write("Create Username: ");
            string someUserName = Console.ReadLine();
            Console.Write("Create Password: ");
            string somePassword = Console.ReadLine();
            fw.CreateFile("usernames.csv");
            /*

            
            fw.CreateFile("punch.csv");
            User newUser = new User(someUserName, somePassword, someName);
            fw.WriteUser(newUser);
            Console.WriteLine("\nUsername: " + newUser.username + "\nPassword: " + newUser.password + "\nPayRate: " + newUser.payRate);
           
            
            Punch a = newUser.StartShift();
            fw.WritePunch(a);
            Console.WriteLine("Punch Time: " + a.dt);
            Console.WriteLine("Punch Type: " + a.punchType);
            Console.WriteLine("Punch ID: " + a.punchId);


            Console.ReadLine();
            */
        }
    }
}
