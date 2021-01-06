using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            String stars = "";
            for (int i = 0; i < 5; i++)
            {
                stars += "*";
                Console.WriteLine(stars);
            }
            Console.ReadKey();
        }
    }
}
