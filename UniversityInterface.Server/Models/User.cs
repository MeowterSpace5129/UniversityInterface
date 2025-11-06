using UniversityInterface.Server.Models;

namespace UniversityInterface.Server.Models
{
    public class User
    {
        public required long user_id;
        public required String user_name;
        public required String pass_hash;
        public required String email;
        public required UserRole role;
    }
}
