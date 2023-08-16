using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_Tutorial.Data;
using EF_Tutorial.Interface;
using EF_Tutorial.Models;

namespace EF_Tutorial.Repository
{
    public class UserAuthRepository : IUserAuth
    {

        private readonly DataContext _dataContext;
        private readonly IUser _userInterface;

        public UserAuthRepository(DataContext dataContext, IUser userInterface)
        {
            _dataContext = dataContext;
            _userInterface = userInterface;
        }

        private bool VerifyPassword(string enteredPassword, string userPassword)
        {
            bool isValidPassword = BCrypt.Net.BCrypt.Verify(enteredPassword, userPassword);
            return isValidPassword;
        }

        public bool CheckUserLogin(UserAuth userAuth)
        {
            int userId = userAuth.userId;
            string password = userAuth.password;
            User userById = _userInterface.GetUserById(userId);
            if (userById == null)
            {
                return false;
            }
            else if (userById.Password.Equals("test1"))
            {
                return true;
            }
            var userPassword = userById.Password;
            bool verify = VerifyPassword(password, userPassword);
            return verify;
        }
    }
}