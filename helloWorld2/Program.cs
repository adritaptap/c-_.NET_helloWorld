using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld2
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = new Message();
            string line;
            string[] user = Environment.UserName.Split('.');
            string lastName = user[1].First() + String.Join("", user[1].Skip(1)).ToLower();
           
            do
            {
                Console.WriteLine(message.HelloMessage + " " + user[0] + " " + lastName);
                Console.WriteLine("que voulez-vous faire ?");
                line = Console.ReadLine().ToString();
            } while (line != "exit");
        }
    }
}
