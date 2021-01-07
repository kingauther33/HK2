using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ss7_Ex1
{
    class Personnel:Troops
    {
        public int Age { get; set; }
        public DateTime DoB { get; set; }
        public byte Gender { get; set; }
        public string HealthHistory { get; set; }

        public Personnel(string name, int age, DateTime doB, byte gender, string healthHistory)
        {
            Name = name;
            Age = age;
            DoB = doB;
            Gender = gender;
            HealthHistory = healthHistory;
        }
        protected Personnel() { }
    }

    class Family : Personnel
    {
        public int Children { get; set; }
        public int WorkingPros { get; set; }
        public int OldPeople { get; set; }

        public Family(string name, int children, int workingPros, int oldPeople)
        {
            Name = name;
            Children = children;
            WorkingPros = workingPros;
            OldPeople = oldPeople;
        }
    }
}
