using System;

namespace Data
{
    public class MobilePhoneDataPlanAssignment
    {
        public int PhoneNumber { get; set; }
        public PhoneLine PhoneLine { get; set; }
        
        public DateTime DataPlanAssignmentDateTime { get; set; }
        
        public int DataPlanId { get; set; }
        public DataPlan DataPlan { get; set; }
        
        public int NationalDataUsage { get; set; }
        public int InternationalDataUsage { get; set; }
    }
}