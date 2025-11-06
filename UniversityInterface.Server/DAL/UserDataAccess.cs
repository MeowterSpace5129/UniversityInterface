using UniversityInterface.Server.Models;
using Microsoft.Data.SqlClient;

namespace DAL
{
    public class UserDataAccess : DataAccessor
    {

        public UserDataAccess(String connection_string) : base(connection_string, "Users") { }

        public List<User> getUsers() {
            List<User> users = new List<User> ();
            List<List<String>> usersData = getData(["name", "id"]);

            return users;
        }


    }
}
