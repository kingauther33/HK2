﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Lion : Animals
    {
        public Lion(double weight, string name)
        {
            base.setMe(weight, name);
        }
        public override void show()
        {
            Console.WriteLine("I am a LION ^_^");
            Console.WriteLine("My name is: " + Name);
            Console.WriteLine("My weight is: " + Weight);
        }
    }
}
