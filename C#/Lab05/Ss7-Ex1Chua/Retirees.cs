using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ss7_Ex1Chua
{
    class Retirees : Personnel
    {
        private byte rankedStatus;
        private float feeReduce;

        public void Create()
        {
            Console.Write("Please enter your ranked status(1/2/3): ");
            rankedStatus = Convert.ToByte(Console.ReadLine());
        }

        public void Display()
        {
            switch (rankedStatus)
            {
                case 1:
                    Console.WriteLine("You have 30% medical service reduction");
                    feeReduce = 30f;
                    break;
                case 2:
                    Console.WriteLine("You have 50% medical service reduction");
                    feeReduce = 50f;
                    break;
                case 3:
                    Console.WriteLine("You are provided with free medical service for the rest of your life!!");
                    feeReduce = 100f;
                    break;
                default:
                    Console.WriteLine("You input wrong ranked status, so no fee reduction :(");
                    feeReduce = 0;
                    break;
            }
        }

        public void Cases(DateTime doB)
        {
            if ((DateTime.Today.Year - doB.Year) >= 75)
            {

            }
        }
    }
}
