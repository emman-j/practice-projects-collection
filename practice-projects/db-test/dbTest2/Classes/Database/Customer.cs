using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbTest2
{
    public class Customer
    {
        public string CompanyName { get; set; } 

        public string ContactName { get; set; }

        public string ContactTitle { get; set; }

        public string Phone { get; set; }

        public string Country { get; set; }

        public string CusFullInfo 
        {
            get
            {
                return $"{CompanyName}, ({ContactTitle}) {ContactName} ";
            }
        }


    }
}
