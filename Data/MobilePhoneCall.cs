using System;

namespace Data
{
    public class MobilePhoneCall
    {
        public int PhoneNumber { get; set; }
        public PhoneLine PhoneLine { get; set; }
        
        public int IMEI { get; set; }
        public MobilePhone MobilePhone { get; set; }
        
        public DateTime DateTime { get; set; }
        
        public int MobilePhoneCallAddressee { get; set; }
        public int MobilePhoneCallDuration { get; set; }
        public int MobilePhoneCallCost { get; set; }
    }
}