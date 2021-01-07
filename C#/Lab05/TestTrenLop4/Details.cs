using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestTrenLop4
{
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("The Animal constructor without parameter");
        }

        public Animal(string Name)
        {
            Console.WriteLine("The Animal constructor with a String parameter: " + Name);
        }
    }

    class Canine:Animal
    {
        public Canine() :base()
        {
            Console.WriteLine("The Deprived Constructor Canine");
        }
    }
    class Details
    {
        static void Main(string[] args)
        {
            Canine objCanine = new Canine();
        }
    }
}
