using System;

namespace Ex1
{
    internal class Sales
    {
        private int MedCode { get; set; }
        private int MedQtySold { get; set; }
        private int PlanSale { get; set; }
        private int ActualSale { get; set; }
        private string Region { get; set; }

        public Sales()
        {
        }

        public Sales(int medCode, int medQtySold, int planSale, int actualSale, string region)
        {
            this.MedCode = medCode;
            this.MedQtySold = medQtySold;
            this.PlanSale = planSale;
            this.ActualSale = actualSale;
            this.Region = region;
        }

        public void Accept()
        {
            Console.Write("Please enter the Medicine Code: ");
            this.MedCode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the Medicine Quantity: ");
            this.MedQtySold = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the Planned Sales: ");
            this.PlanSale = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the Actual Sales: ");
            this.ActualSale = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the Medicine Quantity: ");
            this.Region = Console.ReadLine();
            Console.WriteLine("-------------------------------- ");
        }

        public void Display()
        {
            Console.WriteLine("The Sales details for Medicine Code {0} is as below:", MedCode);
            Console.WriteLine("Quantity Sold: " + MedQtySold);
            Console.WriteLine("Planned Sales: " + PlanSale);
            Console.WriteLine("Actual Sales: " + ActualSale);
            Console.WriteLine("Region: " + Region);
            Console.WriteLine("--------------------------------");
        }

        public void Display(int MedCode)
        {
            if (MedCode == this.MedCode)
            {
                Console.WriteLine("The different between the actual sales and planned sales is (Actual - Plan): " + (ActualSale - PlanSale));
            }
            else
            {
                Console.WriteLine("You input the wrong medCode, please input again...");
            }
        }
    }
}