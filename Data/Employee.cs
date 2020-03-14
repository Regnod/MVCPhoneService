using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        
        public string EmployeeName { get; set; }
        public string CostCenter { get; set; }
        public int PersonalCode { get; set; }
        
        public  IEnumerable<MobilePhoneEmployee> MobilePhoneEmployees { get; set; }
        public  List<PhoneLineEmployee> PhoneLineEmployees { get; set; }
    }
}