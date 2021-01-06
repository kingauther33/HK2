using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Test
    {
        static void Main(string[] args)
        {
            Medicine med1 = new Medicine(1, "Anti HIV", "An Dink Factory", 10000f, 100, Convert.ToDateTime("12/10/2020"), Convert.ToDateTime("12/10/2021"), 10);
            Sales sales1 = new Sales(1, 20, 30, 25, "US");
            Medicine med2 = new Medicine(2, "Anti Covid", "Hieu Factory", 5000f, 0, Convert.ToDateTime("11/10/2020"),
                Convert.ToDateTime("12/10/2022"), 2);
            Sales sales2 = new Sales(2, 25, 35, 40, "US");
            Medicine med3 = new Medicine();
            Sales sales3 = new Sales();

            med1.Print();
            med1.Plus50();
            sales1.Display();

            med2.Print(2, "Anti Covid");
            med2.Plus50();
            sales2.Display(2);

            med3.Accept();
            med3.Print();
            med3.Plus50();
            sales3.Accept();
            sales3.Display(3);
        }
    }
}
