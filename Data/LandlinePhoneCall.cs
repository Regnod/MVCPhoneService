using System;

namespace Data
{
    public class LandlinePhoneCall
    {
        public int Extension { get; set; }
        public DateTime LandlinePhoneCallDateTime { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public string Destination { get; set; }
        public int LandlinePhoneCallCost { get; set; }
        public int LandlinePhoneCallDuration { get; set; }
        public int LandlinePhoneCallAddressee { get; set; }
    }
}