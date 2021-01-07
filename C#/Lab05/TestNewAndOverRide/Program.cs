using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestNewAndOverRide
{
    class Based
    {
        public virtual void Speak()
        {
            Console.WriteLine("This is base class");
        }
    }

    class Deprived:Based
    {
        public override void Speak()
        {
            Console.WriteLine("This is Speak in Deprived Class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Based b = new Deprived();

            b.Speak();
        }
    }
}
