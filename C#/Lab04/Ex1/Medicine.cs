using System;

namespace Ex1
{
    public class Medicine
    {
        private int MedCode { get; set; }
        private string MedName { get; set; }
        private string ManuName { get; set; }
        private float MedPrice { get; set; }
        private byte MedQty { get; set; }
        private DateTime ManuDate { get; set; }
        private DateTime ExDate { get; set; }
        private int BatchNum { get; set; }

        public Medicine()
        {
        }

        public Medicine(int medCode, string medName, string manuName, float medPrice, byte medQty, DateTime manuDate, DateTime exDate, int batchNum)
        {
            this.MedCode = medCode;
            this.MedName = medName;
            this.ManuName = manuName;
            this.MedPrice = medPrice;
            this.MedQty = medQty;
            this.ManuDate = manuDate;
            this.ExDate = exDate;
            this.BatchNum = batchNum;
        }

        public void Accept()
        {
            Console.Write("Please enter your Medicine Code: ");
            this.MedCode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your Medicine Name: ");
            this.MedName = Console.ReadLine();
            Console.Write("Please enter your Manufacturer Name: ");
            this.ManuName = Console.ReadLine();
            Console.Write("Please enter your Unit Price: ");
            this.MedPrice = Convert.ToSingle(Console.ReadLine());
            Console.Write("Please enter your Quantity of Hand: ");
            this.MedQty = Convert.ToByte(Console.ReadLine());
            Console.Write("Please enter your Manufactured Date: ");
            this.ManuDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Please enter your Expiry Date: ");
            this.ExDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Please enter your Batch Number: ");
            this.BatchNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------");
        }

        public void Print()
        {
            Console.WriteLine("The Medicine Code is: " + MedCode);
            Console.WriteLine("The Medicine Name is: " + MedName);
            Console.WriteLine("The Manufacturer Name is: " + ManuName);
            Console.WriteLine("The Unit Price is: " + MedPrice);
            Console.WriteLine("The Quantity on Hand is: " + MedQty);
            Console.WriteLine("The Manufactured Date is: " + ManuDate);
            Console.WriteLine("The Expiry Date is: " + ExDate);
            Console.WriteLine("The Batch Number is: " + BatchNum);
            Console.WriteLine("--------------------------------");
        }

        public void Print(int medCode, string medName)
        {
            if (medCode == this.MedCode && medName == this.MedName)
            {
                Console.WriteLine("The Manufactured Date is: " + ManuDate);
                Console.WriteLine("The Expiry Date is: " + ExDate);
            }
            else
            {
                Console.WriteLine("Wrong Code or Name input, please try again :(");
            }
        }

        public void Plus50()
        {
            if (MedQty == 0)
            {
                MedQty += 50;
            }
            else
            {
                Console.WriteLine("This medicine is not new!!! You cannot add 50 more into it.");
            }
        }
    }
}