using System.Collections.Generic;

namespace Data.Models
{
    public class DataPlan
    {
        public int DataPlanId { get; set; }
        public int NationalData { get; set; }
        public int InternationalData { get; set; }
        public List<MobilePhoneDataPlanAssignment> MobilePhoneDataPlanAssignments { get; set; }
    }
}