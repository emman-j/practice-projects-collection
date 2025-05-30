using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp3
{
    public class Person
    {
        //Fields
        private string firstname;
        private string lastname;
        //private string emailAdress;
        //private string phoneNumber;

        //Constructor
        public Person(string FirstName, string LastName)
        {
            firstname = FirstName;
            lastname = LastName;
        }

        //public FullInfoPerson(string FirstName, string LastName, string emailAd, string phoneNum)
        //{
        //    firstname = FirstName;
        //    lastname = LastName;
        //    emailAdress = emailAd;
        //    phoneNumber = phoneNum;
        //}

        //Property access
        public string Fname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string Lname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        //public string email
        //{
        //    get { return emailAdress; }
        //    set { emailAdress = value; }
        //}

        //public string phone
        //{
        //    get { return phoneNumber; }
        //    set { phoneNumber = value; }
        //}
    }
}
