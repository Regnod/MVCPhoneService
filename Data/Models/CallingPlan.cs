using System.Collections.Generic;

namespace Data.Models
{
    public class CallingPlan
    {
        public  int CallingPlanId { get; set; }
        public int Minutes { get; set; }
        public int Messages { get; set; }
        public  List<MobilePhoneCallingPlanAssignment> MobilePhoneCallingPlanAssignments { get; set; }
    }
}