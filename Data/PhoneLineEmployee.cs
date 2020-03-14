namespace Data
{
    public class PhoneLineEmployee
    {
        public int PhoneNumber { get; set; }
        public  PhoneLine PhoneLine { get; set; }
        
        public  int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}