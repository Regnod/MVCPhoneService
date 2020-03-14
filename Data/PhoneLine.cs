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
        
        public  List<MobilePhoneWithLine> MobilePhoneWithLines { get; set; }
    }
}