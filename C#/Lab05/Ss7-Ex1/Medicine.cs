using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ss7_Ex1
{
    class Medicine:Troops
    {
        public int TotalMed { get; set; }
        public string MedName { get; set; }
        public DateTime ExpireDate { get; set; }
        public string LocationStatus { get; set; }

        public Medicine(int totalMed, string medName, DateTime expireDate, string postedLocation, string locationStatus)
        {
            TotalMed = totalMed;
            MedName = medName;
            ExpireDate = expireDate;
            PostedLocation = postedLocation;
            LocationStatus = locationStatus;
        }
    }
}
