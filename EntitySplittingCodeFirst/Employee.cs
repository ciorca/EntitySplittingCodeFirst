using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntitySplittingCodeFirst
{
    public class Employee
    {
        //These prop values shoul be stored in Employees Table
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        //These prop values shoul be stored in EmployeeContactDetails Table
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string LandLine { get; set; }
    }
}