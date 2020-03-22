using System;

namespace Data.Models
{
    public class MobilePhoneCallingPlanAssignment
    {
        public int PhoneNumber { get; set; }
        public PhoneLine PhoneLine { get; set; }
        
        public DateTime CallingPlanAssignmentDateTime { get; set; }
        
        public int CallingPlanId { get; set; }
        public CallingPlan CallingPlan { get; set; }
        
        public int MinutesConsumed { get; set; }
        public int MessagesSent { get; set; }
        
    }
}