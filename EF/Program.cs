using System;
using System.Linq;

namespace EF
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolContext schoolContext = new SchoolContext();

            var users = schoolContext.User.ToList();

            foreach (var user in users)
            {
                Console.WriteLine(user.Name);
            }

            Console.ReadLine();
        }
    }
}
