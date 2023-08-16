using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_Tutorial.Data;
using EF_Tutorial.Interface;
using EF_Tutorial.Models;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;
using System.Security.Cryptography;
using BCrypt.Net;

namespace EF_Tutorial.Repository
{
    public class UserRepository : IUser
    {
        // private int _userId = 2;
        //Password hashing variables
        static int keySize = 15;
        static int iterations = 3500;
        static string hashPassword = "";
        static List<string> passwordList = new List<string>();
        private List<string> saltedPasses = new List<string>();
        // dynamic byte[] salt;
        // byte[] salt = RandomNumberGenerator.GetBytes(15);
        string salt = GenerateSalt();
        // byte[] salt = new byte[keySize];
        static HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA256;

        static string GenerateSalt()
        {
            byte[] saltBytes = new byte[15];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }

        static string HashPassword(string password, string salt)
        {
            byte[] saltBytes = Convert.FromBase64String(salt);
            var hash = Rfc2898DeriveBytes.Pbkdf2(
                        password,
                        saltBytes,
                        iterations,
                        hashAlgorithm,
                        keySize);

            return Convert.ToBase64String(hash);
        }

        // private static bool VerifyPassword(string enteredPassword, string salt, string storedHashedPassword)
        // {
        //     string hashedEnteredPassword = HashPassword(enteredPassword, salt);
        //     string hashedEnteredPassword2 = HashPassword(enteredPassword, salt);
        //     Console.WriteLine("hashedEntered: " + hashedEnteredPassword);
        //     Console.WriteLine("storedhashed: " + hashedEnteredPassword2);
        //     return string.Equals(hashedEnteredPassword, storedHashedPassword);
        // }

        // private string HashPassword(string password, byte[] salt)
        // {
        //     // salt = RandomNumberGenerator.GetBytes(keySize);

        //     var hash = Rfc2898DeriveBytes.Pbkdf2(
        //                 Encoding.UTF8.GetBytes(password),
        //                 salt,
        //                 iterations,
        //                 hashAlgorithm,
        //                 keySize);

        //     return Convert.ToHexString(hash);
        // }

        private bool VerifyPassword(string enteredPassword, string userPassword)
        {
            bool isValidPassword = BCrypt.Net.BCrypt.Verify(enteredPassword, userPassword);
            return isValidPassword;
        }

        private readonly DataContext _dataContext;
        public UserRepository(DataContext dataContext)
        {
            _dataContext = dataContext;

        }

        public ICollection<User> GetUsers()
        {
            // JsonDataRepository dataRepository = new JsonDataRepository();
            // Console.WriteLine(dataRepository);
            return _dataContext.Users.OrderBy(u => u.UserId).ToList();
        }

        public User GetUserById(int id)
        {
            return _dataContext.Users.Find(id);
        }

        public bool CreateUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("user is null");
            }
            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(user.Password);
            user.Password = hashedPassword;
            _dataContext.Add(user);
            return Save();
            // user.Id = _userId++;
            // user.UserId = _userId++;
            // string userPassword = user.Password;
            // hashPassword = HashPassword(userPassword, salt);
            // Console.WriteLine($"Password hash: {hashPassword}");
            // Console.WriteLine($"Generated Salt: {Convert.ToHexString(salt)}");
            // saltedPasses.Add(Convert.ToHexString(salt));
            // Console.WriteLine("SaltedPasses: " + saltedPasses[0]);
            // var checkUserPass = VerifyPassword(userPassword, salt, hashPassword);
            // Console.WriteLine(checkUserPass);
            // user.Password = hashPassword;
            // Console.WriteLine(user.Password);
        }

        // private bool UserPasswordCheck(int userId, string password)
        // {
        //     // string userPassword = password;
        //     var user = GetUserById(userId);
        //     var userPassword = user.Password;
        //     bool checkPass = verifyPassword(password, userPassword, salt);
        //     Console.WriteLine(checkPass);
        //     return checkPass;
        // }

        // public bool CheckUserLogin(int userId, string password)
        // {
        //     var user = GetUserById(userId);
        //     var userPassword = user.Password;
        //     // Console.WriteLine(userPassword);
        //     bool checkUserPass = VerifyPassword(password, userPassword);
        //     Console.WriteLine(checkUserPass);
        //     return checkUserPass;
        //     // return true;
        // }

        public bool UserExists(int userId)
        {
            return _dataContext.Users.Any(u => u.UserId == userId);
        }

        public bool Save()
        {
            var saved = _dataContext.SaveChanges();
            return saved > 0 ? true : false;
        }

        // public bool Save()
        // {
        //     var saved = _dataContext.SaveChanges();
        //     return saved > 0 ? true : false;
        // }

    }
}