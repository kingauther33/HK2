using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ss7_Ex1Chua
{
    class Military : Personnel
    {
        private int children;
        private int prosWorking;
        private int oldPeople;

        public void Create()
        {
            Console.Write("Please enter the number of children: ");
            children = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the number of working professionals: ");
            prosWorking = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the number of old people in your family: ");
            oldPeople = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------");
        }

        public void Display()
        {
            Console.WriteLine("The number of children in your family: " + children);
            Console.WriteLine("The number of working professionals in  your family: " + prosWorking);
            Console.WriteLine("The number of old people in your family: " + oldPeople);
        }
    }
}
