using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTrenLop5
{
    class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Every animal eats something");
        }

        protected void DoSomething()
        {
            Console.WriteLine("Every animal does something");
        }
    }
    class OverRide:Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cat loves to eat The mouse");
        }

        static void Main(string[] args)
        {
            OverRide objOverRide = new OverRide();
        }
    }
}
