using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data
{
    public class MobilePhone
    {
        [Key]
        public int IMEI { get; set; }
        
        public string Modelo { get; set; }
        
        public List<MobilePhoneWithLine> MobilePhoneWithLines { get; set; }
    }
}