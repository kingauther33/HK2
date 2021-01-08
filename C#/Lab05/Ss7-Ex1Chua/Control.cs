using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ss7_Ex1Chua
{
    class Control
    {
        static void Main(string[] args)
        {
            Troops troop1 = new Troops();
            Personnel person1 = new Personnel();
            troop1.Create();
            troop1.Display();
            person1.Create();
            person1.Display();
            Console.ReadLine();
        }
    }
}
