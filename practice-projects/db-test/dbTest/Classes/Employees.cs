using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbTest.Classes
{
    public class Employees
    {
        public string FirstName { get; set; }   
        public string LastName { get; set; }
        public string Title { get; set; }   
        public string PhoneNumber { get; set; } 
        public string EmpFullInfo 
        {
            get
            {
                return $"{FirstName} {LastName}, {Title}";
            }
        }
    }

  /*  public class Customer
    {
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }    
        public string Region { get; set; }  
        public string CustomerFullInfo
        {
            get
            {
                return $"{CompanyName}, {ContactName}, {ContactTitle}, {Phone}";
            }
        }

    }*/
}
