using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splitwize
{
    public class Members
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAdress { get; set; }
        public string PhoneNumber { get; set; }

        public Members() 
        {
            FirstName = "";
            LastName = "";
            EmailAdress = "";
            PhoneNumber = "";
        }

        public Members(string firstName, string lastName, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAdress = phoneNumber;
        }
    }
}
