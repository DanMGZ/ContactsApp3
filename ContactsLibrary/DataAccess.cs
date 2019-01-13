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
                // .Query is from Dapper I think and you use it when you want something back
                var output = connection.Query<PersonModel>("dbo.spGetContactsByLastName @LastName", new { LastName = lastName }).ToList();
                return output;
            }
        }

        //public void InsertContact(string firstName, string lastName, string phoneNumber)
        public void InsertContact(PersonModel person)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConfigHelper.CnnString("ContactsApp")))
            {
                //   @FirstName nvarchar(50),
                //@LastName nvarchar(50),
                //@PhoneNumber varchar(25),
                //@ID int = 0 output
                // TODO - change this code so that we get back an ID for new entry
                //PersonModel newContact = new PersonModel
                //{ FirstName = firstName, LastName = lastName, PhoneNumber = phoneNumber };

                //connection.Execute("dbo.spInsertContact @FirstName, @LastName, @PhoneNumber", newContact);

                // have to use DynamicParameters() to get back id
                // could use DynamicParameters instead of var
                var listOfVariables = new DynamicParameters();
                listOfVariables.Add("@FirstName", person.FirstName);
                listOfVariables.Add("@LastName", person.LastName);
                listOfVariables.Add("@PhoneNumber", person.PhoneNumber);
                listOfVariables.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spInsertContact", listOfVariables, commandType: CommandType.StoredProcedure);

                person.ID = listOfVariables.Get<int>("@ID");

            }

        }

    }
}
