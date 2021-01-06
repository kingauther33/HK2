using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicityTypeAndAnonymous
{
    class Program
    {
        static void Main(string[] args)
        {
            //Anonymous Types
            var p1 = new { Name = "A", Price = 3 };
            Console.WriteLine("Name = {0}\nPrice = {1}",
                p1.Name.ToLower(), p1.Price);

            //Implicity typed local variables
            var i = 5;
            var s = "hello";
            Console.WriteLine("Type of i: " + i.GetType());
            //s is a String
            Console.WriteLine("First letter of: " + s.Substring(1, 1));
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
