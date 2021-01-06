using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class testA
    {
        public String name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int z = 1;
            Console.WriteLine("****Test value type: ");
            Console.WriteLine("The value of z before: " + z);
            changeValue(z);
            Console.WriteLine("The value of z after: " + z);

            Console.WriteLine("***Test reference type: ");
            
        }
        public static void changeValue(int k)
        {
            Console.WriteLine("[in changeValue] original value: " + k);
            k = 100;
            Console.WriteLine("[in changeValue] new value " + k);
        }
        public static void changeValue2(testA v)
        {
            v.name = "changed it";
        }
    }
}
