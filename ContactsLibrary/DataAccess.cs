using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ContactsLibrary
{
    public class DataAccess
    {
        /// <summary>
        /// Pass in a last name and get back a list of Persons
        /// </summary>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public List<PersonModel> GetContacts(string lastName)
        {
            //the actual connection to SQL Server - the arg is (gets) the connection string in app.config
            // the using statement creates the NEW connection
            // output gets:  take the connection and ask for a list after I run stored proc
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigHelper.CnnString("ContactsApp")))
            {
                // TODO - understand this
                var output = connection.Query<PersonModel>("dbo.spGetContactsByLastName @LastName", new { LastName = lastName }).ToList();
                return output;
            }
        }
        public void InsertContact(string firstName, string lastName, string phoneNumber)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigHelper.CnnString("ContactsApp")))
            {
                PersonModel newContact = new PersonModel
                { FirstName = firstName, LastName = lastName, PhoneNumber = phoneNumber};

                connection.Execute("dbo.spInsertContact @FirstName, @LastName, @PhoneNumber", newContact);
            }

        }

    }
}
