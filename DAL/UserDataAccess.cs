using UniversityInterface.Server.Models;

namespace DAL
{
    public class UserDataAccess : DataAccessor
    {

        public UserDataAccess(String connection_string) : base(connection_string, "Users") { }

        public List<User> getUsers() {
            List<User> users = new List<User>();
            var reader = getReader();
            while (reader.Read())
            {
                users.Add(new User
                {
                    user_id = Convert.ToInt64(reader["userid"]),
                    user_name = reader["username"].ToString(),
                    pass_hash = reader["password"].ToString(),
                    email = reader["email"].ToString(),
                    role = UserRoleManager.getRoleFromIndex(Convert.ToInt32(reader["userrole"]))
                });
            }
            return users;
        }


    }
}
