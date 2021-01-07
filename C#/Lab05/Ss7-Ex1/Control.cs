using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ss7_Ex1
{
    class Control
    {
        readonly Troops _troop1 = new Troops("An", "Vietnam", 1);
        readonly Personnel _person1 = new Personnel("An", 21, Convert.ToDateTime("10/10/1999"), 1, "Nothing Special");
        readonly Medicine _med1 = new Medicine(100, "Cold Meds", Convert.ToDateTime("10/20/2024"), "Vietnam", "In good condition");
        readonly Family _fam1 = new Family("Trung",2, 1, 4);

        readonly Retirees _retire1 = new Retirees("Trung", "Vietnam", "Sergent", Convert.ToDateTime("10/10/1966"),
            "In bad condition");

        readonly ExpiredPeople _expired1 = new ExpiredPeople("Tuong", "Vietnam", "General", 5);
        static void Main(string[] args)
        {
            Control c1 = new Control();
            c1.DisplayTroop(c1._troop1);
            c1.DisplayPerson(c1._person1);
            c1.DisplayMedicine(c1._med1);
            c1.DisplayFamily(c1._fam1);
            c1.DisplayRetirees(c1._retire1);
            c1.DisplayExpired(c1._expired1);
            Console.ReadLine();
        }

        public void DisplayTroop(Troops troops)
        {
            Console.WriteLine("Troops details: ");
            Console.WriteLine("The person name: " + troops.Name);
            Console.WriteLine("The posted location: " + troops.PostedLocation);
            Console.WriteLine("His/Her Group Number: " + troops.GroupNum);
            Console.WriteLine("--------------------------------");
        }

        public void DisplayPerson(Personnel personnel)
        {
            Console.WriteLine("Personnel Details:");
            Console.WriteLine("Name: " + personnel.Name);
            Console.WriteLine("Age: " + personnel.Age);
            Console.WriteLine("Date of Birth: " + personnel.DoB);
            Console.WriteLine("Gender: " + personnel.Gender);
            Console.WriteLine("Health History: " + personnel.HealthHistory);
            Console.WriteLine("--------------------------------");
        }

        public void DisplayMedicine(Medicine medicine)
        {
            Console.WriteLine("Medicine Details:");
            Console.WriteLine("The total of this medicine: " + medicine.TotalMed);
            Console.WriteLine("Medicine name: " + medicine.MedName);
            Console.WriteLine("The expire date: " + medicine.ExpireDate);
            Console.WriteLine("The Status of medicine in {0}: {1}", medicine.PostedLocation, medicine.LocationStatus);
            Console.WriteLine("--------------------------------");
        }

        public void DisplayFamily(Family family)
        {
            Console.WriteLine("Family details of {0}:", family.Name);
            Console.WriteLine("The number of children: " + family.Children);
            Console.WriteLine("The number of people working as pros: " + family.WorkingPros);
            Console.WriteLine("The number of old people: " + family.OldPeople);
            Console.WriteLine("--------------------------------");
        }

        public void DisplayRetirees(Retirees retirees)
        {
            Console.WriteLine("Retiree details:");
            Console.WriteLine("The Person Name: " + retirees.Name);
            Console.WriteLine("The Posted Location: " + retirees.PostedLocation);
            Console.WriteLine("Rank before retired: " + retirees.RankRetired);
            Console.WriteLine("Date of Birth: " + retirees.DoB);
            Console.WriteLine("Health History: " + retirees.HealthHistory);
            Console.WriteLine("--------------------------------");
        }

        public void DisplayExpired(ExpiredPeople expired)
        {
            Console.WriteLine("Expired details: ");
            Console.WriteLine("The Person Name: " + expired.Name);
            Console.WriteLine("The Posted Location: " + expired.PostedLocation);
            Console.WriteLine("Rank before retired: " + expired.RankRetired);
            Console.WriteLine("Number of dependent family members: " + expired.DependFamily);
            Console.WriteLine("--------------------------------");
        }
    }
}
