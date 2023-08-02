using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_Tutorial.Models;

namespace EF_Tutorial.Interface
{
    public interface IUser
    {
        ICollection<User> GetUsers();
        User GetUserById(int id);
        User CreateUser(User user);
        bool UserExists(int userId);
    }
}