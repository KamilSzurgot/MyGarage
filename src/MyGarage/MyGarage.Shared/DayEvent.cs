using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Shared
{
    public class DayEvent
    {
        public int DayEventID { get; set; }
        public string Note { get; set; }
        public DateTime EventDate { get; set; } = new DateTime(1900, 1, 1);
        public DateTime FromDate { get; set; } = new DateTime(1900, 1, 1);
        public DateTime ToDate { get; set; } = new DateTime(1900, 1, 1);
        public string DateValue { get; set; }
        public string Message { get; set; }
    }
}
