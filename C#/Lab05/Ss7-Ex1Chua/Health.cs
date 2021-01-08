using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ss7_Ex1Chua
{
    class Health
    {
        public int RecordId { get; set; }
        public string Reason { get; set; }
        public string Prescription { get; set; }
        public DateTime RecordDate { get; set; }

        public override string ToString()
        {
            return $"RecordId: {RecordId}, Reason: {Reason}, Prescription: {Prescription}, RecordDate: {RecordDate.Date}";
        }
    }
}
