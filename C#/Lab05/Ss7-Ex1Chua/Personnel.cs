using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ss7_Ex1Chua
{
    class Personnel
    {
        private int _personId;
        private string _name;
        private DateTime _doB;
        private string _rank;
        private List<Health> _healths = new List<Health>();

        public void Create()
        {
            Console.Write("Please enter your Personal ID: ");
            _personId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your name: ");
            _name = Console.ReadLine();
            Console.Write("Please enter Date of Birth: ");
            _doB = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Please enter Your Current rank (or before retired): ");
            _rank = Console.ReadLine();
            Console.Write("Please enter the total number of your health records: ");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*********");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Record number {0}:", (i + 1));
                Health h1 = new Health();
                Console.Write("Please enter Record ID: ");
                h1.RecordId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter the reason: ");
                h1.Reason = Console.ReadLine();
                Console.Write("Please enter Prescription: ");
                h1.Prescription = Console.ReadLine();
                Console.Write("Please enter the record Date: ");
                h1.RecordDate = Convert.ToDateTime(Console.ReadLine());
                _healths.Add(new Health() {RecordId = h1.RecordId, Reason = h1.Reason, Prescription = h1.Prescription, RecordDate = h1.RecordDate});
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------");
        }

        public void Display()
        {
            Console.WriteLine("Your Personal ID: " + _personId);
            Console.WriteLine("Your Name: " + _name);
            Console.WriteLine("Your Date of Birth: " + _doB);
            Console.WriteLine("Your Rank: " + _rank);
            Console.WriteLine("Your Health History Details:");
            foreach (Health health in _healths)
            {
                Console.WriteLine(health);
            }
            Console.WriteLine("=======================");
        }
    }
}
