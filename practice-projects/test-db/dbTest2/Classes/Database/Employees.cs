using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbTest2
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

}
