using System;

namespace Lab04
{
    internal class Student
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private DateTime Dob { get; set; }
        private float Gpa { get; set; }

        private Student(int id, string name, DateTime dob, float gpa)
        {
            this.Id = id;
            this.Name = name;
            this.Dob = dob;
            this.Gpa = gpa;
        }

        private Student()
        {
            this.Id = 0;
            this.Name = "";
            this.Dob = DateTime.Now;
            this.Gpa = 0;
        }

        private void ReadInfo()
        {
            Console.Write("Please enter your ID number: ");
            this.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your name: ");
            this.Name = Console.ReadLine();
            Console.Write("Please enter your date of birth: ");
            this.Dob = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Please enter your GPA: ");
            this.Gpa = Convert.ToSingle(Console.ReadLine());
        }

        private void DisplayInfo()
        {
            Console.WriteLine("Your ID number: " + this.Id);
            Console.WriteLine("Your Name: " + this.Name);
            Console.WriteLine("Your Date of Birth: " + Dob.Date);
            Console.WriteLine("Your GPA: " + Gpa);
        }

        private void Create(int Id, string Name, DateTime DoB, float Gpa)
        {
            this.Id = Id;
            this.Name = Name;
            this.Dob = DoB;
            this.Gpa = Gpa;
        }

        private void Create(int Id, string Name, float Gpa)
        {
            this.Id = Id;
            this.Name = Name;
            this.Gpa = Gpa;

        }

        private static void Main(string[] args)
        {
            Student student1 = new Student(1, "Dat", new DateTime(1999, 10, 10), 3.3f);
            Student student2 = new Student(2, "Toan", new DateTime(1998, 12, 19), 3.3f);
            Student student4 = new Student(name: "Toan", dob: new DateTime(1999, 10, 19), gpa: 3.5f, id: 5);
            Student student5 = new Student();
            Student student6 = new Student();

            Student student3 = new Student();
            student3.ReadInfo();
            student1.DisplayInfo();
            student2.DisplayInfo();
            student3.DisplayInfo();
            student4.DisplayInfo();
            student5.Create(10, "An", Convert.ToDateTime("10/10/1998"), 3.1f);
            student6.Create(11, "Ting Ting", 3.5f);
            Console.ReadLine();
        }
    }
}