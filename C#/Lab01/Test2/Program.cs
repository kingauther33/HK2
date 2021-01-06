using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            int english, science, math;
            bool inValid;
            do
            {
                inValid = false;
                Console.Write("Your English mark: ");
                english = Convert.ToInt32(Console.ReadLine());
                Console.Write("Your Science mark: ");
                science = Convert.ToInt32(Console.ReadLine());
                Console.Write("Your Math mark: ");
                math = Convert.ToInt32(Console.ReadLine());
                if ((english > 100) || (english < 0) ||
                    (science > 100) || (science < 0) ||
                    (math > 100) || (math < 0))
                {
                    inValid = true;
                    Console.WriteLine("Invalid input. Please try input again :(");
                }
                Console.WriteLine("---------------------------");
            } while (inValid);

            double percent = (math + english + science) / 3;
            int prize;
            if (percent > 70)
            {
                prize = 1500;
                Console.WriteLine("You are excellent! Your scholarship worths {0}$", prize);
            } else if (percent >= 60)
            {
                prize = 1000;
                Console.WriteLine("You are good! Your scholarship worths {0}$", prize);
            } else if (percent >= 35)
            {
                prize = 0;
                Console.WriteLine("Congratulations! You have passed the exam");
            }
            else
            {
                prize = 0;
                Console.WriteLine("Unlucko you have failed the exam ;( Try harder next time :)");
            }
        }
    }
}
