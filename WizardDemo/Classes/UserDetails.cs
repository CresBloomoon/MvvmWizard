using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardDemo.Classes
{
    public class UserDetails
    {
        public UserDetails(string firstName, string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public string Email { get; }
    }
}
