namespace Data
{
    public class MobilePhoneWithLine
    {
        public int PhoneNumber { get; set; }
        public PhoneLine PhoneLine { get; set; }
        
        public int IMEI { get; set;}
        public MobilePhone MobilePhone { get; set; }
    }
}