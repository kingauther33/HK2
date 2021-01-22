using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    abstract class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Every animal eats food in order to survive.");
        }
        public abstract void AnimalSound();
    }
}
