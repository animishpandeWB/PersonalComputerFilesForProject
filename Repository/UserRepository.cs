using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_Tutorial.Data;
using EF_Tutorial.Interface;
using EF_Tutorial.Models;

namespace EF_Tutorial.Repository
{
    public class UserRepository : IUser
    {
        private int _userId = 2;
        private readonly DataContext _dataContext;
        public UserRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public ICollection<User> GetUsers()
        {
            return _dataContext.Users.OrderBy(u => u.Id).ToList();
        }

        public User GetUserById(int id)
        {
            return _dataContext.Users.Find(id);
        }

        public User CreateUser(User user)
        {
            if(user == null) {
                throw new ArgumentNullException("user is null");
            }
            user.Id = _userId++;
            _dataContext.Add(user);
            return user;
        }

        public bool UserExists(int userId)
        {
            return _dataContext.Users.Any(u => u.Id == userId);
        }
        
        // public bool Save()
        // {
        //     var saved = _dataContext.SaveChanges();
        //     return saved > 0 ? true : false;
        // }

    }
}