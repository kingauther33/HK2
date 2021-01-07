using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ss7_Ex1
{
    class Troops
    {
        public string Name { get; set; }
        public string PostedLocation { get; set; }
        public int GroupNum { get; set; }

        public Troops(string name, string postedLocation, int groupNum)
        {
            Name = name;
            PostedLocation = postedLocation;
            GroupNum = groupNum;
        }
        protected Troops() { }
    }

    class Retirees : Personnel
    {
        public string RankRetired { get; set; }

        public Retirees(string name, string postedLocation, string rankRetired, DateTime doB, string healthHistory)
        {
            Name = name;
            PostedLocation = postedLocation;
            RankRetired = rankRetired;
            DoB = doB;
            HealthHistory = healthHistory;
        }
        protected Retirees() { }
    }

    class ExpiredPeople : Retirees
    {
        public int DependFamily { get; set; }

        public ExpiredPeople(string name, string postedLocation, string rankRetired, int dependFamily)
        {
            Name = name;
            PostedLocation = postedLocation;
            RankRetired = rankRetired;
            DependFamily = dependFamily;
        }
    }
}
