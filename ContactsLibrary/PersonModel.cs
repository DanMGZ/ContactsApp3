using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsLibrary
{
    public class PersonModel
    {
        /// <summary>
        /// The ID returned from SQL when a record is inserted to the Contacts table
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// The first name of a contact.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of a contact.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The phone number of a contact.
        /// </summary>
        public string PhoneNumber { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{FirstName} {LastName} ({PhoneNumber})";
            }
        }
    }
}
