using System.ComponentModel.DataAnnotations;

namespace Data
{
    public class MobilePhoneEmployee
    {
        public int IMEI { get; set; }
        public  MobilePhone MobilePhone { get; set; }
        
        public  int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}