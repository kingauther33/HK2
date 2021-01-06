using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] customerId = new int[3];
            int[] accountNum = new int[3];
            char[] type = new char[3];
            DateTime[] openDate = new DateTime[3];
            double[] deposit = new double[3];
            double[] balance = new double[3];
            for (int i = 0; i < 3; i++)
            {
                balance[i] = 10000 * i;
                Console.Write("Enter the ID of the customer number {0}: ", i + 1);
                customerId[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter account number {0}: ", i + 1);
                accountNum[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter account type [Fixed/Savings] (F/S) number {0}: ", i + 1);
                type[i] = Convert.ToChar(Console.ReadLine());
                Console.Write("Enter the date of opening account[MM/DD/YYYY] number {0}: ", i + 1);
                openDate[i] = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Enter the amount deposited for number {0}: ", i + 1);
                deposit[i] = Convert.ToDouble(Console.ReadLine());
                balance[i] += deposit[i];
                Console.WriteLine("--------------------------------\n");
            }

            Console.WriteLine("Account Details: ");
            Console.WriteLine("ID".PadRight(15) + "A/c no.".PadRight(15) + "A/c type".PadRight(15) +
                "Opening Date".PadRight(27) + "Deposit($)".PadRight(15) + "Balance($)".PadRight(15));
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}{5}", Convert.ToString(customerId[i]).PadRight(15),
                    Convert.ToString(accountNum[i]).PadRight(15), Convert.ToString(type[i]).PadRight(15),
                    Convert.ToString(openDate[i]).PadRight(27), Convert.ToString(deposit[i]).PadRight(15),
                    Convert.ToString(balance[i]).PadRight(15));
            }

            Console.Write("Enter the account number whose details you want to view: ");
            byte searchAcc = Convert.ToByte(Console.ReadLine());
            for (int i = 0; i < 3; i++)
            {
                if (accountNum[i] == searchAcc)
                {
                    Console.WriteLine("Record found!!!");
                    Console.WriteLine("{0}{1}{2}{3}{4}{5}", "ID".PadRight(15), "A/c no.".PadRight(15), "A/c type".PadRight(15),
                        "Opening Date".PadRight(27), "Deposit($)".PadRight(15), "Balance($)".PadRight(15));
                    break;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (accountNum[i] == searchAcc)
                {
                    Console.WriteLine("{0}{1}{2}{3}{4}{5}", Convert.ToString(customerId[i]).PadRight(15),
                        Convert.ToString(accountNum[i]).PadRight(15), Convert.ToString(type[i]).PadRight(15),
                        Convert.ToString(openDate[i]).PadRight(27), Convert.ToString(deposit[i]).PadRight(15),
                        Convert.ToString(balance[i]).PadRight(15));
                }

            }

            Console.ReadLine();
        }
    }
}

