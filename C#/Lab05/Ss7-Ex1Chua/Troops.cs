using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ss7_Ex1Chua
{
    class Troops
    {
        private int id;
        private string name;
        private string location;
        private int numGroup;

        public void Create()
        {
            Console.Write("Please enter your Troop Id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your Name: ");
            name = Console.ReadLine();
            Console.Write("Please enter your Troop location: ");
            location = Console.ReadLine();
            Console.Write("Please enter your group number: ");
            numGroup = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------");
        }

        public void Display()
        {
            Console.WriteLine("Your Troop Id: " + id);
            Console.WriteLine("Your Name: " + name);
            Console.WriteLine("Your Troop location: " + location);
            Console.WriteLine("The number of groups in your troop: " + numGroup);
            Console.WriteLine("=======================");
        }
    }
}
