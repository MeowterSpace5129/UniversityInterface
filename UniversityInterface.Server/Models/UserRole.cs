using System.Data;

namespace UniversityInterface.Server.Models
{
    public enum UserRole
    {
        None = 0,
        Student = 1,
        Teacher = 2,
        Admin = 3,
    }
    public static class UserRoleManager {
        public static int getRoleIndex(UserRole role) { 
            if (role == UserRole.None) return 0;
            if (role == UserRole.Student) return 1;
            if (role == UserRole.Teacher) return 2;
            if (role == UserRole.Admin) return 3;
            throw new Exception("UserRole not assosiated with an index");
        }

        public static UserRole getRoleFromIndex(int index) {
            if (index == 0) return UserRole.None;
            if (index == 1) return UserRole.Student;
            if (index == 2) return UserRole.Teacher;
            if (index == 3) return UserRole.Admin;
            throw new Exception("Index not assosiated with a UserRole");
        }

    }
}