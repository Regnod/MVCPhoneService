using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace Data
{
    public class PhoneLine
    {
        [Key]
        public int PhoneNumber { get; set; }
        public int PUK { get; set; }
        public int PIN { get; set; }
        
        public List<PhoneLineEmployee> PhoneLineEmployees { get; set; }
        public List<MobilePhoneCall> MobilePhoneCalls { get; set; }
        public List<MobilePhoneDataPlanAssignment> MobilePhoneDataPlanAssignments { get; set; }
        public List<MobilePhoneCallingPlanAssignment> MobilePhoneCallingPlanAssignments { get; set; }
        
    }
}